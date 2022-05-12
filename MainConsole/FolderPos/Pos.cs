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
    public partial class Pos : Form
    {
        private int beerNum;
        private int beerPrice;

        private int tequilaNum;
        private int tequilaPice;

        private int wliskyNum;
        private int wliskyPice;

        private int wineNum;
        private int winePice;

        public Pos()
        {
            InitializeComponent();
            InitializeParameter();
        }

        private void ButtonBeer_Click(object sender, EventArgs e)
        {
            int price = 120;
            beerNum = beerNum + 1;
            beerPrice = beerPrice + price;
            RenewList();
        }

        private void ButtonTequila_Click(object sender, EventArgs e)
        {
            int price = 180;
            tequilaNum = tequilaNum + 1;
            tequilaPice = tequilaPice + price;
            RenewList();
        }

        private void ButtonWlisky_Click(object sender, EventArgs e)
        {
            int price = 350;
            wliskyNum = wliskyNum + 1;
            wliskyPice = wliskyPice + price;
            RenewList();
        }

        private void ButtonWine_Click(object sender, EventArgs e)
        {
            int price = 320;
            wineNum = wineNum + 1;
            winePice = winePice + price;
            RenewList();
        }

        private void RenewList()
        {
            textBoxTotalPrice.Text = "NT $ " + (beerPrice + tequilaPice + wliskyPice + winePice).ToString();

            if (listBoxShoppingList.Items.Count > 0)
            {
                listBoxShoppingList.Items.Clear();
            }

            if (beerNum != 0)
            {
                string pice = "啤酒 " + beerNum + " 瓶 " + " 費用 NT " + beerPrice;

                if (listBoxShoppingList.Items.Count < 1)
                {
                    listBoxShoppingList.Items.Add(pice);
                }
                else
                {
                    listBoxShoppingList.Items[0] = pice;
                }



            }

            if (tequilaNum != 0)
            {
                string pice = "龍舌蘭 " + tequilaNum + " 瓶 " + " 費用 NT " + tequilaPice;

                if (listBoxShoppingList.Items.Count < 2)
                {
                    listBoxShoppingList.Items.Add(pice);
                }
                else
                {
                    listBoxShoppingList.Items[2] = pice;
                }

            }

            if (wliskyNum != 0)
            {
                string pice = "威士忌 " + wliskyNum + " 瓶 " + " 費用 NT " + wliskyPice;

                if (listBoxShoppingList.Items.Count < 3)
                {
                    listBoxShoppingList.Items.Add(pice);
                }
                else
                {
                    listBoxShoppingList.Items[2] = pice;
                }
            }

            if (wineNum != 0)
            {
                string pice = "紅酒 " + wineNum + " 瓶 " + " 費用 NT " + winePice;

                if (listBoxShoppingList.Items.Count < 4)
                {
                    listBoxShoppingList.Items.Add(pice);
                }
                else
                {
                    listBoxShoppingList.Items[3] = pice;
                }
            }



        }

        private void InitializeParameter()
        {

            beerNum = 0;
            beerPrice = 0;

            tequilaNum = 0;
            tequilaPice = 0;

            wliskyNum = 0;
            wliskyPice = 0;

            wineNum = 0;
            winePice = 0;

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listBoxShoppingList.Items.Clear();
            InitializeParameter();
            RenewList();
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            int price = beerPrice + tequilaPice + wliskyPice + winePice;
            MessageBox.Show("現金付款金額為 = " + price ,"Pice", MessageBoxButtons.OK);
        }

        private void buttonCreditCard_Click(object sender, EventArgs e)
        {
            int price = beerPrice + tequilaPice + wliskyPice + winePice;
            MessageBox.Show("信用卡付款金額九折為 = " + price*0.9, "Pice", MessageBoxButtons.OK);
        }
    }
}
