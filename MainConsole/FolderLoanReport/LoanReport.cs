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
    public partial class LoanReport : Form
    {

        private Dictionary<string, int> data;
        public LoanReport()
        {
            InitializeComponent();
        }

        public LoanReport(Dictionary<string, int> _data)
        {
            InitializeComponent();
            data = _data;

            
            textBoxDownPayment.Text = data["textBoxDownPayment"].ToString();
            textBoxLoanAmount.Text = data["textBoxLoanAmount"].ToString();
            textBoxInterestRate.Text = data["textBoxInterestRate"].ToString();
            textBoxDeadline.Text = data["textBoxDeadline"].ToString();

        }

    }
}
