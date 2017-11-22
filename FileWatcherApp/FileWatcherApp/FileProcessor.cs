using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherApp
{
    class FileProcessor
    {
        private DirectoryInfo OutputLocation;
        private FileInfo CurrentFile { get; set; }
        private string CurrentLogFile { get; set; }
        public FileProcessor(FileInfo NewFile, DirectoryInfo outputDirectory)
        {
            CurrentFile = NewFile;
            CurrentLogFile = CurrentFile.FullName.Replace(".txt", ".log.txt");
            OutputLocation = outputDirectory;
        }

        public void ProcessTheFile()
        {
            FileAttributes fab = File.GetAttributes(CurrentFile.FullName);

            if(!((fab | FileAttributes.Hidden)== FileAttributes.Hidden))
            {
                File.SetAttributes(CurrentFile.FullName, FileAttributes.Hidden);
                CreateLogFile();
                SendFile();
                DeleteLogFile();
            }
        }

        private void CreateLogFile()
        {
            if (!File.Exists(CurrentLogFile))
            {
                FileStream fs = null;
                using (fs = File.Create(CurrentLogFile))
                {

                }
            }
        }
        private void DeleteLogFile()
        {
            if (File.Exists(CurrentLogFile))
                File.Delete(CurrentLogFile);
            
        }

        private void SendFile()
        {
            if (File.Exists(CurrentFile.FullName))
                File.Move(CurrentFile.FullName, OutputLocation.FullName +"\\" + CurrentFile.Name);
        }
    }
}
