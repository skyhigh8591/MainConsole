using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderForDoWhile
{
    class ForDoWhileController
    {
        private static ForDoWhileController instance;
        private ForDoWhileModel forDoWhileData;

        ForDoWhileController()
        {
            forDoWhileData = ForDoWhileModel.Instance();
        }

        public static ForDoWhileController Instance()
        {
            if (instance == null)
            {
                instance = new ForDoWhileController();
            }
            return instance;
        }

        /// <summary>
        /// 不可輸入數字
        /// </summary>
        /// <param name="e"></param>
        public void NotNumber(ref KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 判斷是否有輸入
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public bool NotText(ref TextBox textBox)
        {
            string message = "未數入數字";
            if (textBox.Text == "")
            {
                MessageBox.Show(message, "輸入的數字為奇數或偶數");
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 跑For迴圈
        /// </summary>
        /// <returns></returns>
        public int RunFor()
        {
            int sum = 0;
            for (int i = forDoWhileData.From; i <= forDoWhileData.To; i++)
            {
                sum += i;
            }
            return sum;
        }

        /// <summary>
        /// 跑While迴圈
        /// </summary>
        /// <returns></returns>
        public int RunWhile()
        {
            int sum = 0;
            int i = forDoWhileData.From;
            while (i <= forDoWhileData.To)
            {
                sum += i;
                i++;
            }
            return sum;
        }

        /// <summary>
        /// 跑 DoWhile迴圈
        /// </summary>
        /// <returns></returns>
        public int RunDoWhile()
        {
            int sum = 0;
            int i = forDoWhileData.From;
            do
            {
                sum += i;
                i++;
            } while (i <= forDoWhileData.To);
            return sum;
        }

        public string RunTriangle()
        {
            string triangle = "";

            for (int i = 0; i < forDoWhileData.Rows; i++)
            {

                int startNum = 0;
                while (startNum <= i)
                {
                    triangle += "*";
                    startNum++;
                }
                triangle += "\r\n";
            }
            return triangle;
        }

        /// <summary>
        /// 九九乘法表
        /// </summary>
        /// <returns></returns>
        public String RunMultiplication()
        {
            String multiplication = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == 9)
                    {
                        multiplication += String.Format("{0}*{1}={2} \t", i, j, i * j);
                        multiplication += "\r\n";
                    }
                    else
                    {
                        multiplication += String.Format("{0}*{1}={2} \t", i, j, i * j);
                    }

                }
            }
            return multiplication;
        }

        /// <summary>
        /// 轉換二進位
        /// </summary>
        /// <returns></returns>
        public string RunBinary(int num)
        {
            return Convert.ToString(num, 2);
        }

        /// <summary>
        /// 樂透陣列
        /// </summary>
        /// <returns></returns>
        public string RunLottoNumbers()
        {
            List<int> lotto = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                var lottoNum = random.Next(1, 100);
                if (!lotto.Contains(lottoNum))
                {
                    lotto.Add(lottoNum);
                }
                else
                {
                    i--;
                }
            }
            return string.Join(',', lotto.ToArray());
        }
    }
}
