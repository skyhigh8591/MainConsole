
namespace MainConsole
{
    partial class Hello
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEnglishName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelConstellation = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEnglishName = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxConstellation = new System.Windows.Forms.TextBox();
            this.buttonHello = new System.Windows.Forms.Button();
            this.buttonHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(75, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 26);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            // 
            // labelEnglishName
            // 
            this.labelEnglishName.AutoSize = true;
            this.labelEnglishName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnglishName.Location = new System.Drawing.Point(75, 119);
            this.labelEnglishName.Name = "labelEnglishName";
            this.labelEnglishName.Size = new System.Drawing.Size(157, 26);
            this.labelEnglishName.TabIndex = 1;
            this.labelEnglishName.Text = "EnglishName : ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(75, 169);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(101, 26);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender : ";
            // 
            // labelConstellation
            // 
            this.labelConstellation.AutoSize = true;
            this.labelConstellation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConstellation.Location = new System.Drawing.Point(75, 219);
            this.labelConstellation.Name = "labelConstellation";
            this.labelConstellation.Size = new System.Drawing.Size(158, 26);
            this.labelConstellation.TabIndex = 3;
            this.labelConstellation.Text = "Constellation : ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(300, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 34);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxEnglishName
            // 
            this.textBoxEnglishName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnglishName.Location = new System.Drawing.Point(300, 116);
            this.textBoxEnglishName.Name = "textBoxEnglishName";
            this.textBoxEnglishName.Size = new System.Drawing.Size(304, 34);
            this.textBoxEnglishName.TabIndex = 5;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGender.Location = new System.Drawing.Point(300, 166);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(304, 34);
            this.textBoxGender.TabIndex = 6;
            // 
            // textBoxConstellation
            // 
            this.textBoxConstellation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConstellation.Location = new System.Drawing.Point(300, 216);
            this.textBoxConstellation.Name = "textBoxConstellation";
            this.textBoxConstellation.Size = new System.Drawing.Size(304, 34);
            this.textBoxConstellation.TabIndex = 7;
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(109, 317);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(144, 42);
            this.buttonHello.TabIndex = 8;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonHi
            // 
            this.buttonHi.Location = new System.Drawing.Point(380, 317);
            this.buttonHi.Name = "buttonHi";
            this.buttonHi.Size = new System.Drawing.Size(144, 42);
            this.buttonHi.TabIndex = 9;
            this.buttonHi.Text = "Hi";
            this.buttonHi.UseVisualStyleBackColor = true;
            this.buttonHi.Click += new System.EventHandler(this.buttonHi_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHi);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.textBoxConstellation);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxEnglishName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelConstellation);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEnglishName);
            this.Controls.Add(this.labelName);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEnglishName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelConstellation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEnglishName;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxConstellation;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button buttonHi;
    }
}