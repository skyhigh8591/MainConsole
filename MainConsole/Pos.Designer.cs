
namespace MainConsole
{
    partial class Pos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBeer = new System.Windows.Forms.Button();
            this.buttonWine = new System.Windows.Forms.Button();
            this.buttonWlisky = new System.Windows.Forms.Button();
            this.buttonTequila = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCreditCard = new System.Windows.Forms.Button();
            this.buttonCash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxShoppingList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBeer
            // 
            this.buttonBeer.Location = new System.Drawing.Point(22, 21);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(84, 68);
            this.buttonBeer.TabIndex = 0;
            this.buttonBeer.Text = "啤酒  \r\nNT$120";
            this.buttonBeer.UseVisualStyleBackColor = true;
            this.buttonBeer.Click += new System.EventHandler(this.ButtonBeer_Click);
            // 
            // buttonWine
            // 
            this.buttonWine.Location = new System.Drawing.Point(131, 122);
            this.buttonWine.Name = "buttonWine";
            this.buttonWine.Size = new System.Drawing.Size(84, 68);
            this.buttonWine.TabIndex = 1;
            this.buttonWine.Text = "紅酒\r\nNT$320";
            this.buttonWine.UseVisualStyleBackColor = true;
            this.buttonWine.Click += new System.EventHandler(this.ButtonWine_Click);
            // 
            // buttonWlisky
            // 
            this.buttonWlisky.Location = new System.Drawing.Point(15, 122);
            this.buttonWlisky.Name = "buttonWlisky";
            this.buttonWlisky.Size = new System.Drawing.Size(84, 68);
            this.buttonWlisky.TabIndex = 2;
            this.buttonWlisky.Text = "威士忌\r\nNT$350";
            this.buttonWlisky.UseVisualStyleBackColor = true;
            this.buttonWlisky.Click += new System.EventHandler(this.ButtonWlisky_Click);
            // 
            // buttonTequila
            // 
            this.buttonTequila.Location = new System.Drawing.Point(131, 21);
            this.buttonTequila.Name = "buttonTequila";
            this.buttonTequila.Size = new System.Drawing.Size(84, 68);
            this.buttonTequila.TabIndex = 3;
            this.buttonTequila.Text = "龍舌蘭\r\nNT$180";
            this.buttonTequila.UseVisualStyleBackColor = true;
            this.buttonTequila.Click += new System.EventHandler(this.ButtonTequila_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonWlisky);
            this.panel1.Controls.Add(this.buttonTequila);
            this.panel1.Controls.Add(this.buttonBeer);
            this.panel1.Controls.Add(this.buttonWine);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(38, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 215);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(300, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 314);
            this.panel2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTotalPrice);
            this.splitContainer1.Panel1.Controls.Add(this.labelTotalPrice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreditCard);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCash);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(323, 312);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTotalPrice.Location = new System.Drawing.Point(37, 56);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(244, 32);
            this.textBoxTotalPrice.TabIndex = 1;
            this.textBoxTotalPrice.Text = "NT $0";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(15, 15);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(57, 20);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "總金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "付款方式";
            // 
            // buttonCreditCard
            // 
            this.buttonCreditCard.Location = new System.Drawing.Point(183, 71);
            this.buttonCreditCard.Name = "buttonCreditCard";
            this.buttonCreditCard.Size = new System.Drawing.Size(98, 49);
            this.buttonCreditCard.TabIndex = 3;
            this.buttonCreditCard.Text = "信用卡";
            this.buttonCreditCard.UseVisualStyleBackColor = true;
            this.buttonCreditCard.Click += new System.EventHandler(this.buttonCreditCard_Click);
            // 
            // buttonCash
            // 
            this.buttonCash.Location = new System.Drawing.Point(25, 71);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(98, 49);
            this.buttonCash.TabIndex = 2;
            this.buttonCash.Text = "現金";
            this.buttonCash.UseVisualStyleBackColor = true;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(183, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "信用卡享九折";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonClear);
            this.panel3.Controls.Add(this.listBoxShoppingList);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(661, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 505);
            this.panel3.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(313, 457);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "清除清單";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // listBoxShoppingList
            // 
            this.listBoxShoppingList.FormattingEnabled = true;
            this.listBoxShoppingList.ItemHeight = 15;
            this.listBoxShoppingList.Items.AddRange(new object[] {
            "尚未購物",
            " ",
            " ",
            "  "});
            this.listBoxShoppingList.Location = new System.Drawing.Point(33, 69);
            this.listBoxShoppingList.Name = "listBoxShoppingList";
            this.listBoxShoppingList.Size = new System.Drawing.Size(342, 364);
            this.listBoxShoppingList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物清單";
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 586);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pos";
            this.Text = "Pos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.Button buttonWine;
        private System.Windows.Forms.Button buttonWlisky;
        private System.Windows.Forms.Button buttonTequila;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCreditCard;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxShoppingList;
        private System.Windows.Forms.Button buttonClear;
    }
}