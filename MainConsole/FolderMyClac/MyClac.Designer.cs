
namespace MainConsole.FolderMyClac
{
    partial class MyClac
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
            this.textBoxNumOne = new System.Windows.Forms.TextBox();
            this.textBoxNumTwo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.buttonReduce = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2";
            // 
            // textBoxNumOne
            // 
            this.textBoxNumOne.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumOne.Location = new System.Drawing.Point(145, 83);
            this.textBoxNumOne.Name = "textBoxNumOne";
            this.textBoxNumOne.Size = new System.Drawing.Size(100, 32);
            this.textBoxNumOne.TabIndex = 2;
            this.textBoxNumOne.TextChanged += new System.EventHandler(this.textBoxNumOne_TextChanged);
            this.textBoxNumOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumOne_KeyPress);
            // 
            // textBoxNumTwo
            // 
            this.textBoxNumTwo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumTwo.Location = new System.Drawing.Point(145, 130);
            this.textBoxNumTwo.Name = "textBoxNumTwo";
            this.textBoxNumTwo.Size = new System.Drawing.Size(100, 32);
            this.textBoxNumTwo.TabIndex = 3;
            this.textBoxNumTwo.TextChanged += new System.EventHandler(this.textBoxNumTwo_TextChanged);
            this.textBoxNumTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumTwo_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(284, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 47);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(364, 50);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(60, 47);
            this.buttonTake.TabIndex = 5;
            this.buttonTake.Text = "x";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // buttonReduce
            // 
            this.buttonReduce.Location = new System.Drawing.Point(284, 115);
            this.buttonReduce.Name = "buttonReduce";
            this.buttonReduce.Size = new System.Drawing.Size(60, 47);
            this.buttonReduce.TabIndex = 6;
            this.buttonReduce.Text = "-";
            this.buttonReduce.UseVisualStyleBackColor = true;
            this.buttonReduce.Click += new System.EventHandler(this.buttonReduce_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(364, 115);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(60, 47);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "/";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 2);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 2);
            this.label4.TabIndex = 9;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(145, 198);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 32);
            this.textBoxResult.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(73, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result";
            // 
            // MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 301);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonReduce);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNumTwo);
            this.Controls.Add(this.textBoxNumOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyClac";
            this.Text = "MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumOne;
        private System.Windows.Forms.TextBox textBoxNumTwo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Button buttonReduce;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label5;
    }
}