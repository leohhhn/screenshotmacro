namespace screenshotmacro
{
    partial class fHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHelp));
            this.labout = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lInsrt = new System.Windows.Forms.Label();
            this.lCr = new System.Windows.Forms.Label();
            this.lBug = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labout
            // 
            this.labout.Location = new System.Drawing.Point(6, 16);
            this.labout.Name = "labout";
            this.labout.Size = new System.Drawing.Size(298, 30);
            this.labout.TabIndex = 0;
            this.labout.Text = "This is a hotkey program made for Synergy Baseball Loggers that allows them to cl" +
    "ick the \"Apply\" button with ease.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lBug);
            this.groupBox1.Controls.Add(this.lCr);
            this.groupBox1.Controls.Add(this.lInsrt);
            this.groupBox1.Controls.Add(this.labout);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lInsrt
            // 
            this.lInsrt.Location = new System.Drawing.Point(6, 55);
            this.lInsrt.Name = "lInsrt";
            this.lInsrt.Size = new System.Drawing.Size(205, 55);
            this.lInsrt.TabIndex = 1;
            this.lInsrt.Text = "First, select a hotkey you want to use. Second, make sure the Logger is running. " +
    "Last, click start.";
            // 
            // lCr
            // 
            this.lCr.Location = new System.Drawing.Point(193, 140);
            this.lCr.Name = "lCr";
            this.lCr.Size = new System.Drawing.Size(111, 15);
            this.lCr.TabIndex = 2;
            this.lCr.Text = "© 2018 OutOfBounds";
            // 
            // lBug
            // 
            this.lBug.Location = new System.Drawing.Point(6, 110);
            this.lBug.Name = "lBug";
            this.lBug.Size = new System.Drawing.Size(205, 15);
            this.lBug.TabIndex = 3;
            this.lBug.Text = "If you find any bugs, please e-mail me at";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 128);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(149, 20);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.Text = "outofbounds@protonmail.com";
            // 
            // fHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 168);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHelp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fHelp_FormClosed);
            this.Load += new System.EventHandler(this.fHelp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lInsrt;
        private System.Windows.Forms.Label lCr;
        private System.Windows.Forms.Label lBug;
        private System.Windows.Forms.TextBox tbEmail;
    }
}