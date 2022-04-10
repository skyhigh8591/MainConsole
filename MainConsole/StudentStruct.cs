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
    public partial class StudentStruct : Form
    {
        private string name;
        private int chinese;
        private int english;
        private int math;

        public StudentStruct()
        {
            InitializeComponent();

            textBoxName.Text = "Test";
            textBoxChinese.Text = "0";
            textBoxEnglish.Text = "0";
            textBoxMath.Text = "0";
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            inputText();
            labelShow.Text = "姓名 = " + name + "\n" +
                 "國文 = " + chinese + "\n" +
                  "英文 = " + english + "\n" +
                   "數學 = " + math;
        }

        private void textBoxChinese_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxChinese);
        }

        private void textBoxEnglish_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxEnglish);
        }

        private void textBoxMath_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxMath);
        }

        private void textBoxChinese_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char) 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void LimitSize(TextBox textBox)
        {
            if(textBox.Text == " " || textBox.Text == "")
            {
                textBox.Text = "0";
            }
            int number = int.Parse(textBox.Text);
            textBox.Text = number.ToString();
            if(number <= 100)
            {
                return;
            }
            textBox.Text = textBox.Text.Remove(2);
            textBox.SelectionStart = textBox.Text.Length;
            
        }

        private void inputText()
        {
            name = textBoxName.Text;
            chinese = Convert.ToInt32(textBoxChinese.Text);
            english = Convert.ToInt32(textBoxEnglish.Text);
            math = Convert.ToInt32(textBoxMath.Text);
        }

        private void buttonShowDave_Click(object sender, EventArgs e)
        {
            inputText();
            string input =  "姓名 = " + name + "\n" +
                 "國文 = " + chinese + "\n" +
                  "英文 = " + english + "\n" +
                   "數學 = " + math;

            MessageBox.Show(input, "目前輸入的成績", MessageBoxButtons.OK);
        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            inputText();
            int[] list = new int[] { chinese, english, math };

            int max = list.Max();
            int min = list.Min();

            string maxStr = "";
            string minStr = "";

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

            labelMaxMin.Text ="最大值為 " + maxStr + "成績:" + max + "\n" +
                "最小值為 " + minStr + "成績:" + min ;


        }

      
    }
}
