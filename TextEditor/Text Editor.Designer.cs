﻿
namespace TextEditor
{
    partial class textEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusWordCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxReplace = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 462);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLocation,
            this.toolStripStatusLabel1,
            this.toolStripStatusWordCounter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLocation
            // 
            this.toolStripStatusLabelLocation.Name = "toolStripStatusLabelLocation";
            this.toolStripStatusLabelLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabelLocation.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusWordCounter
            // 
            this.toolStripStatusWordCounter.Name = "toolStripStatusWordCounter";
            this.toolStripStatusWordCounter.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(824, 438);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = global::TextEditor.Properties.Resources.cut;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem1.Text = "&Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = global::TextEditor.Properties.Resources.copy;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = global::TextEditor.Properties.Resources.paste;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectToolStripMenuItem,
            this.dateTimeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::TextEditor.Properties.Resources.undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::TextEditor.Properties.Resources.redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectToolStripMenuItem.Text = "&Select";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "&Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click_1);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearAllToolStripMenuItem.Text = "&Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click_1);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dateTimeToolStripMenuItem.Text = "&Date Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.toolsToolStripMenuItem.Text = "&Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.colourToolStripMenuItem.Text = "&Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.replaceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFind});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files|*.txt|All files|*.*|Rich Text Format File|*.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Rich Text Format File(*.rtf)|*.rtf";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearch,
            this.toolStripTextBoxReplace});
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceToolStripMenuItem.Text = "&Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBoxReplace
            // 
            this.toolStripTextBoxReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxReplace.Name = "toolStripTextBoxReplace";
            this.toolStripTextBoxReplace.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 23);
            // 
            // textEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 462);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "textEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textEditor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLocation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusWordCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxReplace;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
    }
}

