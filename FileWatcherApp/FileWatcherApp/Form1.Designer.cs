namespace FileWatcherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.fldrBr1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fldrBr2 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFldrBr1 = new System.Windows.Forms.Button();
            this.btnFldrBr2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(82, 37);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = " From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(82, 74);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C:\\Users\\A548697\\Desktop\\FW\\IN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "C:\\Users\\A548697\\Desktop\\FW\\OUT";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(121, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(167, 107);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(37, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // fldrBr1
            // 
            this.fldrBr1.SelectedPath = "C:\\MyDrive_Ajay\\filewatcher\\IN";
            // 
            // fldrBr2
            // 
            this.fldrBr2.SelectedPath = "C:\\MyDrive_Ajay\\filewatcher\\IN";
            // 
            // btnFldrBr1
            // 
            this.btnFldrBr1.Location = new System.Drawing.Point(227, 32);
            this.btnFldrBr1.Name = "btnFldrBr1";
            this.btnFldrBr1.Size = new System.Drawing.Size(20, 23);
            this.btnFldrBr1.TabIndex = 6;
            this.btnFldrBr1.Text = "...";
            this.btnFldrBr1.UseVisualStyleBackColor = true;
            this.btnFldrBr1.Click += new System.EventHandler(this.btnFldrBr1_Click);
            // 
            // btnFldrBr2
            // 
            this.btnFldrBr2.Location = new System.Drawing.Point(227, 71);
            this.btnFldrBr2.Name = "btnFldrBr2";
            this.btnFldrBr2.Size = new System.Drawing.Size(20, 23);
            this.btnFldrBr2.TabIndex = 7;
            this.btnFldrBr2.Text = "...";
            this.btnFldrBr2.UseVisualStyleBackColor = true;
            this.btnFldrBr2.Click += new System.EventHandler(this.btnFldrBr2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.btnFldrBr2);
            this.Controls.Add(this.btnFldrBr1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FolderBrowserDialog fldrBr1;
        private System.Windows.Forms.FolderBrowserDialog fldrBr2;
        private System.Windows.Forms.Button btnFldrBr1;
        private System.Windows.Forms.Button btnFldrBr2;
    }
}

