using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderAlarm
{
    class AlarmController
    {

        private static AlarmController instance;

        AlarmController()
        {

        }

        public static AlarmController Instance()
        {
            if (instance == null)
            {
                instance = new AlarmController();
            }
            return instance;
        }

        public string GetTime()
        {
            String TimeInString = "";
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            TimeInString = (hour < 10) ? "0" + hour.ToString() : hour.ToString();
            TimeInString += ":" + ((min < 10) ? "0" + min.ToString() : min.ToString());
            TimeInString += ":" + ((sec < 10) ? "0" + sec.ToString() : sec.ToString());

            return TimeInString;
        }

        public void CheckTime(DateTime now , DateTime setTime)
        {
            if(DateTime.Compare(now, setTime) == 0)
            {
                MessageBox.Show("鬧鐘響 現在時間 \r\n" + now.ToString("HH:mm:ss"));
            }
        }


    }
}
