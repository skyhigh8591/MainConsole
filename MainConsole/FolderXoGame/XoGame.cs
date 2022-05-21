using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderXoGame
{
    public partial class XoGame : Form
    {
        Button[] btnTControls = new Button[9];       //放置井字遊戲按鍵
        Boolean isGameOver = false;     //有連線成功則結束
        Boolean isO = true;     //點選是 O 還是 X
        private XoGameController xoGameController;
        private XoGameData xoGameData;

        public XoGame()
        {
            InitializeComponent();
            xoGameController = XoGameController.Instance();
            xoGameData = XoGameData.Instance();
            btnTControls = new Button[9] {
                buttonOne,
                buttonTwo,
                buttonThree,
                buttonFour,
                buttonFive,
                buttonSix,
                buttonSeven,
                buttonEight,
                buttonNine
            };
            xoGameController.InitButtons(ref btnTControls, ref isGameOver, ref isO);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            xoGameController.InitButtons(ref btnTControls, ref isGameOver, ref isO);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != "")
            {
                MessageBox.Show("這個按鍵已經選擇了，請點選其他位置！", "提示", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightGreen;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightYellow;
            }
            isO = !isO;

            bool[] GameStatus =xoGameController.CheckWinGroup(ref btnTControls);
            isGameOver = GameStatus[1];

            //有人獲勝
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show("遊戲結束....\r\n" + tmpButton.Text + " 獲勝\r\n是否重新開始遊戲", "遊戲結束", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    xoGameController.InitButtons(ref btnTControls, ref isGameOver, ref isO);
                return;
            }
            //和局
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("遊戲結束....\r\n和局\r\n是否重新開始遊戲", "遊戲結束", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    xoGameController.InitButtons(ref btnTControls, ref isGameOver, ref isO);
            }
        }

    }
}
