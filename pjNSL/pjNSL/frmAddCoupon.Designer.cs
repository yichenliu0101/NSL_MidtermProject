namespace pjNSL
{
    partial class frmAddCoupon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCoupon));
			this.dataGVPoupon = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.labDiscountCode = new System.Windows.Forms.Label();
			this.txtDiscountCode = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGVPoupon)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGVPoupon
			// 
			this.dataGVPoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVPoupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.dataGVPoupon.Location = new System.Drawing.Point(62, 163);
			this.dataGVPoupon.Name = "dataGVPoupon";
			this.dataGVPoupon.RowTemplate.Height = 24;
			this.dataGVPoupon.Size = new System.Drawing.Size(963, 332);
			this.dataGVPoupon.TabIndex = 71;
			this.dataGVPoupon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVPoupon_CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "Id";
			this.Column1.Name = "Column1";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(25, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(1015, 522);
			this.label8.TabIndex = 70;
			this.label8.Text = " ";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(326, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(465, 66);
			this.label1.TabIndex = 74;
			this.label1.Text = "折扣碼維護";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAdd.Location = new System.Drawing.Point(893, 48);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(115, 32);
			this.btnAdd.TabIndex = 81;
			this.btnAdd.Text = "新增折扣碼";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// labDiscountCode
			// 
			this.labDiscountCode.AutoSize = true;
			this.labDiscountCode.BackColor = System.Drawing.Color.White;
			this.labDiscountCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labDiscountCode.Location = new System.Drawing.Point(68, 127);
			this.labDiscountCode.Name = "labDiscountCode";
			this.labDiscountCode.Size = new System.Drawing.Size(138, 24);
			this.labDiscountCode.TabIndex = 82;
			this.labDiscountCode.Text = "DiscountCode";
			// 
			// txtDiscountCode
			// 
			this.txtDiscountCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDiscountCode.Location = new System.Drawing.Point(208, 123);
			this.txtDiscountCode.Name = "txtDiscountCode";
			this.txtDiscountCode.Size = new System.Drawing.Size(152, 33);
			this.txtDiscountCode.TabIndex = 83;
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(390, 125);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(115, 32);
			this.btnSearch.TabIndex = 84;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// frmAddCoupon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 568);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtDiscountCode);
			this.Controls.Add(this.labDiscountCode);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGVPoupon);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label8);
			this.Name = "frmAddCoupon";
			this.Text = "frmAddCoupon";
			this.Load += new System.EventHandler(this.frmAddCoupon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGVPoupon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVPoupon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label labDiscountCode;
		private System.Windows.Forms.TextBox txtDiscountCode;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}