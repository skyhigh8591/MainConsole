using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderMyClac
{
    class MyClacData
    {

        private static MyClacData instance;

        MyClacData()
        {

        }

        public static MyClacData Instance()
        {
            if (instance == null)
            {
                instance = new MyClacData();
            }
            return instance;
        }

        int numOne = 0;
        int numTwo = 0;

        public int NumOne { get => numOne; set => numOne = value; }
        public int NumTwo { get => numTwo; set => numTwo = value; }
    }
}
