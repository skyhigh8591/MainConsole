
namespace MainConsole
{
    partial class Loan
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
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelDownPayment = new System.Windows.Forms.Label();
            this.textBoxLoanAmount = new System.Windows.Forms.TextBox();
            this.textBoxDeadline = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.textBoxDownPayment = new System.Windows.Forms.TextBox();
            this.buttonStaging = new System.Windows.Forms.Button();
            this.buttonPayOff = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            labelLoanAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            labelLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoanAmount.Location = new System.Drawing.Point(84, 71);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new System.Drawing.Size(169, 41);
            labelLoanAmount.TabIndex = 0;
            labelLoanAmount.Text = "貸款金額 : ";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadline.Location = new System.Drawing.Point(84, 141);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(134, 41);
            this.labelDeadline.TabIndex = 1;
            this.labelDeadline.Text = "期限(年)";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInterestRate.Location = new System.Drawing.Point(84, 211);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(130, 41);
            this.labelInterestRate.TabIndex = 2;
            this.labelInterestRate.Text = "利率(%)";
            // 
            // labelDownPayment
            // 
            this.labelDownPayment.AutoSize = true;
            this.labelDownPayment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDownPayment.Location = new System.Drawing.Point(84, 281);
            this.labelDownPayment.Name = "labelDownPayment";
            this.labelDownPayment.Size = new System.Drawing.Size(114, 41);
            this.labelDownPayment.TabIndex = 3;
            this.labelDownPayment.Text = "頭期款";
            // 
            // textBoxLoanAmount
            // 
            this.textBoxLoanAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoanAmount.Location = new System.Drawing.Point(295, 64);
            this.textBoxLoanAmount.Name = "textBoxLoanAmount";
            this.textBoxLoanAmount.Size = new System.Drawing.Size(301, 48);
            this.textBoxLoanAmount.TabIndex = 4;
            // 
            // textBoxDeadline
            // 
            this.textBoxDeadline.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDeadline.Location = new System.Drawing.Point(295, 135);
            this.textBoxDeadline.Name = "textBoxDeadline";
            this.textBoxDeadline.Size = new System.Drawing.Size(301, 48);
            this.textBoxDeadline.TabIndex = 5;
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInterestRate.Location = new System.Drawing.Point(295, 206);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.Size = new System.Drawing.Size(301, 48);
            this.textBoxInterestRate.TabIndex = 6;
            // 
            // textBoxDownPayment
            // 
            this.textBoxDownPayment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDownPayment.Location = new System.Drawing.Point(295, 277);
            this.textBoxDownPayment.Name = "textBoxDownPayment";
            this.textBoxDownPayment.Size = new System.Drawing.Size(301, 48);
            this.textBoxDownPayment.TabIndex = 7;
            // 
            // buttonStaging
            // 
            this.buttonStaging.Location = new System.Drawing.Point(84, 393);
            this.buttonStaging.Name = "buttonStaging";
            this.buttonStaging.Size = new System.Drawing.Size(151, 42);
            this.buttonStaging.TabIndex = 8;
            this.buttonStaging.Text = "PMT(月付)";
            this.buttonStaging.UseVisualStyleBackColor = true;
            this.buttonStaging.Click += new System.EventHandler(this.buttonStaging_Click);
            // 
            // buttonPayOff
            // 
            this.buttonPayOff.Location = new System.Drawing.Point(272, 393);
            this.buttonPayOff.Name = "buttonPayOff";
            this.buttonPayOff.Size = new System.Drawing.Size(151, 42);
            this.buttonPayOff.TabIndex = 9;
            this.buttonPayOff.Text = "總付款";
            this.buttonPayOff.UseVisualStyleBackColor = true;
            this.buttonPayOff.Click += new System.EventHandler(this.buttonPayOff_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(460, 393);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(151, 42);
            this.buttonReport.TabIndex = 10;
            this.buttonReport.Text = "彙報";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 498);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonPayOff);
            this.Controls.Add(this.buttonStaging);
            this.Controls.Add(this.textBoxDownPayment);
            this.Controls.Add(this.textBoxInterestRate);
            this.Controls.Add(this.textBoxDeadline);
            this.Controls.Add(this.textBoxLoanAmount);
            this.Controls.Add(this.labelDownPayment);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(labelLoanAmount);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelDownPayment;
        private System.Windows.Forms.TextBox textBoxLoanAmount;
        private System.Windows.Forms.TextBox textBoxDeadline;
        private System.Windows.Forms.TextBox textBoxInterestRate;
        private System.Windows.Forms.TextBox textBoxDownPayment;
        private System.Windows.Forms.Button buttonStaging;
        private System.Windows.Forms.Button buttonPayOff;
        private System.Windows.Forms.Button buttonReport;
    }
}