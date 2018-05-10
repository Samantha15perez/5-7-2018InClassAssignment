namespace CSharpDateConverter
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonFixDates = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 153);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(90, 28);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(236, 156);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(90, 28);
            this.buttonLoadFile.TabIndex = 2;
            this.buttonLoadFile.Text = "Load";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonFixDates
            // 
            this.buttonFixDates.Location = new System.Drawing.Point(458, 156);
            this.buttonFixDates.Name = "buttonFixDates";
            this.buttonFixDates.Size = new System.Drawing.Size(90, 28);
            this.buttonFixDates.TabIndex = 3;
            this.buttonFixDates.Text = "Fix and Output";
            this.buttonFixDates.UseVisualStyleBackColor = true;
            this.buttonFixDates.Click += new System.EventHandler(this.buttonFixDates_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFileName.Location = new System.Drawing.Point(15, 2);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(533, 19);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.Size = new System.Drawing.Size(536, 115);
            this.dataGridViewMembers.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 193);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonFixDates);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "program to un-heckify your dates";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonFixDates;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
    }
}

