using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderPainter
{
    public partial class Painter : Form
    {
        private  PainterModel model;
        public Painter()
        {
            InitializeComponent();
            model = PainterModel.Instance();
        }

        private void Painter_Load(object sender, EventArgs e)
        {
            toolStripMenuItemNewFile_Click(sender, e);
        }

        private void toolStripMenuItemNewFile_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Image = new Bitmap(800, 600);
            Graphics graphics = Graphics.FromImage(pictureBoxShow.Image);
            graphics.Clear(Color.White);
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxShow.Load(openFileDialog.FileName);
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(pictureBoxShow.Image);
                bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxShow_MouseDown(object sender, MouseEventArgs e)
        {
            model.MouseY = e.Y;
            model.MouseX = e.X;
        }

        private void pictureBoxShow_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Graphics graphics = Graphics.FromImage(pictureBoxShow.Image);
                Pen pen = new Pen(colorDialog.Color, int.Parse(toolStripComboBoxSize.Text));
                graphics.DrawLine(pen, model.MouseX, model.MouseY, e.X, e.Y);
                model.MouseX = e.X;
                model.MouseY = e.Y;
                pictureBoxShow.Refresh();
            }
            
        }

        private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void toolStripComboBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
