namespace BrowseFolders
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
            this.folderBrowserDialogDesktop = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogMyComputer = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDesktop = new System.Windows.Forms.Button();
            this.buttonMyComputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialogMyComputer
            // 
            this.folderBrowserDialogMyComputer.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // buttonDesktop
            // 
            this.buttonDesktop.Location = new System.Drawing.Point(107, 36);
            this.buttonDesktop.Name = "buttonDesktop";
            this.buttonDesktop.Size = new System.Drawing.Size(119, 23);
            this.buttonDesktop.TabIndex = 0;
            this.buttonDesktop.Text = "Desktop";
            this.buttonDesktop.UseVisualStyleBackColor = true;
            this.buttonDesktop.Click += new System.EventHandler(this.buttonDesktop_Click);
            // 
            // buttonMyComputer
            // 
            this.buttonMyComputer.Location = new System.Drawing.Point(107, 79);
            this.buttonMyComputer.Name = "buttonMyComputer";
            this.buttonMyComputer.Size = new System.Drawing.Size(119, 23);
            this.buttonMyComputer.TabIndex = 1;
            this.buttonMyComputer.Text = "My Computer";
            this.buttonMyComputer.UseVisualStyleBackColor = true;
            this.buttonMyComputer.Click += new System.EventHandler(this.buttonMyComputer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 138);
            this.Controls.Add(this.buttonMyComputer);
            this.Controls.Add(this.buttonDesktop);
            this.Name = "Form1";
            this.Text = "Browse Test App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDesktop;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMyComputer;
        private System.Windows.Forms.Button buttonDesktop;
        private System.Windows.Forms.Button buttonMyComputer;
    }
}

