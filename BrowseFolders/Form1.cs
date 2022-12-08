using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowseFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDesktop_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogDesktop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialogDesktop.SelectedPath, "Selected Folder");
            }
        }

        private void buttonMyComputer_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogMyComputer.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialogMyComputer.SelectedPath, "Selected Folder");
            }
        }
    }
}
