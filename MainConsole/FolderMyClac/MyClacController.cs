using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderMyClac
{
    class MyClacController
    {
        private static MyClacController instance;

        MyClacController()
        {
            
        }

        public static MyClacController Instance()
        {
            if (instance == null)
            {
                instance = new MyClacController();
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
        /// 加法
        /// </summary>
        /// <returns></returns>
        public int Add()
        {
           return MyClacModel.Instance().NumOne + MyClacModel.Instance().NumTwo;
        }

        /// <summary>
        /// 剪法
        /// </summary>
        /// <returns></returns>
        public int Reduce()
        {
            return MyClacModel.Instance().NumOne - MyClacModel.Instance().NumTwo;
        }

        /// <summary>
        /// 乘法
        /// </summary>
        /// <returns></returns>
        public double Take()
        {
            return Math.Round( 
                Convert.ToDouble(MyClacModel.Instance().NumOne) * MyClacModel.Instance().NumTwo,
                2
                );
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <returns></returns>
        public double Remove()
        {
            if(MyClacModel.Instance().NumTwo == 0)
            {
                return 0;
            }
            else
            {
                return Math.Round(
                Convert.ToDouble(MyClacModel.Instance().NumOne) / MyClacModel.Instance().NumTwo,
                2
                );
            }
        }

    }
}
