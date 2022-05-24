using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderMyClac
{
    class MyClacModel
    {

        private static MyClacModel instance;

        MyClacModel()
        {

        }

        public static MyClacModel Instance()
        {
            if (instance == null)
            {
                instance = new MyClacModel();
            }
            return instance;
        }

        int numOne = 0;
        int numTwo = 0;

        public int NumOne { get => numOne; set => numOne = value; }
        public int NumTwo { get => numTwo; set => numTwo = value; }
    }
}
