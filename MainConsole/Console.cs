﻿using System;
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
    public partial class Console : Form
    {
        public Console()
        {
            InitializeComponent();
        }

        private void button_Hello_Click(object sender, EventArgs e)
        {

            Hello hello = new Hello();
            hello.Show();

        }

        private void buttonLoan_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.Show();
        }
    }
}
