using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderAlarm
{
    public partial class Alarm : Form
    {
        private AlarmController alarmController;

        public Alarm()
        {
            InitializeComponent();
            alarmController = AlarmController.Instance();
            labelTime.Text = alarmController.GetTime();
            dateTimePickerInput.Value = DateTime.ParseExact("000000", "HHmmss", null);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = alarmController.GetTime();

            if (checkBoxSetAlarm.Checked)
            {
                alarmController.CheckTime(
                    dateTimePickerInput.Value,
                     DateTime.ParseExact(
                         string.Join(
                             "",
                             labelTime.Text.Split(':')
                             ),
                         "HHmmss", null
                         )
                     );
            }
        }
    }
}
