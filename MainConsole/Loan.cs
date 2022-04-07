using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole
{
    public partial class Loan : Form
    {
        private float DownPayment;
        private float LoanAmount;
        private float BoxInterestRate;
        private float Deadline;
        public Loan()
        {
            InitializeComponent();
        }

        private void buttonStaging_Click(object sender, EventArgs e)
        {
            DownPayment = Convert.ToInt32(textBoxDownPayment.Text);
            LoanAmount = Convert.ToInt32(textBoxLoanAmount.Text);
            BoxInterestRate = float.Parse(textBoxInterestRate.Text) / 100f;
            Deadline = Convert.ToInt32(textBoxDeadline.Text) * 12;

            double staging = (LoanAmount - DownPayment) * (1 + BoxInterestRate) / Deadline;
            MessageBox.Show("每月應付金額 : " + Convert.ToInt32(staging));
        }

        private void buttonPayOff_Click(object sender, EventArgs e)
        {

            DownPayment = Convert.ToInt32(textBoxDownPayment.Text);
            LoanAmount = Convert.ToInt32(textBoxLoanAmount.Text);
            BoxInterestRate = float.Parse(textBoxInterestRate.Text) / 100f;
            Deadline = Convert.ToInt32(textBoxDeadline.Text) * 12;

            double payOff = (LoanAmount - DownPayment) * (1 + BoxInterestRate);
         
            MessageBox.Show("總應付金額 : " + Convert.ToInt32(payOff));
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {


            Dictionary<string, int> data = new Dictionary<string, int>();

            data.Add("textBoxDownPayment", Convert.ToInt32(textBoxDownPayment.Text));
            data.Add("textBoxLoanAmount", Convert.ToInt32(textBoxLoanAmount.Text));
            data.Add("textBoxInterestRate", Convert.ToInt32(textBoxInterestRate.Text));
            data.Add("textBoxDeadline", Convert.ToInt32(textBoxDeadline.Text));

            LoanReport loanReport = new LoanReport(data);
            loanReport.Show();
        }
    }
}
