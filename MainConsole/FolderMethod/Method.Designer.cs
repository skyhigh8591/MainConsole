
namespace MainConsole.FolderMethod
{
    partial class Method
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
            this.buttonSelectNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonArraySelectNumber = new System.Windows.Forms.Button();
            this.buttonArrayStrMax = new System.Windows.Forms.Button();
            this.buttonArrayMaxMin = new System.Windows.Forms.Button();
            this.buttonArraySelectStr = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonTwoArrayExchange = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonTwoArrayOutTwo = new System.Windows.Forms.Button();
            this.buttonTwoArrayOutZero = new System.Windows.Forms.Button();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectNumber
            // 
            this.buttonSelectNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectNumber.Location = new System.Drawing.Point(12, 57);
            this.buttonSelectNumber.Name = "buttonSelectNumber";
            this.buttonSelectNumber.Size = new System.Drawing.Size(152, 38);
            this.buttonSelectNumber.TabIndex = 0;
            this.buttonSelectNumber.Text = "輸入為奇數或偶數?";
            this.buttonSelectNumber.UseVisualStyleBackColor = true;
            this.buttonSelectNumber.Click += new System.EventHandler(this.buttonSelectNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(511, 460);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 50);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "清除結果欄";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumber.Location = new System.Drawing.Point(94, 23);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(136, 28);
            this.textBoxNumber.TabIndex = 5;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // buttonArraySelectNumber
            // 
            this.buttonArraySelectNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArraySelectNumber.Location = new System.Drawing.Point(12, 137);
            this.buttonArraySelectNumber.Name = "buttonArraySelectNumber";
            this.buttonArraySelectNumber.Size = new System.Drawing.Size(290, 38);
            this.buttonArraySelectNumber.TabIndex = 6;
            this.buttonArraySelectNumber.Text = "陣列 統計奇數與偶數 數量";
            this.buttonArraySelectNumber.UseVisualStyleBackColor = true;
            this.buttonArraySelectNumber.Click += new System.EventHandler(this.buttonArraySelectNumber_Click);
            // 
            // buttonArrayStrMax
            // 
            this.buttonArrayStrMax.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArrayStrMax.Location = new System.Drawing.Point(12, 245);
            this.buttonArrayStrMax.Name = "buttonArrayStrMax";
            this.buttonArrayStrMax.Size = new System.Drawing.Size(290, 38);
            this.buttonArrayStrMax.TabIndex = 7;
            this.buttonArrayStrMax.Text = "陣列 最長的字串";
            this.buttonArrayStrMax.UseVisualStyleBackColor = true;
            this.buttonArrayStrMax.Click += new System.EventHandler(this.buttonArrayStrMax_Click);
            // 
            // buttonArrayMaxMin
            // 
            this.buttonArrayMaxMin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArrayMaxMin.Location = new System.Drawing.Point(12, 353);
            this.buttonArrayMaxMin.Name = "buttonArrayMaxMin";
            this.buttonArrayMaxMin.Size = new System.Drawing.Size(290, 38);
            this.buttonArrayMaxMin.TabIndex = 8;
            this.buttonArrayMaxMin.Text = "陣列最大值 與 最小值";
            this.buttonArrayMaxMin.UseVisualStyleBackColor = true;
            this.buttonArrayMaxMin.Click += new System.EventHandler(this.buttonArrayMaxMin_Click);
            // 
            // buttonArraySelectStr
            // 
            this.buttonArraySelectStr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArraySelectStr.Location = new System.Drawing.Point(12, 461);
            this.buttonArraySelectStr.Name = "buttonArraySelectStr";
            this.buttonArraySelectStr.Size = new System.Drawing.Size(290, 38);
            this.buttonArraySelectStr.TabIndex = 9;
            this.buttonArraySelectStr.Text = "陣列 幾個字串包含 \"C\" or \"c\"";
            this.buttonArraySelectStr.UseVisualStyleBackColor = true;
            this.buttonArraySelectStr.Click += new System.EventHandler(this.buttonArraySelectStr_Click);
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Location = new System.Drawing.Point(606, 326);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(391, 184);
            this.panelResult.TabIndex = 10;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(0, 0);
            this.labelResult.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(41, 20);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "結果";
            // 
            // buttonSwap
            // 
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSwap.Location = new System.Drawing.Point(688, 18);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(290, 38);
            this.buttonSwap.TabIndex = 12;
            this.buttonSwap.Text = "Swap[int,int]";
            this.buttonSwap.UseVisualStyleBackColor = true;
            // 
            // buttonTwoArrayExchange
            // 
            this.buttonTwoArrayExchange.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTwoArrayExchange.Location = new System.Drawing.Point(345, 223);
            this.buttonTwoArrayExchange.Name = "buttonTwoArrayExchange";
            this.buttonTwoArrayExchange.Size = new System.Drawing.Size(283, 82);
            this.buttonTwoArrayExchange.TabIndex = 13;
            this.buttonTwoArrayExchange.Text = "二維陣列[5,10] \r\n1與0穿插\r\n1010101010\r\n0101010101\r\n";
            this.buttonTwoArrayExchange.UseVisualStyleBackColor = true;
            this.buttonTwoArrayExchange.Click += new System.EventHandler(this.buttonTwoArrayExchange_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMax.Location = new System.Drawing.Point(688, 184);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(290, 38);
            this.buttonMax.TabIndex = 15;
            this.buttonMax.Text = "Max陣列";
            this.buttonMax.UseVisualStyleBackColor = true;
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSum.Location = new System.Drawing.Point(688, 101);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(290, 38);
            this.buttonSum.TabIndex = 16;
            this.buttonSum.Text = "Sum陣列";
            this.buttonSum.UseVisualStyleBackColor = true;
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMin.Location = new System.Drawing.Point(688, 267);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(290, 38);
            this.buttonMin.TabIndex = 17;
            this.buttonMin.Text = "Min陣列";
            this.buttonMin.UseVisualStyleBackColor = true;
            // 
            // buttonTwoArrayOutTwo
            // 
            this.buttonTwoArrayOutTwo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTwoArrayOutTwo.Location = new System.Drawing.Point(345, 124);
            this.buttonTwoArrayOutTwo.Name = "buttonTwoArrayOutTwo";
            this.buttonTwoArrayOutTwo.Size = new System.Drawing.Size(283, 82);
            this.buttonTwoArrayOutTwo.TabIndex = 18;
            this.buttonTwoArrayOutTwo.Text = "二維陣列[5,10] 外0 內1";
            this.buttonTwoArrayOutTwo.UseVisualStyleBackColor = true;
            this.buttonTwoArrayOutTwo.Click += new System.EventHandler(this.buttonTwoArrayOutTwo_Click);
            // 
            // buttonTwoArrayOutZero
            // 
            this.buttonTwoArrayOutZero.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTwoArrayOutZero.Location = new System.Drawing.Point(345, 18);
            this.buttonTwoArrayOutZero.Name = "buttonTwoArrayOutZero";
            this.buttonTwoArrayOutZero.Size = new System.Drawing.Size(283, 82);
            this.buttonTwoArrayOutZero.TabIndex = 19;
            this.buttonTwoArrayOutZero.Text = "二維陣列[5,10] 外1 內0";
            this.buttonTwoArrayOutZero.UseVisualStyleBackColor = true;
            this.buttonTwoArrayOutZero.Click += new System.EventHandler(this.buttonTwoArrayOutZero_Click);
            // 
            // Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.buttonTwoArrayOutZero);
            this.Controls.Add(this.buttonTwoArrayOutTwo);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonTwoArrayExchange);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.buttonArraySelectStr);
            this.Controls.Add(this.buttonArrayMaxMin);
            this.Controls.Add(this.buttonArrayStrMax);
            this.Controls.Add(this.buttonArraySelectNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectNumber);
            this.Name = "Method";
            this.Text = "Method";
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonArraySelectNumber;
        private System.Windows.Forms.Button buttonArrayStrMax;
        private System.Windows.Forms.Button buttonArrayMaxMin;
        private System.Windows.Forms.Button buttonArraySelectStr;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonTwoArrayExchange;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonTwoArrayOutTwo;
        private System.Windows.Forms.Button buttonTwoArrayOutZero;
    }
}