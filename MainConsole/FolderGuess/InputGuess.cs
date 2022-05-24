using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderGuess
{
    public partial class InputGuess : Form
    {
        public InputGuess()
        {
            InitializeComponent();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            GuessController.Instance().NotNumber(ref e);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("輸入不得為空");
            }
            else if (!GuessController.Instance().CheckInputNum(Int32.Parse(textBoxInput.Text)))
            {
                textBoxInput.Text = "";
            }
            else
            {
                labelInput.Text = GuessController.Instance().Guess(Int32.Parse(textBoxInput.Text));
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
