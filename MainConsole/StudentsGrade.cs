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
        }

        private void StatisticalOperations(int _chinese , int _english , int _math)
        {
            totalScore = _chinese + _english + _math;
            average = totalScore / 3;

            int[] list = new int[] { _chinese, _english, _math };
            max = list.Max();
            min = list.Min();

            maxStr = "";
            minStr = "";

            if (max == _chinese)
            {
                maxStr += "國文 ";
            }

            if (max == _english)
            {
                maxStr += "英文 ";
            }

            if (max == _math)
            {
                maxStr += "數學 ";
            }

            if (min == _chinese)
            {
                minStr += "國文 ";
            }

            if (min == _english)
            {
                minStr += "英文 ";
            }

            if (min == _math)
            {
                minStr += "數學 ";
            }

        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            InputText();
            StatisticalOperations(chinese, english, math);
            dataGridView.Rows.Add(name, chinese, english,math, totalScore, average, maxStr + max, minStr + min);
        }

        private void ButtonRandomSave_Click(object sender, EventArgs e)
        {
            RandomlyGenerated();
        }

        private void RandomlyGenerated()
        {
            Random random = new Random();
            int randomlyName = (dataGridView.Rows.Count);
            int randomlyChinese = random.Next(0,100);
            int randomlyEnglish = random.Next(0, 100);
            int randomlyMath = random.Next(0, 100);
            StatisticalOperations(randomlyChinese, randomlyEnglish, randomlyMath);


            dataGridView.Rows.Add(randomlyName, randomlyChinese, randomlyEnglish, randomlyMath, totalScore, average, maxStr + max, minStr + min);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }

        private void buttonRandomJoinTwenty_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                RandomlyGenerated();
            }
        }
    }
}
