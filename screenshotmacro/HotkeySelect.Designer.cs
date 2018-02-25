namespace screenshotmacro
{
    partial class HotkeySelect
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbSpace = new System.Windows.Forms.RadioButton();
            this.rbLShift = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Use as hotkey";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSpace
            // 
            this.rbSpace.AutoSize = true;
            this.rbSpace.Location = new System.Drawing.Point(23, 26);
            this.rbSpace.Name = "rbSpace";
            this.rbSpace.Size = new System.Drawing.Size(56, 17);
            this.rbSpace.TabIndex = 1;
            this.rbSpace.TabStop = true;
            this.rbSpace.Text = "Space";
            this.rbSpace.UseVisualStyleBackColor = true;
            // 
            // rbLShift
            // 
            this.rbLShift.AutoSize = true;
            this.rbLShift.Location = new System.Drawing.Point(23, 63);
            this.rbLShift.Name = "rbLShift";
            this.rbLShift.Size = new System.Drawing.Size(52, 17);
            this.rbLShift.TabIndex = 2;
            this.rbLShift.TabStop = true;
            this.rbLShift.Text = "LShift";
            this.rbLShift.UseVisualStyleBackColor = true;
            // 
            // HotkeySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 141);
            this.Controls.Add(this.rbLShift);
            this.Controls.Add(this.rbSpace);
            this.Controls.Add(this.button1);
            this.Name = "HotkeySelect";
            this.Load += new System.EventHandler(this.HotkeySelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbSpace;
        private System.Windows.Forms.RadioButton rbLShift;
    }
}