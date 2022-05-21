using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderXoGame
{
    class XoGameData
    {
        private static XoGameData instance;

        XoGameData()
        {

        }

        public static XoGameData Instance()
        {
            if (instance == null)
            {
                instance = new XoGameData();
            }
            return instance;
        }

        //連線成功的組合
        private int[,] winGroup = new int[8, 3]
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };
       
        public int[,] WinGroup { get => winGroup; set => winGroup = value; }
    }
}
