using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class textEditor : Form
    {
        public textEditor()
        {
            InitializeComponent();
            
        }

        bool textChanged = false;
        string currentFile = "";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (((DialogResult.OK == MessageBox.Show("The content will be lost.", "Warning?", MessageBoxButtons.OKCancel))))
                {
                    richTextBox1.Text = "";
                    currentFile = "";
                }

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentFile = openFileDialog1.FileName;
                    if (Path.GetExtension(currentFile) == ".txt" || Path.GetExtension(currentFile) == ".rtf")
                    {
                        richTextBox1.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        richTextBox1.LoadFile(currentFile);
                        this.Text = Path.GetFileName(currentFile) + " - Text Editor";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                toolStripStatusLabel1.Text = openFileDialog1.FileName;
                statusStrip1.Update();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textChanged = true;
            if (currentFile == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                richTextBox1.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void clearAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
            richTextBox1.Focus();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            richTextBox1.AppendText($" {time} ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length >= 0)
            {
                int wordCount = Regex.Matches(richTextBox1.Text, @"\b[A-Za-z0-9]+\b").Count;
                toolStripStatusWordCounter.Text = $"Words: {wordCount}";
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                saveFileDialog1.FileName = "Untitled";
            }
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".txt" || Path.GetExtension(saveFileDialog1.FileName) == ".rtf")
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }

                currentFile = saveFileDialog1.FileName;
                this.Text = Path.GetFileName(currentFile) + " - Text Editor";
            }
        }

        private void textEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textChanged == false && richTextBox1.TextLength > 0)
            {
                if (MessageBox.Show("Changes were not saved! Save changes?", "Warning", MessageBoxButtons.YesNoCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

                textChanged = true;

                if (currentFile == "")
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    richTextBox1.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(toolStripTextBoxSearch.Text, toolStripTextBoxReplace.Text);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            string temp = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = temp;
            while (index < richTextBox1.Text.LastIndexOf(toolStripTextBoxFind.Text))
            {
                richTextBox1.Find(toolStripTextBoxFind.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Yellow;
                index = richTextBox1.Text.IndexOf(toolStripTextBoxFind.Text, index) + 1;
            }
        }
    }
}
