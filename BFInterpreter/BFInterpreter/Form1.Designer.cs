namespace BFInterpreter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.run = new System.Windows.Forms.ToolStripMenuItem();
            this.runEntireCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSuccess = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.groupBoxCode = new System.Windows.Forms.GroupBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelInputs = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxInputs = new System.Windows.Forms.TextBox();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.run,
            this.help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1699, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveCodeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(44, 24);
            this.file.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveCodeToolStripMenuItem
            // 
            this.saveCodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveCodeToolStripMenuItem.Image")));
            this.saveCodeToolStripMenuItem.Name = "saveCodeToolStripMenuItem";
            this.saveCodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCodeToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.saveCodeToolStripMenuItem.Text = "Save";
            this.saveCodeToolStripMenuItem.Click += new System.EventHandler(this.saveCodeToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // run
            // 
            this.run.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runEntireCodeToolStripMenuItem});
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(46, 24);
            this.run.Text = "Run";
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // runEntireCodeToolStripMenuItem
            // 
            this.runEntireCodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runEntireCodeToolStripMenuItem.Image")));
            this.runEntireCodeToolStripMenuItem.Name = "runEntireCodeToolStripMenuItem";
            this.runEntireCodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.runEntireCodeToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.runEntireCodeToolStripMenuItem.Text = "Run Entire Code";
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(53, 24);
            this.help.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("howToUseToolStripMenuItem.Image")));
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelError,
            this.toolStripStatusLabelSuccess});
            this.statusStrip.Location = new System.Drawing.Point(0, 777);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1699, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelError
            // 
            this.toolStripStatusLabelError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelError.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabelError.Name = "toolStripStatusLabelError";
            this.toolStripStatusLabelError.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelSuccess
            // 
            this.toolStripStatusLabelSuccess.ActiveLinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelSuccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelSuccess.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripStatusLabelSuccess.Name = "toolStripStatusLabelSuccess";
            this.toolStripStatusLabelSuccess.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.AutoSize = true;
            this.groupBoxMain.Controls.Add(this.buttonQuit);
            this.groupBoxMain.Controls.Add(this.groupBoxOutput);
            this.groupBoxMain.Controls.Add(this.groupBoxCode);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.Location = new System.Drawing.Point(0, 28);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(1699, 749);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Brainfuck Interpreter";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(1555, 693);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(110, 29);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.AutoSize = true;
            this.groupBoxOutput.Controls.Add(this.labelOutput);
            this.groupBoxOutput.Controls.Add(this.labelLog);
            this.groupBoxOutput.Controls.Add(this.richTextBoxLog);
            this.groupBoxOutput.Controls.Add(this.richTextBoxOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(904, 36);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(783, 646);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(21, 24);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(113, 17);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Program Output:";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(21, 358);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(36, 17);
            this.labelLog.TabIndex = 2;
            this.labelLog.Text = "Log:";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(21, 381);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(743, 244);
            this.richTextBoxLog.TabIndex = 1;
            this.richTextBoxLog.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxOutput.Location = new System.Drawing.Point(18, 47);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(743, 276);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // groupBoxCode
            // 
            this.groupBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCode.AutoSize = true;
            this.groupBoxCode.Controls.Add(this.labelPosition);
            this.groupBoxCode.Controls.Add(this.labelInputs);
            this.groupBoxCode.Controls.Add(this.buttonRun);
            this.groupBoxCode.Controls.Add(this.textBoxInputs);
            this.groupBoxCode.Controls.Add(this.checkBoxLog);
            this.groupBoxCode.Controls.Add(this.richTextBoxInput);
            this.groupBoxCode.Location = new System.Drawing.Point(13, 36);
            this.groupBoxCode.Name = "groupBoxCode";
            this.groupBoxCode.Size = new System.Drawing.Size(868, 704);
            this.groupBoxCode.TabIndex = 0;
            this.groupBoxCode.TabStop = false;
            this.groupBoxCode.Text = "Brainfuck Code";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(3, 660);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(113, 17);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Current Position:";
            // 
            // labelInputs
            // 
            this.labelInputs.AutoSize = true;
            this.labelInputs.Location = new System.Drawing.Point(187, 660);
            this.labelInputs.Name = "labelInputs";
            this.labelInputs.Size = new System.Drawing.Size(50, 17);
            this.labelInputs.TabIndex = 4;
            this.labelInputs.Text = "Inputs:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(688, 654);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(144, 29);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxInputs
            // 
            this.textBoxInputs.Location = new System.Drawing.Point(243, 657);
            this.textBoxInputs.Name = "textBoxInputs";
            this.textBoxInputs.Size = new System.Drawing.Size(197, 22);
            this.textBoxInputs.TabIndex = 1;
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Location = new System.Drawing.Point(458, 658);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(215, 21);
            this.checkBoxLog.TabIndex = 2;
            this.checkBoxLog.Text = "Show steps - limited to 10000";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            this.checkBoxLog.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(851, 614);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.SelectionChanged += new System.EventHandler(this.richTextBoxInput_SelectionChanged);
            this.richTextBoxInput.CursorChanged += new System.EventHandler(this.richTextBoxInput_CursorChanged);
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1699, 799);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brainfuck Interpreter 1.0";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxCode.ResumeLayout(false);
            this.groupBoxCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem run;
        private System.Windows.Forms.ToolStripMenuItem runEntireCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelError;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSuccess;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBoxCode;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Label labelInputs;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxInputs;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelPosition;
    }
}

