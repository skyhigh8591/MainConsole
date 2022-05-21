using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderForDoWhile
{
    public partial class ForDoWhile : Form
    {

        private ForDoWhileData forDoWhileData;
        private ForDoWhileController forDoWhileController;
        public ForDoWhile()
        {
            InitializeComponent();
            forDoWhileController = ForDoWhileController.Instance();
            forDoWhileData = ForDoWhileData.Instance();
            textBoxFrom.Text = "0";
            textBoxTo.Text = "0";
            textBoxStep.Text = "0";
            textBoxRows.Text = "0";
        }

        private void textBoxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            forDoWhileController.NotNumber(ref e);
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            forDoWhileController.NotNumber(ref e);
        }

        private void textBoxStep_KeyPress(object sender, KeyPressEventArgs e)
        {
            forDoWhileController.NotNumber(ref e);
        }

        private void textBoxRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            forDoWhileController.NotNumber(ref e);
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            if (forDoWhileController.NotText(ref textBoxFrom))
            {
                return;
            }
            forDoWhileData.From = Int32.Parse(textBoxFrom.Text);
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            if (forDoWhileController.NotText(ref textBoxTo))
            {
                return;
            }
            forDoWhileData.To = Int32.Parse(textBoxTo.Text);
        }

        private void textBoxStep_TextChanged(object sender, EventArgs e)
        {
            if (forDoWhileController.NotText(ref textBoxStep))
            {
                return;
            }
            forDoWhileData.Step = Int32.Parse(textBoxStep.Text);
        }

        private void textBoxRows_TextChanged(object sender, EventArgs e)
        {
            if (forDoWhileController.NotText(ref textBoxRows))
            {
                return;
            }
            forDoWhileData.Rows = Int32.Parse(textBoxRows.Text);
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = 
                "RunFor\n" +
                "From : " +forDoWhileData.From +
                " To : " + forDoWhileData.To +
                "\nSum : " + forDoWhileController.RunFor();
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = 
                "RunWhile\n" +
                "From : " + forDoWhileData.From +
                " To : " + forDoWhileData.To +
                "\nSum : " + forDoWhileController.RunWhile();
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = 
                "RunDoWhile\n" +
                "From : " + forDoWhileData.From +
                " To : " + forDoWhileData.To +
                "\nSum : " + forDoWhileController.RunDoWhile();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = forDoWhileController.RunTriangle();
        }

        private void buttonMultiplicationTable_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = forDoWhileController.RunMultiplication();
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = forDoWhileController.RunBinary(100);
        }

        private void buttonLottoNumbers_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = forDoWhileController.RunLottoNumbers();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "結果";
        }
    }
}
