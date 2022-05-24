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
        int movx = 5;//水平位移距离
        int movy = 5;//垂直位移距离
        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status); //宣告函式(顯示滑鼠)

        public ScreenSaver()
        {
            InitializeComponent();
           
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //螢幕最大化
            labelCat.Location = new Point((Width - labelCat.Width) / 2, (Height - labelCat.Height) / 2);//让屏幕文字居中(水平和垂直)
            ShowCursor(0);//隱藏滑鼠
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaver_MouseMove);
            dx = Control.MousePosition.X;
            dy = Control.MousePosition.Y;

            this.BackColor = Color.Black;//设置屏幕为黑色
            labelCat.ForeColor = Color.White;//设置字体颜色白色
        }

        private void ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();//结束程序
        }

        private void timerScreen_Tick(object sender, EventArgs e)
        {
            //位移
            labelCat.Left -= movx;
            labelCat.Top -= movy;
            //碰到边界反弹
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

        //加以判斷,減少靈敏度。XY移動均大於20才執行
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
