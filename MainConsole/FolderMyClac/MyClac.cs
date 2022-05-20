using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderMyClac
{
    public partial class MyClac : Form
    {
        public MyClac()
        {
            MyClacData.Instance();
            MyClacController.Instance();
            InitializeComponent();
            textBoxNumOne.Text = "0";
            textBoxNumTwo.Text = "0";

        }

        private void textBoxNumOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyClacController.Instance().NotNumber(ref e);
        }

        private void textBoxNumTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyClacController.Instance().NotNumber(ref e);
        }

        private void textBoxNumOne_TextChanged(object sender, EventArgs e)
        {
            MyClacData.Instance().NumOne = Int32.Parse(textBoxNumOne.Text);
        }

        private void textBoxNumTwo_TextChanged(object sender, EventArgs e)
        {
            MyClacData.Instance().NumTwo = Int32.Parse(textBoxNumTwo.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = MyClacController.Instance().Add().ToString();
        }

        private void buttonReduce_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = MyClacController.Instance().Reduce().ToString();
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = MyClacController.Instance().Take().ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = MyClacController.Instance().Remove().ToString();
        }
    }
}
