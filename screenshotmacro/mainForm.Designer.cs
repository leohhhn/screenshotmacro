namespace screenshotmacro
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.rbSpace = new System.Windows.Forms.RadioButton();
            this.rbCtrlF = new System.Windows.Forms.RadioButton();
            this.rbCtrlE = new System.Windows.Forms.RadioButton();
            this.rbBackSlash = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStartClick = new System.Windows.Forms.Button();
            this.btnStopClick = new System.Windows.Forms.Button();
            this.lbClick = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbBoth = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(61, 108);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Enable hotkey";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbSpace
            // 
            this.rbSpace.AutoSize = true;
            this.rbSpace.Location = new System.Drawing.Point(16, 30);
            this.rbSpace.Name = "rbSpace";
            this.rbSpace.Size = new System.Drawing.Size(56, 17);
            this.rbSpace.TabIndex = 1;
            this.rbSpace.TabStop = true;
            this.rbSpace.Text = "Space";
            this.rbSpace.UseVisualStyleBackColor = true;
            // 
            // rbCtrlF
            // 
            this.rbCtrlF.AutoSize = true;
            this.rbCtrlF.Location = new System.Drawing.Point(16, 53);
            this.rbCtrlF.Name = "rbCtrlF";
            this.rbCtrlF.Size = new System.Drawing.Size(58, 17);
            this.rbCtrlF.TabIndex = 2;
            this.rbCtrlF.TabStop = true;
            this.rbCtrlF.Text = "Ctrl + F";
            this.rbCtrlF.UseVisualStyleBackColor = true;
            // 
            // rbCtrlE
            // 
            this.rbCtrlE.AutoSize = true;
            this.rbCtrlE.Location = new System.Drawing.Point(119, 30);
            this.rbCtrlE.Name = "rbCtrlE";
            this.rbCtrlE.Size = new System.Drawing.Size(59, 17);
            this.rbCtrlE.TabIndex = 3;
            this.rbCtrlE.TabStop = true;
            this.rbCtrlE.Text = "Ctrl + E";
            this.rbCtrlE.UseVisualStyleBackColor = true;
            // 
            // rbBackSlash
            // 
            this.rbBackSlash.AutoSize = true;
            this.rbBackSlash.Location = new System.Drawing.Point(119, 53);
            this.rbBackSlash.Name = "rbBackSlash";
            this.rbBackSlash.Size = new System.Drawing.Size(30, 17);
            this.rbBackSlash.TabIndex = 4;
            this.rbBackSlash.TabStop = true;
            this.rbBackSlash.Text = "\\";
            this.rbBackSlash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select hotkey to use:";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(16, 108);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 25);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStartClick
            // 
            this.btnStartClick.Location = new System.Drawing.Point(13, 165);
            this.btnStartClick.Name = "btnStartClick";
            this.btnStartClick.Size = new System.Drawing.Size(75, 25);
            this.btnStartClick.TabIndex = 7;
            this.btnStartClick.Text = "Start";
            this.btnStartClick.UseVisualStyleBackColor = true;
            this.btnStartClick.Click += new System.EventHandler(this.btnStartClick_Click);
            // 
            // btnStopClick
            // 
            this.btnStopClick.Location = new System.Drawing.Point(119, 165);
            this.btnStopClick.Name = "btnStopClick";
            this.btnStopClick.Size = new System.Drawing.Size(75, 25);
            this.btnStopClick.TabIndex = 8;
            this.btnStopClick.Text = "Stop";
            this.btnStopClick.UseVisualStyleBackColor = true;
            this.btnStopClick.Click += new System.EventHandler(this.btnStopClick_Click);
            // 
            // lbClick
            // 
            this.lbClick.AutoSize = true;
            this.lbClick.Location = new System.Drawing.Point(14, 143);
            this.lbClick.Name = "lbClick";
            this.lbClick.Size = new System.Drawing.Size(68, 13);
            this.lbClick.TabIndex = 9;
            this.lbClick.Text = "Autoclicking:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbBoth
            // 
            this.cbBoth.AutoSize = true;
            this.cbBoth.Location = new System.Drawing.Point(12, 85);
            this.cbBoth.Name = "cbBoth";
            this.cbBoth.Size = new System.Drawing.Size(113, 17);
            this.cbBoth.TabIndex = 10;
            this.cbBoth.Text = "Apply + Next Pitch";
            this.cbBoth.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(144, 85);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(15, 14);
            this.cbAll.TabIndex = 11;
            this.cbAll.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 204);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.cbBoth);
            this.Controls.Add(this.lbClick);
            this.Controls.Add(this.btnStopClick);
            this.Controls.Add(this.btnStartClick);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBackSlash);
            this.Controls.Add(this.rbCtrlE);
            this.Controls.Add(this.rbCtrlF);
            this.Controls.Add(this.rbSpace);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbSpace;
        private System.Windows.Forms.RadioButton rbCtrlF;
        private System.Windows.Forms.RadioButton rbCtrlE;
        private System.Windows.Forms.RadioButton rbBackSlash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStartClick;
        private System.Windows.Forms.Button btnStopClick;
        private System.Windows.Forms.Label lbClick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbBoth;
        private System.Windows.Forms.CheckBox cbAll;
    }
}

