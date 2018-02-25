namespace screenshotmacro
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rbSpace = new System.Windows.Forms.RadioButton();
            this.rbCtrlF = new System.Windows.Forms.RadioButton();
            this.rbCtrlE = new System.Windows.Forms.RadioButton();
            this.rbCtrlS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(57, 112);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbSpace
            // 
            this.rbSpace.AutoSize = true;
            this.rbSpace.Location = new System.Drawing.Point(12, 52);
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
            this.rbCtrlF.Location = new System.Drawing.Point(12, 75);
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
            this.rbCtrlE.Location = new System.Drawing.Point(118, 52);
            this.rbCtrlE.Name = "rbCtrlE";
            this.rbCtrlE.Size = new System.Drawing.Size(59, 17);
            this.rbCtrlE.TabIndex = 3;
            this.rbCtrlE.TabStop = true;
            this.rbCtrlE.Text = "Ctrl + E";
            this.rbCtrlE.UseVisualStyleBackColor = true;
            // 
            // rbCtrlS
            // 
            this.rbCtrlS.AutoSize = true;
            this.rbCtrlS.Location = new System.Drawing.Point(118, 75);
            this.rbCtrlS.Name = "rbCtrlS";
            this.rbCtrlS.Size = new System.Drawing.Size(59, 17);
            this.rbCtrlS.TabIndex = 4;
            this.rbCtrlS.TabStop = true;
            this.rbCtrlS.Text = "Ctrl + S";
            this.rbCtrlS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select hotkey to use:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCtrlS);
            this.Controls.Add(this.rbCtrlE);
            this.Controls.Add(this.rbCtrlF);
            this.Controls.Add(this.rbSpace);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbSpace;
        private System.Windows.Forms.RadioButton rbCtrlF;
        private System.Windows.Forms.RadioButton rbCtrlE;
        private System.Windows.Forms.RadioButton rbCtrlS;
        private System.Windows.Forms.Label label1;
    }
}

