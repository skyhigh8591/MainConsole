
namespace MainConsole
{
    partial class LoanReport
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
            System.Windows.Forms.Label labelLoanAmount;
            this.textBoxDownPayment = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.textBoxDeadline = new System.Windows.Forms.TextBox();
            this.textBoxLoanAmount = new System.Windows.Forms.TextBox();
            this.labelDownPayment = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.buttonEmail = new System.Windows.Forms.Button();
            labelLoanAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            labelLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoanAmount.Location = new System.Drawing.Point(62, 70);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new System.Drawing.Size(169, 41);
            labelLoanAmount.TabIndex = 8;
            labelLoanAmount.Text = "貸款金額 : ";
            // 
            // textBoxDownPayment
            // 
            this.textBoxDownPayment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDownPayment.Location = new System.Drawing.Point(273, 276);
            this.textBoxDownPayment.Name = "textBoxDownPayment";
            this.textBoxDownPayment.ReadOnly = true;
            this.textBoxDownPayment.Size = new System.Drawing.Size(301, 48);
            this.textBoxDownPayment.TabIndex = 15;
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInterestRate.Location = new System.Drawing.Point(273, 205);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.ReadOnly = true;
            this.textBoxInterestRate.Size = new System.Drawing.Size(301, 48);
            this.textBoxInterestRate.TabIndex = 14;
            // 
            // textBoxDeadline
            // 
            this.textBoxDeadline.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDeadline.Location = new System.Drawing.Point(273, 134);
            this.textBoxDeadline.Name = "textBoxDeadline";
            this.textBoxDeadline.ReadOnly = true;
            this.textBoxDeadline.Size = new System.Drawing.Size(301, 48);
            this.textBoxDeadline.TabIndex = 13;
            // 
            // textBoxLoanAmount
            // 
            this.textBoxLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoanAmount.Location = new System.Drawing.Point(273, 63);
            this.textBoxLoanAmount.Name = "textBoxLoanAmount";
            this.textBoxLoanAmount.ReadOnly = true;
            this.textBoxLoanAmount.Size = new System.Drawing.Size(301, 48);
            this.textBoxLoanAmount.TabIndex = 12;
            // 
            // labelDownPayment
            // 
            this.labelDownPayment.AutoSize = true;
            this.labelDownPayment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDownPayment.Location = new System.Drawing.Point(62, 280);
            this.labelDownPayment.Name = "labelDownPayment";
            this.labelDownPayment.Size = new System.Drawing.Size(114, 41);
            this.labelDownPayment.TabIndex = 11;
            this.labelDownPayment.Text = "頭期款";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInterestRate.Location = new System.Drawing.Point(62, 210);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(130, 41);
            this.labelInterestRate.TabIndex = 10;
            this.labelInterestRate.Text = "利率(%)";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadline.Location = new System.Drawing.Point(62, 140);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(134, 41);
            this.labelDeadline.TabIndex = 9;
            this.labelDeadline.Text = "期限(年)";
            // 
            // buttonEmail
            // 
            this.buttonEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEmail.Location = new System.Drawing.Point(635, 377);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(153, 61);
            this.buttonEmail.TabIndex = 16;
            this.buttonEmail.Text = "Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            // 
            // LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.textBoxDownPayment);
            this.Controls.Add(this.textBoxInterestRate);
            this.Controls.Add(this.textBoxDeadline);
            this.Controls.Add(this.textBoxLoanAmount);
            this.Controls.Add(this.labelDownPayment);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(labelLoanAmount);
            this.Name = "LoanReport";
            this.Text = "LoanReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDownPayment;
        private System.Windows.Forms.TextBox textBoxInterestRate;
        private System.Windows.Forms.TextBox textBoxDeadline;
        private System.Windows.Forms.TextBox textBoxLoanAmount;
        private System.Windows.Forms.Label labelDownPayment;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Button buttonEmail;
    }
}