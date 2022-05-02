using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole
{
    public partial class StudentsGradeList : Form
    {

        private string name;
        private int chinese;
        private int english;
        private int math;
        private int totalScore;
        private int average;
        private string maxStr = "";
        private string minStr = "";
        private int max = 0;
        private int min = 0;

        public StudentsGradeList()
        {
            InitializeComponent();
            textBoxName.Text = "Test";
            textBoxChinese.Text = "0";
            textBoxEnglish.Text = "0";
            textBoxMath.Text = "0";
        }

        private void TextBoxChinese_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxChinese);
        }

        private void TextBoxEnglish_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxEnglish);
        }

        private void TextBoxMath_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxMath);
        }

        private void TextBoxChinese_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷輸入是否為數字
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextBoxEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷輸入是否為數字
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextBoxMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷輸入是否為數字
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 判斷書入的數值有沒有超過100
        /// </summary>
        /// <param name="textBox"></param>
        private void LimitSize(TextBox textBox)
        {
            if (textBox.Text == " " || textBox.Text == "")
            {
                textBox.Text = "0";
            }
            int number = int.Parse(textBox.Text);
            textBox.Text = number.ToString();
            if (number <= 100)
            {
                return;
            }
            textBox.Text = textBox.Text.Remove(2);
            textBox.SelectionStart = textBox.Text.Length;

        }

        /// <summary>
        /// 將目前 Text的數值 儲存起來
        /// </summary>
        private void InputText()
        {
            name = textBoxName.Text;
            chinese = Convert.ToInt32(textBoxChinese.Text);
            english = Convert.ToInt32(textBoxEnglish.Text);
            math = Convert.ToInt32(textBoxMath.Text);
        }

     
    }
}
