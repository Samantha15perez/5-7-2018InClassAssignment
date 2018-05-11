namespace Tutorial8_6
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
            this.redLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.indigoLabel = new System.Windows.Forms.Label();
            this.violetLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLabel.Location = new System.Drawing.Point(12, 9);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(61, 27);
            this.redLabel.TabIndex = 0;
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.Orange;
            this.orangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeLabel.Location = new System.Drawing.Point(79, 9);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(61, 27);
            this.orangeLabel.TabIndex = 0;
            this.orangeLabel.Click += new System.EventHandler(this.orangeLabel_Click);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowLabel.Location = new System.Drawing.Point(146, 9);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(61, 27);
            this.yellowLabel.TabIndex = 0;
            this.yellowLabel.Click += new System.EventHandler(this.yellowLabel_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLabel.Location = new System.Drawing.Point(213, 9);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(61, 27);
            this.greenLabel.TabIndex = 0;
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueLabel.Location = new System.Drawing.Point(280, 9);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(61, 27);
            this.blueLabel.TabIndex = 0;
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // indigoLabel
            // 
            this.indigoLabel.BackColor = System.Drawing.Color.Indigo;
            this.indigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indigoLabel.Location = new System.Drawing.Point(347, 9);
            this.indigoLabel.Name = "indigoLabel";
            this.indigoLabel.Size = new System.Drawing.Size(61, 27);
            this.indigoLabel.TabIndex = 0;
            this.indigoLabel.Click += new System.EventHandler(this.indigoLabel_Click);
            // 
            // violetLabel
            // 
            this.violetLabel.BackColor = System.Drawing.Color.Violet;
            this.violetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.violetLabel.Location = new System.Drawing.Point(414, 9);
            this.violetLabel.Name = "violetLabel";
            this.violetLabel.Size = new System.Drawing.Size(61, 27);
            this.violetLabel.TabIndex = 0;
            this.violetLabel.Click += new System.EventHandler(this.violetLabel_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colorLabel.Location = new System.Drawing.Point(177, 46);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(137, 27);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 85);
            this.Controls.Add(this.violetLabel);
            this.Controls.Add(this.indigoLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "Form1";
            this.Text = "Color Spectrum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label orangeLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label indigoLabel;
        private System.Windows.Forms.Label violetLabel;
        private System.Windows.Forms.Label colorLabel;
    }
}

