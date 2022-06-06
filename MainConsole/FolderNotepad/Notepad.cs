using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainConsole.FolderNotepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            InstalledFontCollection myFonts = new InstalledFontCollection();
            FontFamily[] ff = myFonts.Families;
            int count = ff.Length;
            for (int i = 0; i < count; i++)
            {
                string FontName = ff[i].Name;
                toolStripComboBoxFont.Items.Add(FontName);
            }
            textBoxNote.Text = "";
            this.Text = "";
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文档(*.txt)|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string inName = ofd.FileName;
                this.Text = inName;
                StreamReader sr = new StreamReader(inName, Encoding.UTF8);
                textBoxNote.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            textBoxNote.Text = "";
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
  
          
            if (textBoxNote.Text.Trim() != "")
            {
                if (this.Text == "")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string outName = saveFileDialog.FileName;
                        StreamWriter streamWriter = new StreamWriter(outName, false);
                        streamWriter.WriteLine(textBoxNote.Text.Trim());
                        streamWriter.Flush();
                        streamWriter.Close();
                        this.Text = outName;

                    }
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter(this.Text, false);
                    streamWriter.WriteLine(textBoxNote.Text.Trim());
                    streamWriter.Flush();
                    streamWriter.Close();
                }

            }
            else
            {
                MessageBox.Show("内容为空，不能保存", "信息提示");
            }
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Font.Bold == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Bold);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }
        }

        private void toolStripButtonTilt_Click(object sender, EventArgs e)
        {

            if (textBoxNote.Font.Italic == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Italic);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }

        }

        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            textBoxNote.Font = new Font(fontName, float.Parse(toolStripComboBoxSize.Text));
        }

        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            textBoxNote.Font = new Font(fontName, float.Parse(toolStripComboBoxSize.Text));
        }

        private void toolStripComboBoxSize_TextChanged(object sender, EventArgs e)
        { 
            if(Int32.Parse(toolStripComboBoxSize.Text) < 10)
            {
                toolStripComboBoxSize.Text = "10";
            }

            string fontName = toolStripComboBoxSize.Text;
            if (fontName == "")
            {
                fontName = "10";
                toolStripComboBoxSize.Text = "10";
            }
            else
            {
                textBoxNote.Font = new Font(fontName, float.Parse(toolStripComboBoxSize.Text));
            }
        }

        private void toolStripComboBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
