using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderPictureViewer
{
    public partial class PictureViewer : Form
    {
        private string pathname = string.Empty;

        public PictureViewer()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            Debug.WriteLine("OpenFileDialog  = ");
            file.InitialDirectory = ".Resources";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                try
                {
                    pathname = file.FileName;   
                    this.pictureBoxOpenView.Load(pathname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
