
namespace MainConsole.FolderNotepad
{
    partial class Notepad
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTilt = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonBold,
            this.toolStripButtonTilt,
            this.toolStripComboBoxSize,
            this.toolStripComboBoxFont});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(956, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonAdd.Image = global::MainConsole.Properties.Resources._1653213636315;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(35, 35);
            this.toolStripButtonAdd.Text = "新增";
            this.toolStripButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = global::MainConsole.Properties.Resources._1653213629655;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(35, 35);
            this.toolStripButtonOpen.Text = "打開";
            this.toolStripButtonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::MainConsole.Properties.Resources._1653213623814;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(35, 35);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.Image = global::MainConsole.Properties.Resources._1653213645348;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(35, 35);
            this.toolStripButtonBold.Text = "加粗";
            this.toolStripButtonBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonTilt
            // 
            this.toolStripButtonTilt.Image = global::MainConsole.Properties.Resources._1653213652286;
            this.toolStripButtonTilt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTilt.Name = "toolStripButtonTilt";
            this.toolStripButtonTilt.Size = new System.Drawing.Size(35, 35);
            this.toolStripButtonTilt.Text = "斜體";
            this.toolStripButtonTilt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTilt.Click += new System.EventHandler(this.toolStripButtonTilt_Click);
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(121, 38);
            this.toolStripComboBoxSize.Text = "10";
            this.toolStripComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSize_SelectedIndexChanged);
            this.toolStripComboBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripComboBoxSize_KeyPress);
            this.toolStripComboBoxSize.TextChanged += new System.EventHandler(this.toolStripComboBoxSize_TextChanged);
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Items.AddRange(new object[] {
            "字體"});
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 38);
            this.toolStripComboBoxFont.Text = "字體";
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFont_SelectedIndexChanged);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNote.Location = new System.Drawing.Point(0, 38);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(956, 556);
            this.textBoxNote.TabIndex = 1;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 594);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonTilt;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.TextBox textBoxNote;
    }
}