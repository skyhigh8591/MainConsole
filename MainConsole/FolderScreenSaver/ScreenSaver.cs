using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderScreenSaver
{
    public partial class ScreenSaver : Form
    {
        int dx;
        int dy;
        int movx = 5;
        int movy = 5;
        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status); 

        public ScreenSaver()
        {
            InitializeComponent();
           
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
            labelCat.Location = new Point((Width - labelCat.Width) / 2, (Height - labelCat.Height) / 2);
            ShowCursor(0);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaver_MouseMove);
            dx = Control.MousePosition.X;
            dy = Control.MousePosition.Y;

            this.BackColor = Color.Black;
            labelCat.ForeColor = Color.White;
        }

        private void ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void timerScreen_Tick(object sender, EventArgs e)
        {
            
            labelCat.Left -= movx;
            labelCat.Top -= movy;
            
            if (labelCat.Left < 0)
            {
                movx = -movx;
            }
            if (labelCat.Right > Width)
            {
                movx = -movx;
            }
            if (labelCat.Top < 0)
            {
                movy = -movy;
            }
            if (labelCat.Bottom > Height)
            {
                movy = -movy;
            }
        }

       
        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Control.MousePosition.X - dx > 20 || dx - Control.MousePosition.X > 20) && (Control.MousePosition.Y - dy > 20 || dy - Control.MousePosition.Y > 20))
            {
                ShowCursor(1);
                this.Close();
            }
        }
    }
}
