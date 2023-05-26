namespace pjNSL
{
    partial class frmAddCouponInterface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCouponInterface));
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDiscountMoney = new System.Windows.Forms.TextBox();
			this.timeExpire = new System.Windows.Forms.DateTimePicker();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.timeStart = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDiscountCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(183, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 51);
			this.label1.TabIndex = 86;
			this.label1.Text = "新增折扣碼";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(141, 77);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(392, 22);
			this.txtName.TabIndex = 83;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(30, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 24);
			this.label2.TabIndex = 84;
			this.label2.Text = "折扣碼標題";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(25, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(540, 320);
			this.label8.TabIndex = 81;
			this.label8.Text = " ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(294, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 24);
			this.label3.TabIndex = 84;
			this.label3.Text = "到期時間";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(49, 308);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 24);
			this.label4.TabIndex = 84;
			this.label4.Text = "折扣金額";
			// 
			// txtDiscountMoney
			// 
			this.txtDiscountMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDiscountMoney.Location = new System.Drawing.Point(141, 308);
			this.txtDiscountMoney.Multiline = true;
			this.txtDiscountMoney.Name = "txtDiscountMoney";
			this.txtDiscountMoney.Size = new System.Drawing.Size(147, 22);
			this.txtDiscountMoney.TabIndex = 83;
			// 
			// timeExpire
			// 
			this.timeExpire.Location = new System.Drawing.Point(386, 260);
			this.timeExpire.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.timeExpire.MinDate = new System.DateTime(2023, 5, 17, 0, 0, 0, 0);
			this.timeExpire.Name = "timeExpire";
			this.timeExpire.Size = new System.Drawing.Size(147, 22);
			this.timeExpire.TabIndex = 89;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnClose.Location = new System.Drawing.Point(409, 23);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 32);
			this.btnClose.TabIndex = 91;
			this.btnClose.Text = "取消";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAdd.Location = new System.Drawing.Point(490, 23);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 32);
			this.btnAdd.TabIndex = 90;
			this.btnAdd.Text = "送出";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(49, 260);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 24);
			this.label5.TabIndex = 84;
			this.label5.Text = "開始時間";
			// 
			// timeStart
			// 
			this.timeStart.Location = new System.Drawing.Point(141, 260);
			this.timeStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.timeStart.MinDate = new System.DateTime(2023, 5, 17, 0, 0, 0, 0);
			this.timeStart.Name = "timeStart";
			this.timeStart.Size = new System.Drawing.Size(147, 22);
			this.timeStart.TabIndex = 89;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(294, 306);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 24);
			this.label6.TabIndex = 84;
			this.label6.Text = "上架狀態";
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Location = new System.Drawing.Point(386, 310);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(147, 20);
			this.comboBoxStatus.TabIndex = 92;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(68, 219);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 24);
			this.label7.TabIndex = 84;
			this.label7.Text = "折扣碼";
			// 
			// txtDiscountCode
			// 
			this.txtDiscountCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDiscountCode.Location = new System.Drawing.Point(141, 221);
			this.txtDiscountCode.Multiline = true;
			this.txtDiscountCode.Name = "txtDiscountCode";
			this.txtDiscountCode.Size = new System.Drawing.Size(392, 22);
			this.txtDiscountCode.TabIndex = 83;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(87, 149);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 24);
			this.label9.TabIndex = 84;
			this.label9.Text = "內文";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(141, 105);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(392, 110);
			this.txtDescription.TabIndex = 83;
			// 
			// frmAddCouponInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 363);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.timeStart);
			this.Controls.Add(this.timeExpire);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDiscountMoney);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDiscountCode);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Name = "frmAddCouponInterface";
			this.Text = "frmAddCouponInterface";
			this.Load += new System.EventHandler(this.frmAddCouponInterface_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscountMoney;
        private System.Windows.Forms.DateTimePicker timeExpire;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker timeStart;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDiscountCode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtDescription;
	}
}