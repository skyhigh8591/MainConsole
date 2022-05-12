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

        /// <summary>
        /// 設定輸入值 是否為數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxChinese_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 設定輸入值 是否為數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 設定輸入值 是否為數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxMath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 限制輸入的數字最大值
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

        private void InputText()
        {
            name = textBoxName.Text;
            chinese = Convert.ToInt32(textBoxChinese.Text);
            english = Convert.ToInt32(textBoxEnglish.Text);
            math = Convert.ToInt32(textBoxMath.Text);
        }

        private void StatisticalOperations(int _chinese, int _english, int _math)
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
            dataGridView.Rows.Add(name, chinese, english, math, totalScore, average, maxStr + max, minStr + min);
            buttonStatistics.Enabled = true;
        }

        private void ButtonRandomSave_Click(object sender, EventArgs e)
        {
            RandomlyGenerated();
        }

        private void RandomlyGenerated()
        {
            Random random = new Random();
            int randomlyName = (dataGridView.Rows.Count) + 1 ;
            int randomlyChinese = random.Next(0, 100);
            int randomlyEnglish = random.Next(0, 100);
            int randomlyMath = random.Next(0, 100);
            StatisticalOperations(randomlyChinese, randomlyEnglish, randomlyMath);

            buttonStatistics.Enabled = true;
            dataGridView.Rows.Add(randomlyName, randomlyChinese, randomlyEnglish, randomlyMath, totalScore, average, maxStr + max, minStr + min);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonStatistics.Enabled = false;
            dataGridView.Rows.Clear();
            labelStatistics.Text = "";
        }

        private void buttonRandomJoinTwenty_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                RandomlyGenerated();
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            Statistics();
        }

        private void Statistics()
        {
            int chinese = 0;
            int chineseTotal = 0;
            int chineseAvg = 0;
            int chineseMax = 0;
            int chineseMin = 100;

            int english = 0;
            int englishTotal = 0;
            int englishAvg = 0;
            int englishMax = 0;
            int englishMin = 100;

            int math = 0;
            int mathTotal = 0;
            int mathAvg = 0;
            int mathMax = 0;
            int mathMin = 100;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                chinese = Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value);
                Debug.WriteLine("chinese" + chinese);
                chineseTotal = chineseTotal + chinese;
                if (chineseMax < chinese)
                {
                    chineseMax = chinese;
                }

                if (chineseMin > chinese)
                {
                    chineseMin = chinese;
                }

                english = Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                englishTotal = englishTotal + chinese;
                if (englishMax < english)
                {
                    englishMax = english;
                }

                if (englishMin > english)
                {
                    englishMin = english;
                }

                math = Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value);
                mathTotal = mathTotal + math;
                if (mathMax < math)
                {
                    mathMax = math;
                }

                if (mathMin > math)
                {
                    mathMin = math;
                }


            }

            chineseAvg = chineseTotal / dataGridView.Rows.Count;
            englishAvg = englishTotal / dataGridView.Rows.Count;
            mathAvg = mathTotal / dataGridView.Rows.Count;

            labelStatistics.Text = "總分 " + " 國文 : " + chineseTotal + " 英文 : " + englishTotal + " 數學 : " + mathTotal + "\n" +
                "平均 " + " 國文 : " + chineseAvg + " 英文 : " + englishAvg + " 數學 : " + mathAvg + "\n" +
                "最高分 " + " 國文 : " + chineseMax + " 英文 : " + englishMax + " 數學 : " + mathMax + "\n" +
                "最低分 " + " 國文 : " + chineseMin + " 英文 : " + englishMin + " 數學 : " + mathMin;


        }

    }
}
