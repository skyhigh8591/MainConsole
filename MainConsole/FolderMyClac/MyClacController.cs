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

        public void NotNumber(ref KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public int Add()
        {
           return MyClacData.Instance().NumOne + MyClacData.Instance().NumTwo;
        }

        public int Reduce()
        {
            return MyClacData.Instance().NumOne - MyClacData.Instance().NumTwo;
        }

        public double Take()
        {
            return Math.Round( 
                Convert.ToDouble(MyClacData.Instance().NumOne) * MyClacData.Instance().NumTwo,
                2
                );
        }

        public double Remove()
        {
            if(MyClacData.Instance().NumTwo == 0)
            {
                return 0;
            }
            else
            {
                return Math.Round(
                Convert.ToDouble(MyClacData.Instance().NumOne) / MyClacData.Instance().NumTwo,
                2
                );
            }
        }

    }
}
