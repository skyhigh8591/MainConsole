using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            comboBoxGender.SelectedIndex = 0;
            comboBoxConstellation.SelectedIndex = 0;
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string text = "Hello 我是 " + textBoxName.Text + "\n" +
                "英文名子是 " + textBoxEnglishName.Text + "\n" +
                "性別是 " + comboBoxGender.Text + "\n" +
                "星座是 " + comboBoxConstellation.Text + "\n" +
                "很高興認識你";

            MessageBox.Show(text);

        }

        private void buttonHi_Click(object sender, EventArgs e)
        {
            string text = "HI 我是 " + textBoxName.Text + "\n" +
               "英文名子是 " + textBoxEnglishName.Text + "\n" +
               "性別是 " + comboBoxGender.Text + "\n" +
               "星座是 " + comboBoxConstellation.Text + "\n" +
               "很高興認識你";

            MessageBox.Show(text);
        }
    }
}
