using MainConsole.FolderForDoWhile;
using MainConsole.FolderMethod;
using MainConsole.FolderMyClac;
using MainConsole.FolderNotepad;
using MainConsole.FolderScreenSaver;
using MainConsole.FolderXoGame;
using MainConsole.FolderPictureViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainConsole.FolderGuess;
using MainConsole.FolderAlarm;
using MainConsole.FolderPainter;

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

        private void buttonScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver scereenSacer = new ScreenSaver();
            scereenSacer.Show();
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        private void buttonPictureViewer_Click(object sender, EventArgs e)
        {
            PictureViewer pictureViewer = new PictureViewer();
            pictureViewer.Show();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.Show();
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            alarm.Show();
        }

        private void buttonPainter_Click(object sender, EventArgs e)
        {
            Painter painter = new Painter();
            painter.Show();
        }
    }
}
