
namespace MainConsole.FolderPictureViewer
{
    partial class PictureViewer
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
            this.pictureBoxOpenView = new System.Windows.Forms.PictureBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOpenView
            // 
            this.pictureBoxOpenView.Location = new System.Drawing.Point(45, 41);
            this.pictureBoxOpenView.Name = "pictureBoxOpenView";
            this.pictureBoxOpenView.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOpenView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpenView.TabIndex = 0;
            this.pictureBoxOpenView.TabStop = false;
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpen.Location = new System.Drawing.Point(482, 41);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(127, 49);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "打開";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 512);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.pictureBoxOpenView);
            this.Name = "PictureViewer";
            this.Text = "PictureViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOpenView;
        private System.Windows.Forms.Button buttonOpen;
    }
}