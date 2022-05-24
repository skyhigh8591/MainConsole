using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderAlarm
{
    class AlarmModel
    {
        private static AlarmModel instance;

        AlarmModel()
        {

        }

        public static AlarmModel Instance()
        {
            if (instance == null)
            {
                instance = new AlarmModel();
            }
            return instance;
        }


    }
}
