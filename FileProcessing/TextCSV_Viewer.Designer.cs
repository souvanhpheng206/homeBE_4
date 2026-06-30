namespace FileProcessing
{
	partial class frmTextView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabpText = new System.Windows.Forms.TabPage();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.tbEndRow = new System.Windows.Forms.TextBox();
            this.tbStartRow = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Label();
            this.StartRow = new System.Windows.Forms.Label();
            this.EndRow = new System.Windows.Forms.Label();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.tabpCSV = new System.Windows.Forms.TabPage();
            this.tbFilterCsv = new System.Windows.Forms.TextBox();
            this.tbEndRowCsv = new System.Windows.Forms.TextBox();
            this.tbStartRowCsv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA256_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA1_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReadCSV = new System.Windows.Forms.Button();
            this.tabcMain.SuspendLayout();
            this.tabpText.SuspendLayout();
            this.tabpCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(93, 11);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(809, 22);
            this.tbFileName.TabIndex = 1;
            this.tbFileName.Text = "D:\\YutData\\DistributedHome\\cdti.Code\\FileProcessing\\data\\malware_500.csv";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(936, 6);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(100, 27);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tabcMain
            // 
            this.tabcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcMain.Controls.Add(this.tabpText);
            this.tabcMain.Controls.Add(this.tabpCSV);
            this.tabcMain.Location = new System.Drawing.Point(11, 38);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(1056, 889);
            this.tabcMain.TabIndex = 3;
            // 
            // tabpText
            // 
            this.tabpText.Controls.Add(this.tbFilter);
            this.tabpText.Controls.Add(this.tbEndRow);
            this.tabpText.Controls.Add(this.tbStartRow);
            this.tabpText.Controls.Add(this.Filter);
            this.tabpText.Controls.Add(this.StartRow);
            this.tabpText.Controls.Add(this.EndRow);
            this.tabpText.Controls.Add(this.rtbShow);
            this.tabpText.Controls.Add(this.btRead);
            this.tabpText.Location = new System.Drawing.Point(4, 25);
            this.tabpText.Name = "tabpText";
            this.tabpText.Padding = new System.Windows.Forms.Padding(3);
            this.tabpText.Size = new System.Drawing.Size(1048, 860);
            this.tabpText.TabIndex = 0;
            this.tabpText.Text = "Text";
            this.tabpText.UseVisualStyleBackColor = true;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(773, 41);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(125, 22);
            this.tbFilter.TabIndex = 7;
            // 
            // tbEndRow
            // 
            this.tbEndRow.Location = new System.Drawing.Point(434, 41);
            this.tbEndRow.Name = "tbEndRow";
            this.tbEndRow.Size = new System.Drawing.Size(142, 22);
            this.tbEndRow.TabIndex = 6;
            // 
            // tbStartRow
            // 
            this.tbStartRow.Location = new System.Drawing.Point(162, 41);
            this.tbStartRow.Name = "tbStartRow";
            this.tbStartRow.Size = new System.Drawing.Size(128, 22);
            this.tbStartRow.TabIndex = 5;
            this.tbStartRow.TextChanged += new System.EventHandler(this.tbStartRow_TextChanged);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Location = new System.Drawing.Point(813, 13);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(36, 16);
            this.Filter.TabIndex = 4;
            this.Filter.Text = "Filter";
            // 
            // StartRow
            // 
            this.StartRow.AutoSize = true;
            this.StartRow.Location = new System.Drawing.Point(197, 13);
            this.StartRow.Name = "StartRow";
            this.StartRow.Size = new System.Drawing.Size(61, 16);
            this.StartRow.TabIndex = 3;
            this.StartRow.Text = "StartRow";
            // 
            // EndRow
            // 
            this.EndRow.AutoSize = true;
            this.EndRow.Location = new System.Drawing.Point(468, 13);
            this.EndRow.Name = "EndRow";
            this.EndRow.Size = new System.Drawing.Size(58, 16);
            this.EndRow.TabIndex = 2;
            this.EndRow.Text = "EndRow";
            this.EndRow.Click += new System.EventHandler(this.label2_Click);
            // 
            // rtbShow
            // 
            this.rtbShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbShow.Location = new System.Drawing.Point(-8, 100);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(1052, 528);
            this.rtbShow.TabIndex = 1;
            this.rtbShow.Text = "";
            this.rtbShow.WordWrap = false;
            this.rtbShow.TextChanged += new System.EventHandler(this.rtbShow_TextChanged);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(15, 13);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(103, 31);
            this.btRead.TabIndex = 0;
            this.btRead.Text = "read as text file";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // tabpCSV
            // 
            this.tabpCSV.Controls.Add(this.tbFilterCsv);
            this.tabpCSV.Controls.Add(this.tbEndRowCsv);
            this.tabpCSV.Controls.Add(this.tbStartRowCsv);
            this.tabpCSV.Controls.Add(this.label4);
            this.tabpCSV.Controls.Add(this.label3);
            this.tabpCSV.Controls.Add(this.label2);
            this.tabpCSV.Controls.Add(this.dgvData);
            this.tabpCSV.Controls.Add(this.btReadCSV);
            this.tabpCSV.Location = new System.Drawing.Point(4, 25);
            this.tabpCSV.Name = "tabpCSV";
            this.tabpCSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCSV.Size = new System.Drawing.Size(1048, 860);
            this.tabpCSV.TabIndex = 1;
            this.tabpCSV.Text = "CSV";
            this.tabpCSV.UseVisualStyleBackColor = true;
            // 
            // tbFilterCsv
            // 
            this.tbFilterCsv.Location = new System.Drawing.Point(881, 564);
            this.tbFilterCsv.Name = "tbFilterCsv";
            this.tbFilterCsv.Size = new System.Drawing.Size(116, 22);
            this.tbFilterCsv.TabIndex = 7;
            // 
            // tbEndRowCsv
            // 
            this.tbEndRowCsv.Location = new System.Drawing.Point(681, 564);
            this.tbEndRowCsv.Name = "tbEndRowCsv";
            this.tbEndRowCsv.Size = new System.Drawing.Size(122, 22);
            this.tbEndRowCsv.TabIndex = 6;
            // 
            // tbStartRowCsv
            // 
            this.tbStartRowCsv.Location = new System.Drawing.Point(451, 564);
            this.tbStartRowCsv.Name = "tbStartRowCsv";
            this.tbStartRowCsv.Size = new System.Drawing.Size(124, 22);
            this.tbStartRowCsv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "EndRow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "StartRow";
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterDate,
            this.SHA256_Hash,
            this.MD5_Hash,
            this.SHA1_Hash});
            this.dgvData.Location = new System.Drawing.Point(-3, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(1007, 501);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // RegisterDate
            // 
            this.RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RegisterDate.HeaderText = "Date";
            this.RegisterDate.MinimumWidth = 8;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Width = 65;
            // 
            // SHA256_Hash
            // 
            this.SHA256_Hash.HeaderText = "SHA256 Hash";
            this.SHA256_Hash.MinimumWidth = 8;
            this.SHA256_Hash.Name = "SHA256_Hash";
            this.SHA256_Hash.Width = 150;
            // 
            // MD5_Hash
            // 
            this.MD5_Hash.HeaderText = "MD5Hash";
            this.MD5_Hash.MinimumWidth = 8;
            this.MD5_Hash.Name = "MD5_Hash";
            this.MD5_Hash.Width = 150;
            // 
            // SHA1_Hash
            // 
            this.SHA1_Hash.HeaderText = "SHA1 Hash";
            this.SHA1_Hash.MinimumWidth = 8;
            this.SHA1_Hash.Name = "SHA1_Hash";
            this.SHA1_Hash.Width = 150;
            // 
            // btReadCSV
            // 
            this.btReadCSV.Location = new System.Drawing.Point(22, 524);
            this.btReadCSV.Name = "btReadCSV";
            this.btReadCSV.Size = new System.Drawing.Size(138, 62);
            this.btReadCSV.TabIndex = 0;
            this.btReadCSV.Text = "read as csv";
            this.btReadCSV.UseVisualStyleBackColor = true;
            this.btReadCSV.Click += new System.EventHandler(this.btReadCSV_Click);
            // 
            // frmTextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 703);
            this.Controls.Add(this.tabcMain);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Name = "frmTextView";
            this.Text = "Text/CSV viewer";
            this.tabcMain.ResumeLayout(false);
            this.tabpText.ResumeLayout(false);
            this.tabpText.PerformLayout();
            this.tabpCSV.ResumeLayout(false);
            this.tabpCSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.TabControl tabcMain;
		private System.Windows.Forms.TabPage tabpText;
		private System.Windows.Forms.TabPage tabpCSV;
		private System.Windows.Forms.Button btRead;
		private System.Windows.Forms.RichTextBox rtbShow;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.Button btReadCSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn SHA256_Hash;
		private System.Windows.Forms.DataGridViewTextBoxColumn MD5_Hash;
		private System.Windows.Forms.DataGridViewTextBoxColumn SHA1_Hash;
        private System.Windows.Forms.Label EndRow;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.Label StartRow;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.TextBox tbEndRow;
        private System.Windows.Forms.TextBox tbStartRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilterCsv;
        private System.Windows.Forms.TextBox tbEndRowCsv;
        private System.Windows.Forms.TextBox tbStartRowCsv;
    }
}

