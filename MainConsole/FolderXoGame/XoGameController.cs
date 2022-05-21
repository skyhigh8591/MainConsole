using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderXoGame
{
    class XoGameController
    {
        private XoGameData xoGameData;
        private static XoGameController instance;

        XoGameController()
        {
            xoGameData = XoGameData.Instance();
        }

        public static XoGameController Instance()
        {
            if (instance == null)
            {
                instance = new XoGameController();
            }
            return instance;
        }

        public void InitButtons(ref Button[] button, ref bool isGameOver, ref bool isO)
        {
            isGameOver = false;
            isO = true;
            for (int i = 0; i < button.Length; i++)
            {
                button[i].Text = "";
                button[i].BackColor = Color.White;
                button[i].Font = new System.Drawing.Font(
                    "Arial",
                    30
                    , System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Pixel,
                    ((System.Byte)1)
                    );
            }
        }

        //檢查是否OX連線成功
        public bool[] CheckWinGroup(ref Button[] myControls)
        {
            //gameWinOver {是否有人獲勝, 是否遊戲結束(或是平局)}
            bool[] gameWinOver = new bool[2] { false, false };
            int btnIsUse = 1;
            for (int i = 0; i < 8; i++)
            {
                int a = xoGameData.WinGroup[i, 0];
                int b = xoGameData.WinGroup[i, 1];
                int c = xoGameData.WinGroup[i, 2];
                Button b1 = myControls[a];
                Button b2 = myControls[b];
                Button b3 = myControls[c];

                //沒有連線就繼續
                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                //連線成功，遊戲結束
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.LightCoral;
                    b1.Font = b2.Font = b3.Font = new System.Drawing.Font(
                        "Times New Roman",
                        35,
                        System.Drawing.FontStyle.Italic & System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Pixel,
                        ((System.Byte)1)
                        );
                    gameWinOver = new bool[2] { true, true };
                    break;
                }

                //九格填完，顯示結束
                if (myControls[i].Text != "")
                {
                    btnIsUse++;
                    if (btnIsUse == 9)
                        gameWinOver[1] = true;
                }
            }
            return gameWinOver;
        }

    }
}
