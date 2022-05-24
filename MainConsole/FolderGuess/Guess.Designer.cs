
namespace MainConsole.FolderGuess
{
    partial class Guess
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonShowAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(79, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(472, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Please Select A Number Between 1 to 100 !";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuess.Location = new System.Drawing.Point(112, 162);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(116, 63);
            this.buttonGuess.TabIndex = 1;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonShowAnswer
            // 
            this.buttonShowAnswer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShowAnswer.Location = new System.Drawing.Point(346, 162);
            this.buttonShowAnswer.Name = "buttonShowAnswer";
            this.buttonShowAnswer.Size = new System.Drawing.Size(162, 63);
            this.buttonShowAnswer.TabIndex = 2;
            this.buttonShowAnswer.Text = "Show Answer";
            this.buttonShowAnswer.UseVisualStyleBackColor = true;
            this.buttonShowAnswer.Click += new System.EventHandler(this.buttonShowAnswer_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 299);
            this.Controls.Add(this.buttonShowAnswer);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBox1);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonShowAnswer;
    }
}