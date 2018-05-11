namespace Tutorial8_5
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
            this.nameslistbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameslistbox
            // 
            this.nameslistbox.FormattingEnabled = true;
            this.nameslistbox.Location = new System.Drawing.Point(20, 21);
            this.nameslistbox.Name = "nameslistbox";
            this.nameslistbox.Size = new System.Drawing.Size(234, 186);
            this.nameslistbox.TabIndex = 0;
            this.nameslistbox.SelectedIndexChanged += new System.EventHandler(this.nameslistbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // phonelabel
            // 
            this.phonelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonelabel.Location = new System.Drawing.Point(305, 68);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(147, 33);
            this.phonelabel.TabIndex = 1;
            this.phonelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(205, 252);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(133, 44);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 320);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameslistbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameslistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button buttonexit;
    }
}

