
namespace FolderGenerator
{
    partial class FolderGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderGenerator));
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnChooseDestination = new System.Windows.Forms.Button();
            this.btnChooseExcel = new System.Windows.Forms.Button();
            this.cbGenerateType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(6, 59);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(168, 40);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download Template";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Template";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Correction",
            "Case Making"});
            this.cbType.Location = new System.Drawing.Point(6, 25);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(168, 28);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.txtDestinationPath);
            this.groupBox2.Controls.Add(this.txtExcelPath);
            this.groupBox2.Controls.Add(this.btnChooseDestination);
            this.groupBox2.Controls.Add(this.btnChooseExcel);
            this.groupBox2.Controls.Add(this.cbGenerateType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Folder";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 123);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(562, 36);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Folder";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Enabled = false;
            this.txtDestinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationPath.Location = new System.Drawing.Point(192, 91);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(376, 26);
            this.txtDestinationPath.TabIndex = 5;
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Enabled = false;
            this.txtExcelPath.Location = new System.Drawing.Point(192, 59);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(376, 26);
            this.txtExcelPath.TabIndex = 4;
            // 
            // btnChooseDestination
            // 
            this.btnChooseDestination.Location = new System.Drawing.Point(6, 91);
            this.btnChooseDestination.Name = "btnChooseDestination";
            this.btnChooseDestination.Size = new System.Drawing.Size(180, 27);
            this.btnChooseDestination.TabIndex = 3;
            this.btnChooseDestination.Text = "Choose Destination";
            this.btnChooseDestination.UseVisualStyleBackColor = true;
            this.btnChooseDestination.Click += new System.EventHandler(this.btnChooseDestination_Click);
            // 
            // btnChooseExcel
            // 
            this.btnChooseExcel.Location = new System.Drawing.Point(6, 59);
            this.btnChooseExcel.Name = "btnChooseExcel";
            this.btnChooseExcel.Size = new System.Drawing.Size(180, 26);
            this.btnChooseExcel.TabIndex = 1;
            this.btnChooseExcel.Text = "Choose Excel";
            this.btnChooseExcel.UseVisualStyleBackColor = true;
            this.btnChooseExcel.Click += new System.EventHandler(this.btnChooseExcel_Click);
            // 
            // cbGenerateType
            // 
            this.cbGenerateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenerateType.FormattingEnabled = true;
            this.cbGenerateType.Items.AddRange(new object[] {
            "Correction",
            "Case Making"});
            this.cbGenerateType.Location = new System.Drawing.Point(6, 25);
            this.cbGenerateType.Name = "cbGenerateType";
            this.cbGenerateType.Size = new System.Drawing.Size(180, 28);
            this.cbGenerateType.TabIndex = 0;
            this.cbGenerateType.SelectedIndexChanged += new System.EventHandler(this.cbGenerateType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created by SW16-2";
            // 
            // FolderGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FolderGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGenerateType;
        private System.Windows.Forms.Button btnChooseExcel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnChooseDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

