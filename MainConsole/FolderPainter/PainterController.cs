using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderPainter
{
    class PainterController
    {
        private static PainterController instance;

        PainterController()
        {

        }

        public static PainterController Instance()
        {
            if (instance == null)
            {
                instance = new PainterController();
            }
            return instance;
        }
    }
}
