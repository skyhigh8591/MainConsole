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

        /// <summary>
        /// 輸出最大值 最小值 平均  與  加總
        /// </summary>
        /// <param name="_chinese"></param>
        /// <param name="_english"></param>
        /// <param name="_math"></param>
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

        /// <summary>
        /// 新增一筆數據
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            InputText();
            ListViewItem list = new ListViewItem();
            StatisticalOperations(chinese, english, math);

            list.Text = textBoxName.Text;
            list.SubItems.Add(textBoxChinese.Text);
            list.SubItems.Add(textBoxEnglish.Text);
            list.SubItems.Add(textBoxMath.Text);
            list.SubItems.Add(totalScore.ToString());
            list.SubItems.Add(average.ToString());
            list.SubItems.Add(maxStr + max);
            list.SubItems.Add(minStr + min);

            listViewData.Items.Add(list);
        }

        /// <summary>
        /// 新增在第一欄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InputText();
            ListViewItem list = new ListViewItem();
            StatisticalOperations(chinese, english, math);

            list.Text = textBoxName.Text;
            list.SubItems.Add(textBoxChinese.Text);
            list.SubItems.Add(textBoxEnglish.Text);
            list.SubItems.Add(textBoxMath.Text);
            list.SubItems.Add(totalScore.ToString());
            list.SubItems.Add(average.ToString());
            list.SubItems.Add(maxStr + max);
            list.SubItems.Add(minStr + min);

            listViewData.Items.Insert(0, list);  
        }

        /// <summary>
        /// 刪除最後一項
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listViewData.Items.Count == 0)
            {
                return;
            }
            listViewData.Items.Remove(listViewData.Items[listViewData.Items.Count-1]); 
        }

        /// <summary>
        /// 刪除全部紀錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewData.Items.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewData.Items[0]
        }
    }
}
