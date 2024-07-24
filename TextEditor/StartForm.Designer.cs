
namespace TextEditor
{
    partial class StartForm
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
            this.startpanel = new System.Windows.Forms.Panel();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTextEditor = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.startpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startpanel
            // 
            this.startpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startpanel.Controls.Add(this.btnExit);
            this.startpanel.Controls.Add(this.txtBox1);
            this.startpanel.Controls.Add(this.btnStart);
            this.startpanel.Controls.Add(this.lbTextEditor);
            this.startpanel.Location = new System.Drawing.Point(12, 12);
            this.startpanel.Name = "startpanel";
            this.startpanel.Size = new System.Drawing.Size(399, 387);
            this.startpanel.TabIndex = 0;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(36, 287);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(178, 72);
            this.txtBox1.TabIndex = 2;
            this.txtBox1.Text = "Author - Hristo Kazanliev \r\nStudent Number - 2101681069\r\nBuilt With C# Windows Fo" +
    "rms\r\n";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(108, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Launch";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbTextEditor
            // 
            this.lbTextEditor.AutoSize = true;
            this.lbTextEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextEditor.Location = new System.Drawing.Point(101, 50);
            this.lbTextEditor.Name = "lbTextEditor";
            this.lbTextEditor.Size = new System.Drawing.Size(185, 39);
            this.lbTextEditor.TabIndex = 0;
            this.lbTextEditor.Text = "Text Editor";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(266, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(423, 411);
            this.Controls.Add(this.startpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.startpanel.ResumeLayout(false);
            this.startpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startpanel;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbTextEditor;
        private System.Windows.Forms.Button btnExit;
    }
}