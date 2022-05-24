using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderGuess
{
    class GuessController
    {
        private static GuessController instance;
        private GuessModel method;

        private GuessController()
        {
            method = GuessModel.Instance();
        }

        public static GuessController Instance()
        {
            if (instance == null)
            {
                instance = new GuessController();
            }
            return instance;
        }


        public void Random()
        {
            int number;
            var random = new Random();
            number = random.Next(1, 100);
            method.GuessNumber = number;
            method.GuessMax = 100;
            method.GuessMin = 0;

        }

        public string Guess(int checckNum)
        {
            if (checckNum > method.GuessNumber)
            {
                method.GuessMax = checckNum;
                return "請輸入大於" + method.GuessMin + "數字 ," + "小於" + method.GuessMax + "數字";
            }
            else if (checckNum < method.GuessNumber)
            {
                method.GuessMin = checckNum;
                return "請輸入大於" + method.GuessMin + "數字 ," + "小於" + method.GuessMax + "數字";
            }
            else
            {
                return "恭喜答對了 數字為" + method.GuessNumber;
            }
            
        }

        public bool CheckInputNum(int num)
        {
            if(num > method.GuessMax){

                MessageBox.Show("請輸入小於 " + method.GuessMax + " 數字");
                return false;
            }
            else if (num < method.GuessMin)
            {
                MessageBox.Show("請輸入大於 " + method.GuessMin + " 數字");
                return false;
            }
            else
            {
                return true;
            }
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


    }
}
