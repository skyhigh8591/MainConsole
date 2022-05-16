using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderMethod
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void buttonSelectNumber_Click(object sender, EventArgs e)
        {
            string message = "未數入數字";
            if (textBoxNumber.Text == "")
            {
                MessageBox.Show(message, "輸入的數字為奇數或偶數");
                return;
            }
            message = MethodController.Instance().IsOdd(Int32.Parse(textBoxNumber.Text)) ? "奇數" : "偶數";
            MessageBox.Show(message, "輸入的數字為奇數或偶數");
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
