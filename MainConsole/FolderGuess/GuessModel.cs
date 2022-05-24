using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderGuess
{
    class GuessModel
    {

        private static GuessModel instance;
        private int guessNumber;
        private int guessMax;
        private int guessMin;
        GuessModel()
        {

        }

        public int GuessNumber { get => guessNumber; set => guessNumber = value; }
        public int GuessMax { get => guessMax; set => guessMax = value; }
        public int GuessMin { get => guessMin; set => guessMin = value; }

        public static GuessModel Instance()
        {
            if (instance == null)
            {
                instance = new GuessModel();
            }
            return instance;
        }

    }
}
