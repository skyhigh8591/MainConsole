using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole
{
    public partial class StudentsGrade : Form
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

        public StudentsGrade()
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
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextBoxEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextBoxMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

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

        private void InputText()
        {
            name = textBoxName.Text;
            chinese = Convert.ToInt32(textBoxChinese.Text);
            english = Convert.ToInt32(textBoxEnglish.Text);
            math = Convert.ToInt32(textBoxMath.Text);
            totalScore = chinese + english + math;
            average = totalScore / 3;
        }

        private void MaxMin()
        {
            InputText();
            int[] list = new int[] { chinese, english, math };

            max = list.Max();
            min = list.Min();

            maxStr = "";
            minStr = "";

            if (max == chinese)
            {
                maxStr += "國文 ";
            }

            if (max == english)
            {
                maxStr += "英文 ";
            }

            if (max == math)
            {
                maxStr += "數學 ";
            }

            if (min == chinese)
            {
                minStr += "國文 ";
            }

            if (min == english)
            {
                minStr += "英文 ";
            }

            if (min == math)
            {
                minStr += "數學 ";
            }

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            InputText();
            MaxMin();
            dataGridView.Rows.Add(name, chinese, english,math, totalScore, average, maxStr + max, minStr + min);
        }

        private void buttonRandomSave_Click(object sender, EventArgs e)
        {

        }
    }
}
