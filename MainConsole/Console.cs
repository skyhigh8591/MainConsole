using MainConsole.FolderForDoWhile;
using MainConsole.FolderMethod;
using MainConsole.FolderMyClac;
using MainConsole.FolderXoGame;
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

        private void buttonPos_Click(object sender, EventArgs e)
        {
            Pos pos = new Pos();
            pos.Show();
        }

        private void buttonStudentStruct_Click(object sender, EventArgs e)
        {
            StudentStruct studentStruct = new StudentStruct();
            studentStruct.Show();
        }

        private void buttonStudentsGrade_Click(object sender, EventArgs e)
        {
            StudentsGrade studentsGrade = new StudentsGrade();
            studentsGrade.Show();
        }

        private void buttonStudentsGradeList_Click(object sender, EventArgs e)
        {
            StudentsGradeList studentsGradeList = new StudentsGradeList();
            studentsGradeList.Show();
        }

        private void buttonMethod_Click(object sender, EventArgs e)
        {
            Method method = new Method();
            method.Show();
        }

        private void buttonMyClac_Click(object sender, EventArgs e)
        {
            MyClac myClac = new MyClac();
            myClac.Show();
        }

        private void buttonForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile forDoWhile = new ForDoWhile();
            forDoWhile.Show();
        }

        private void buttonXoGame_Click(object sender, EventArgs e)
        {
            XoGame xoGame = new XoGame();
            xoGame.Show();
        }
    }
}
