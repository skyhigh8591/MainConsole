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
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = "結果";
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

        private void buttonArraySelectNumber_Click(object sender, EventArgs e)
        {
            List<int> arraySelectNumber = MethodController.Instance().ArrayIsOdd();
            labelResult.Text = "奇數數量  = " + arraySelectNumber[0] + ", 偶數數量 = " + arraySelectNumber[1];
        }

        private void buttonArrayStrMax_Click(object sender, EventArgs e)
        {
            labelResult.Text = "最長的字串為 = " + MethodController.Instance().ArrayStrMax();
        }

        private void buttonArrayMaxMin_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> array = MethodController.Instance().ArrayNumMaxMin();
            labelResult.Text = "最大值 = " + array["Max"] + ", 最小值 = " + array["Min"];
        }

        private void buttonArraySelectStr_Click(object sender, EventArgs e)
        {
            labelResult.Text = "包含 C || c 的名子共有 " + MethodController.Instance().ArraySelectStr() + " 個 ";
        }

        private void buttonTwoArrayOutZero_Click(object sender, EventArgs e)
        {
            labelResult.Text = MethodController.Instance().ArrayOut("1", "0");
        }

        private void buttonTwoArrayOutTwo_Click(object sender, EventArgs e)
        {
            labelResult.Text = MethodController.Instance().ArrayOut("0", "1");
        }

        private void buttonTwoArrayExchange_Click(object sender, EventArgs e)
        {
            labelResult.Text = MethodController.Instance().ArrayExchange();
        }
    }
}
