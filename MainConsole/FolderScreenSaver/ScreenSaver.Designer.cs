
namespace MainConsole.FolderScreenSaver
{
    partial class ScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.labelCat = new System.Windows.Forms.Label();
            this.timerScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelCat.Location = new System.Drawing.Point(313, 265);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(101, 31);
            this.labelCat.TabIndex = 0;
            this.labelCat.Text = "布偶貓";
            // 
            // timerScreen
            // 
            this.timerScreen.Enabled = true;
            this.timerScreen.Interval = 10;
            this.timerScreen.Tick += new System.EventHandler(this.timerScreen_Tick);
            // 
            // ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 554);
            this.Controls.Add(this.labelCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaver";
            this.Text = "ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScreenSaver_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaver_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Timer timerScreen;
    }
}