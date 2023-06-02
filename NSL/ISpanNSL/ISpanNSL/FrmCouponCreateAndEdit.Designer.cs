﻿namespace ISpanNSL
{
	partial class FrmCouponCreateAndEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCouponCreateAndEdit));
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.timeStart = new System.Windows.Forms.DateTimePicker();
			this.timeExpire = new System.Windows.Forms.DateTimePicker();
			this.txtDiscountMoney = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDiscountCode = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Items.AddRange(new object[] {
            "下架中",
            "上架中"});
			this.comboBoxStatus.Location = new System.Drawing.Point(752, 326);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(356, 32);
			this.comboBoxStatus.TabIndex = 129;
			// 
			// timeStart
			// 
			this.timeStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeStart.Location = new System.Drawing.Point(752, 112);
			this.timeStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.timeStart.MinDate = new System.DateTime(1992, 3, 12, 0, 0, 0, 0);
			this.timeStart.Name = "timeStart";
			this.timeStart.Size = new System.Drawing.Size(356, 29);
			this.timeStart.TabIndex = 125;
			// 
			// timeExpire
			// 
			this.timeExpire.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeExpire.Location = new System.Drawing.Point(752, 218);
			this.timeExpire.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.timeExpire.MinDate = new System.DateTime(1974, 6, 27, 0, 0, 0, 0);
			this.timeExpire.Name = "timeExpire";
			this.timeExpire.Size = new System.Drawing.Size(356, 29);
			this.timeExpire.TabIndex = 124;
			// 
			// txtDiscountMoney
			// 
			this.txtDiscountMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDiscountMoney.Location = new System.Drawing.Point(74, 498);
			this.txtDiscountMoney.Multiline = true;
			this.txtDiscountMoney.Name = "txtDiscountMoney";
			this.txtDiscountMoney.Size = new System.Drawing.Size(608, 32);
			this.txtDiscountMoney.TabIndex = 116;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(746, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 35);
			this.label6.TabIndex = 122;
			this.label6.Text = "上架狀態";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(68, 461);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 35);
			this.label4.TabIndex = 121;
			this.label4.Text = "折扣金額";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(746, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 35);
			this.label5.TabIndex = 120;
			this.label5.Text = "開始時間";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(746, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 35);
			this.label3.TabIndex = 119;
			this.label3.Text = "到期時間";
			// 
			// txtDiscountCode
			// 
			this.txtDiscountCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDiscountCode.Location = new System.Drawing.Point(74, 381);
			this.txtDiscountCode.Multiline = true;
			this.txtDiscountCode.Name = "txtDiscountCode";
			this.txtDiscountCode.Size = new System.Drawing.Size(608, 32);
			this.txtDiscountCode.TabIndex = 115;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(74, 218);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(608, 88);
			this.txtDescription.TabIndex = 114;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(74, 109);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(608, 32);
			this.txtName.TabIndex = 113;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(68, 344);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 35);
			this.label7.TabIndex = 118;
			this.label7.Text = "折扣碼";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(68, 181);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 35);
			this.label9.TabIndex = 117;
			this.label9.Text = "內文";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(68, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 35);
			this.label2.TabIndex = 123;
			this.label2.Text = "折扣碼標題";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(36, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(664, 542);
			this.label8.TabIndex = 130;
			this.label8.Text = " ";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(715, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(438, 542);
			this.label1.TabIndex = 131;
			this.label1.Text = " ";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(40, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(664, 542);
			this.label10.TabIndex = 132;
			this.label10.Text = " ";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.Location = new System.Drawing.Point(717, 44);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(440, 542);
			this.label11.TabIndex = 133;
			this.label11.Text = " ";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(77, 112);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(608, 32);
			this.textBox1.TabIndex = 134;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox2.Location = new System.Drawing.Point(77, 222);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(608, 87);
			this.textBox2.TabIndex = 135;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox3.Location = new System.Drawing.Point(77, 384);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(608, 32);
			this.textBox3.TabIndex = 136;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox4.Location = new System.Drawing.Point(77, 501);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(608, 32);
			this.textBox4.TabIndex = 137;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox5.Location = new System.Drawing.Point(755, 115);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(356, 29);
			this.textBox5.TabIndex = 138;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox6.Location = new System.Drawing.Point(755, 221);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(356, 29);
			this.textBox6.TabIndex = 139;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox7.Location = new System.Drawing.Point(755, 329);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(356, 32);
			this.textBox7.TabIndex = 140;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(997, 39);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 32);
			this.btnDelete.TabIndex = 143;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAdd.Location = new System.Drawing.Point(1078, 39);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 32);
			this.btnAdd.TabIndex = 141;
			this.btnAdd.Text = "送出";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.Location = new System.Drawing.Point(1078, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 31);
			this.label12.TabIndex = 149;
			this.label12.Text = " ";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
			this.label13.Location = new System.Drawing.Point(997, 42);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(77, 31);
			this.label13.TabIndex = 148;
			this.label13.Text = " ";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(132)))));
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox8.Location = new System.Drawing.Point(990, 31);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(175, 47);
			this.textBox8.TabIndex = 145;
			// 
			// FrmCouponCreateAndEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(132)))));
			this.ClientSize = new System.Drawing.Size(1180, 607);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.timeStart);
			this.Controls.Add(this.timeExpire);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.txtDiscountMoney);
			this.Controls.Add(this.txtDiscountCode);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmCouponCreateAndEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCouponCreateAndUpdate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.DateTimePicker timeStart;
		private System.Windows.Forms.DateTimePicker timeExpire;
		private System.Windows.Forms.TextBox txtDiscountMoney;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDiscountCode;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox8;
	}
}