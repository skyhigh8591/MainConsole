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
    public partial class StudentsGradeList : Form
    {


        List<ListViewModel> ViewData;

        public StudentsGradeList()
        {
            InitializeComponent();
            textBoxName.Text = "Test";
            textBoxChinese.Text = "0";
            textBoxEnglish.Text = "0";
            textBoxMath.Text = "0";
            textBoxMin.Text = "0";
            textBoxMax.Text = "100";
            ViewData = new List<ListViewModel>();
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
        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxMax);
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            LimitSize(textBoxMin);
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

        private void textBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷輸入是否為數字
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxMax_KeyPress(object sender, KeyPressEventArgs e)
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
        /// 輸出最大值 最小值 平均  與  加總
        /// </summary>
        /// <param name="_chinese"></param>
        /// <param name="_english"></param>
        /// <param name="_math"></param>
        private void StatisticalOperations(bool insert)
        {

            string name = textBoxName.Text;
            int chineseScore = Convert.ToInt32(textBoxChinese.Text);
            int englishScore = Convert.ToInt32(textBoxEnglish.Text);
            int mathScore = Convert.ToInt32(textBoxMath.Text);

            int totalScore = chineseScore + englishScore + mathScore;
            int average = totalScore / 3;

            int[] list = new int[] { chineseScore, englishScore, mathScore };
            int max = list.Max();
            int min = list.Min();

            StringBuilder maxStr = new StringBuilder();
            StringBuilder minStr = new StringBuilder();

            Dictionary<string, int> score = new Dictionary<string, int>();

            score.Add("國文", chineseScore);
            score.Add("英文", englishScore);
            score.Add("數學", mathScore);

            foreach (var scoreKey in score.Where(x => x.Value == max))
            {
                maxStr.Append($"{scoreKey.Key} ");
            }

            foreach (var scoreKey in score.Where(x => x.Value == min))
            {
                minStr.Append($"{scoreKey.Key} ");
            }

            if (insert)
            {
                ViewData.Insert(0, new ListViewModel()
                {
                    Name = name,
                    Chinese = chineseScore,
                    Math = mathScore,
                    English = englishScore,
                    TotalScore = totalScore,
                    Average = average,
                    MaxStr = maxStr.ToString(),
                    MinStr = minStr.ToString(),
                    Max = max,
                    Min = min
                });
            }
            else
            {
                ViewData.Add(new ListViewModel()
                {
                    Name = name,
                    Chinese = chineseScore,
                    Math = mathScore,
                    English = englishScore,
                    TotalScore = totalScore,
                    Average = average,
                    MaxStr = maxStr.ToString(),
                    MinStr = minStr.ToString(),
                    Max = max,
                    Min = min
                });
            }

        }

        public void AddItem()
        {
            listViewData.Items.Clear();

            foreach (var addDate in ViewData)
            {
                ListViewItem list = new ListViewItem();

                list.Text = addDate.Name;
                list.SubItems.Add(addDate.Chinese.ToString());
                list.SubItems.Add(addDate.English.ToString());
                list.SubItems.Add(addDate.Math.ToString());
                list.SubItems.Add(addDate.TotalScore.ToString());
                list.SubItems.Add(addDate.Average.ToString());
                list.SubItems.Add(addDate.MaxStr + addDate.Max);
                list.SubItems.Add(addDate.MinStr + addDate.Min);

                listViewData.Items.Add(list);
            }
        }

        public void FilterIten(int max, int min)
        {

            listViewData.Items.Clear();
            foreach (var addDate in ViewData.Where(x => x.Chinese >= min && x.Chinese <= max))
            {
                ListViewItem list = new ListViewItem();

                list.Text = addDate.Name;
                list.SubItems.Add(addDate.Chinese.ToString());
                list.SubItems.Add(addDate.English.ToString());
                list.SubItems.Add(addDate.Math.ToString());
                list.SubItems.Add(addDate.TotalScore.ToString());
                list.SubItems.Add(addDate.Average.ToString());
                list.SubItems.Add(addDate.MaxStr + addDate.Max);
                list.SubItems.Add(addDate.MinStr + addDate.Min);

                listViewData.Items.Add(list);
            }

        }

        /// <summary>
        /// 新增一筆數據
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StatisticalOperations(false);
            AddItem();
        }

        /// <summary>
        /// 新增在第一欄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            StatisticalOperations(true);
            AddItem();
        }

        /// <summary>
        /// 刪除最後一項
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ViewData.Count == 0)
            {
                return;
            }
            ViewData.Remove(ViewData[(ViewData.Count - 1)]);
            AddItem();
        }

        /// <summary>
        /// 刪除全部紀錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ViewData.Clear();
            listViewData.Items.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FilterIten(Convert.ToInt32(textBoxMax.Text), Convert.ToInt32(textBoxMin.Text));
        }

        private void listBoxStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            listBoxStatistics.Items.Clear();
            listBoxStatistics.Items.Add("項目" + "\t" + "國文" + "\t" + "英文" + "\t" + "數學");
            listBoxStatistics.Items.Add(SumList());
            listBoxStatistics.Items.Add(AvgList());
            listBoxStatistics.Items.Add(MaxList());
            listBoxStatistics.Items.Add(MinList());
        }

        public StringBuilder SumList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"總分\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Sum(x => x.Chinese)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Sum(x => x.English)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Sum(x => x.Math)}\t" : "0\t");
            return stringBuilder;
        }

        public StringBuilder AvgList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"平均\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{Math.Round(ViewData.Average(x => x.Chinese),0)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{Math.Round(ViewData.Average(x => x.English),0)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{Math.Round(ViewData.Average(x => x.Math),0)}\t" : "0\t");
            return stringBuilder;
        }

        public StringBuilder MaxList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"最大\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Max(x => x.Chinese)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Max(x => x.English)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Max(x => x.Math)}\t" : "0\t");
            return stringBuilder;
        }

        public StringBuilder MinList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"最小\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Min(x => x.Chinese)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Min(x => x.English)}\t" : "0\t");
            stringBuilder.Append(ViewData.Count > 0 ? $"{ViewData.Min(x => x.Math)}\t" : "0\t");
            return stringBuilder;
        }
    }
}
