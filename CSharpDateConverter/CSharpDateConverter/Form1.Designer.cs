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
            this.datagridMemberInfo = new System.Windows.Forms.DataGridView();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonFixDates = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMemberInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(15, 156);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(78, 28);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagridMemberInfo
            // 
            this.datagridMemberInfo.AllowUserToAddRows = false;
            this.datagridMemberInfo.AllowUserToDeleteRows = false;
            this.datagridMemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMemberInfo.Location = new System.Drawing.Point(15, 24);
            this.datagridMemberInfo.Name = "datagridMemberInfo";
            this.datagridMemberInfo.ReadOnly = true;
            this.datagridMemberInfo.Size = new System.Drawing.Size(533, 123);
            this.datagridMemberInfo.TabIndex = 1;
            this.datagridMemberInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddatagridMemberInfo_CellContentClick);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(239, 156);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(78, 28);
            this.buttonLoadFile.TabIndex = 2;
            this.buttonLoadFile.Text = "Load";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonFixDates
            // 
            this.buttonFixDates.Location = new System.Drawing.Point(470, 156);
            this.buttonFixDates.Name = "buttonFixDates";
            this.buttonFixDates.Size = new System.Drawing.Size(78, 28);
            this.buttonFixDates.TabIndex = 3;
            this.buttonFixDates.Text = "Fix";
            this.buttonFixDates.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 193);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonFixDates);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.datagridMemberInfo);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "program to un-heckify your dates";
            ((System.ComponentModel.ISupportInitialize)(this.datagridMemberInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.DataGridView datagridMemberInfo;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonFixDates;
        private System.Windows.Forms.Label labelFileName;
    }
}

