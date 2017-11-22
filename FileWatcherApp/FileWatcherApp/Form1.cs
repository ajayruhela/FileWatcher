using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileWatcherApp
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher FileWatcher= new System.IO.FileSystemWatcher();
        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            btnStop.Enabled = false;
            FileWatcher.Filter = "*.txt";
            FileWatcher.SynchronizingObject = this;
            FileWatcher.IncludeSubdirectories = false;
            FileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            FileWatcher.Created += new FileSystemEventHandler(FileWatcher_Created);

        }

        private void btnFldrBr1_Click(object sender, EventArgs e)
        {
               fldrBr1 = new FolderBrowserDialog();
                if (fldrBr1.ShowDialog() == DialogResult.OK)
                    textBox1.Text = fldrBr1.SelectedPath;
            CheckPath();
            
            

        }
        private void btnFldrBr2_Click(object sender, EventArgs e)
        {
            fldrBr2 = new FolderBrowserDialog();
            if (fldrBr2.ShowDialog() == DialogResult.OK)
                textBox2.Text = fldrBr2.SelectedPath;
            CheckPath();

        }

        

        private void btnStop_Click(object sender, EventArgs e)
        {
            CheckPath();
            btnStop.Enabled = false;
            FileWatcher.EnableRaisingEvents = false;
        }
        private void CheckPath()
        {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                if(System.IO.Directory.Exists(textBox1.Text) && System.IO.Directory.Exists(textBox2.Text))
                {
                    btnStart.Enabled = true;
                   
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            FileWatcher.Path = textBox1.Text;
           
            FileWatcher.EnableRaisingEvents = true;
        }

       

        private void FileWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created)
            {
                if (!e.Name.EndsWith(".log.txt"))
                {
                    FileProcessor fp = new FileProcessor(new FileInfo(e.FullPath), new DirectoryInfo(textBox2.Text));
                    BackgroundWorker bgw = new BackgroundWorker();
                    bgw.DoWork += (s, a) =>
                    {
                        fp.ProcessTheFile();
                    };
                    bgw.RunWorkerCompleted += (s, er) =>
                     {
                         if (er.Error != null) MessageBox.Show("Error" + er.Error);
                         else MessageBox.Show("Finished");
                     };
                    //bgw.WorkerSupportsCancellation = true;
                    bgw.RunWorkerAsync();
                }
            }
        }
    }
}
