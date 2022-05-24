
namespace MainConsole.FolderAlarm
{
    partial class Alarm
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
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxSetAlarm = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTime.Location = new System.Drawing.Point(48, 68);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(260, 42);
            this.textBoxTime.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxSetAlarm);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(48, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 219);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(144, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alarm Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alarm Time :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(144, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 32);
            this.textBox2.TabIndex = 2;
            // 
            // checkBoxSetAlarm
            // 
            this.checkBoxSetAlarm.AutoSize = true;
            this.checkBoxSetAlarm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSetAlarm.Location = new System.Drawing.Point(144, 149);
            this.checkBoxSetAlarm.Name = "checkBoxSetAlarm";
            this.checkBoxSetAlarm.Size = new System.Drawing.Size(116, 28);
            this.checkBoxSetAlarm.TabIndex = 3;
            this.checkBoxSetAlarm.Text = "Set Alarm";
            this.checkBoxSetAlarm.UseVisualStyleBackColor = true;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTime);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxSetAlarm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}