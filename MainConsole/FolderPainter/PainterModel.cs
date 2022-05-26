using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderPainter
{
    class PainterModel
    {
        private static PainterModel instance;
        private int mouseX = 0;
        private int mouseY = 0;

        PainterModel()
        {

        }

        public int MouseX { get => mouseX; set => mouseX = value; }
        public int MouseY { get => mouseY; set => mouseY = value; }

        public static PainterModel Instance()
        {
            if (instance == null)
            {
                instance = new PainterModel();
            }
            return instance;
        }
    }
}
