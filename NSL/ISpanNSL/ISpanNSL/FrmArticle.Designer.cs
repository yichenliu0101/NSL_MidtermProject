namespace ISpanNSL
{
	partial class FrmArticle
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGVPArticle = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCreate = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGVPArticle)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGVPArticle
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dataGVPArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGVPArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGVPArticle.BackgroundColor = System.Drawing.Color.White;
			this.dataGVPArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGVPArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGVPArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGVPArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVPArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGVPArticle.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGVPArticle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			this.dataGVPArticle.Location = new System.Drawing.Point(59, 91);
			this.dataGVPArticle.Name = "dataGVPArticle";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGVPArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGVPArticle.RowHeadersVisible = false;
			this.dataGVPArticle.RowHeadersWidth = 51;
			this.dataGVPArticle.RowTemplate.Height = 24;
			this.dataGVPArticle.Size = new System.Drawing.Size(1342, 486);
			this.dataGVPArticle.TabIndex = 86;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ArticlesClick";
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.Visible = false;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "文章封面";
			this.Column6.Name = "Column6";
			this.Column6.Width = 150;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Title";
			this.Column5.HeaderText = "標題";
			this.Column5.Name = "Column5";
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.DataPropertyName = "ArticleContent";
			this.Column2.HeaderText = "文章內容";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "CreatedTime";
			this.Column3.HeaderText = "新增時間";
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ModifiedTime";
			this.Column4.HeaderText = "修改時間";
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCreate.Location = new System.Drawing.Point(1286, 34);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(115, 32);
			this.btnCreate.TabIndex = 89;
			this.btnCreate.Text = "新增";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox2.Location = new System.Drawing.Point(1289, 39);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(115, 30);
			this.textBox2.TabIndex = 136;
			// 
			// FrmArticle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1460, 621);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.dataGVPArticle);
			this.Controls.Add(this.textBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmArticle";
			this.Text = "FrmArticle";
			this.Load += new System.EventHandler(this.FrmArticle_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGVPArticle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGVPArticle;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.TextBox textBox2;
	}
}