
namespace MainConsole.FolderGuess
{
    partial class InputGuess
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInput.Location = new System.Drawing.Point(46, 52);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(221, 24);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Please input a number.";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(46, 104);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(256, 32);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(341, 36);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(90, 40);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(341, 96);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 40);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // InputGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 164);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Name = "InputGuess";
            this.Text = "InputGuess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonCancel;
    }
}