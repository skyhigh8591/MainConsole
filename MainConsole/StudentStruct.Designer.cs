
namespace MainConsole
{
    partial class StudentStruct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowDave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelMaxMin = new System.Windows.Forms.Label();
            this.buttonMaxMin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學 : ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(123, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 34);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChinese.Location = new System.Drawing.Point(123, 112);
            this.textBoxChinese.MaxLength = 3;
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.Size = new System.Drawing.Size(188, 34);
            this.textBoxChinese.TabIndex = 5;
            this.textBoxChinese.TextChanged += new System.EventHandler(this.textBoxChinese_TextChanged);
            this.textBoxChinese.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChinese_KeyPress);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnglish.Location = new System.Drawing.Point(123, 170);
            this.textBoxEnglish.MaxLength = 3;
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(188, 34);
            this.textBoxEnglish.TabIndex = 6;
            this.textBoxEnglish.TextChanged += new System.EventHandler(this.textBoxEnglish_TextChanged);
            this.textBoxEnglish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnglish_KeyPress);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMath.Location = new System.Drawing.Point(123, 228);
            this.textBoxMath.MaxLength = 3;
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(188, 34);
            this.textBoxMath.TabIndex = 7;
            this.textBoxMath.TextChanged += new System.EventHandler(this.textBoxMath_TextChanged);
            this.textBoxMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMath_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(50, 312);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 43);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "儲存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowDave
            // 
            this.buttonShowDave.Location = new System.Drawing.Point(202, 312);
            this.buttonShowDave.Name = "buttonShowDave";
            this.buttonShowDave.Size = new System.Drawing.Size(93, 43);
            this.buttonShowDave.TabIndex = 9;
            this.buttonShowDave.Text = "顯示內容";
            this.buttonShowDave.UseVisualStyleBackColor = true;
            this.buttonShowDave.Click += new System.EventHandler(this.buttonShowDave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(419, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 332);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelMaxMin);
            this.splitContainer1.Size = new System.Drawing.Size(332, 330);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelShow
            // 
            this.labelShow.BackColor = System.Drawing.SystemColors.Control;
            this.labelShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelShow.Location = new System.Drawing.Point(0, 0);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(330, 186);
            this.labelShow.TabIndex = 1;
            // 
            // labelMaxMin
            // 
            this.labelMaxMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMaxMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxMin.Location = new System.Drawing.Point(0, 0);
            this.labelMaxMin.Name = "labelMaxMin";
            this.labelMaxMin.Size = new System.Drawing.Size(330, 136);
            this.labelMaxMin.TabIndex = 0;
            // 
            // buttonMaxMin
            // 
            this.buttonMaxMin.Location = new System.Drawing.Point(659, 381);
            this.buttonMaxMin.Name = "buttonMaxMin";
            this.buttonMaxMin.Size = new System.Drawing.Size(93, 43);
            this.buttonMaxMin.TabIndex = 11;
            this.buttonMaxMin.Text = "最大值最小值";
            this.buttonMaxMin.UseVisualStyleBackColor = true;
            this.buttonMaxMin.Click += new System.EventHandler(this.buttonMaxMin_Click);
            // 
            // StudentStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 457);
            this.Controls.Add(this.buttonMaxMin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonShowDave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.textBoxChinese);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentStruct";
            this.Text = "StudentStruct";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowDave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelMaxMin;
        private System.Windows.Forms.Button buttonMaxMin;
    }
}