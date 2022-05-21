using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderForDoWhile
{
    class ForDoWhileData
    {
        private static ForDoWhileData instance;

        ForDoWhileData()
        {

        }

        public static ForDoWhileData Instance()
        {
            if (instance == null)
            {
                instance = new ForDoWhileData();
            }
            return instance;
        }

        private int from = 0;
        private int to = 0;
        private int step = 0;
        private int rows = 0;

        public int From { get => from; set => from = value; }
        public int To { get => to; set => to = value; }
        public int Step { get => step; set => step = value; }
        public int Rows { get => rows; set => rows = value; }
    }
}
