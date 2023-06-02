namespace ISpanNSL
{
	partial class FrmCoupon
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtDiscountCode = new System.Windows.Forms.TextBox();
			this.labDiscountCode = new System.Windows.Forms.Label();
			this.dataGVPArticle = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCreate = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGVPArticle)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(286, 39);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(115, 32);
			this.btnSearch.TabIndex = 88;
			this.btnSearch.Text = "搜尋";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// txtDiscountCode
			// 
			this.txtDiscountCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDiscountCode.Location = new System.Drawing.Point(128, 38);
			this.txtDiscountCode.Name = "txtDiscountCode";
			this.txtDiscountCode.Size = new System.Drawing.Size(152, 33);
			this.txtDiscountCode.TabIndex = 87;
			// 
			// labDiscountCode
			// 
			this.labDiscountCode.AutoSize = true;
			this.labDiscountCode.BackColor = System.Drawing.Color.White;
			this.labDiscountCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labDiscountCode.Location = new System.Drawing.Point(55, 43);
			this.labDiscountCode.Name = "labDiscountCode";
			this.labDiscountCode.Size = new System.Drawing.Size(67, 24);
			this.labDiscountCode.TabIndex = 86;
			this.labDiscountCode.Text = "折扣碼";
			// 
			// dataGVPArticle
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dataGVPArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGVPArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGVPArticle.BackgroundColor = System.Drawing.Color.White;
			this.dataGVPArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGVPArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGVPArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGVPArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVPArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGVPArticle.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGVPArticle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			this.dataGVPArticle.Location = new System.Drawing.Point(59, 91);
			this.dataGVPArticle.Name = "dataGVPArticle";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGVPArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGVPArticle.RowHeadersVisible = false;
			this.dataGVPArticle.RowHeadersWidth = 51;
			this.dataGVPArticle.RowTemplate.Height = 24;
			this.dataGVPArticle.Size = new System.Drawing.Size(1342, 486);
			this.dataGVPArticle.TabIndex = 89;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "編號";
			this.Column1.Name = "Column1";
			this.Column1.Visible = false;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Title";
			this.Column5.HeaderText = "折扣碼";
			this.Column5.Name = "Column5";
			this.Column5.Width = 200;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "ArticleContent";
			this.Column2.HeaderText = "活動名稱";
			this.Column2.Name = "Column2";
			this.Column2.Width = 200;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "活動內容";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "折扣金額";
			this.Column7.Name = "Column7";
			this.Column7.Width = 200;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "CreatedTime";
			this.Column3.HeaderText = "開始時間";
			this.Column3.Name = "Column3";
			this.Column3.Width = 200;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ModifiedTime";
			this.Column4.HeaderText = "結束時間";
			this.Column4.Name = "Column4";
			this.Column4.Width = 200;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCreate.Location = new System.Drawing.Point(1286, 34);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(115, 32);
			this.btnCreate.TabIndex = 90;
			this.btnCreate.Text = "新增";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(289, 44);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(115, 30);
			this.textBox1.TabIndex = 135;
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
			this.textBox2.TabIndex = 135;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox3.Location = new System.Drawing.Point(131, 40);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 34);
			this.textBox3.TabIndex = 136;
			// 
			// FrmCoupon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1460, 621);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtDiscountCode);
			this.Controls.Add(this.labDiscountCode);
			this.Controls.Add(this.dataGVPArticle);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1460, 621);
			this.MinimumSize = new System.Drawing.Size(1460, 621);
			this.Name = "FrmCoupon";
			this.Text = "FrmCoupon";
			((System.ComponentModel.ISupportInitialize)(this.dataGVPArticle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtDiscountCode;
		private System.Windows.Forms.Label labDiscountCode;
		private System.Windows.Forms.DataGridView dataGVPArticle;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}