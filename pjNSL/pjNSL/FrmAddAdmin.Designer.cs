namespace pjNSL
{
	partial class FrmAddAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAdmin));
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnChangeImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label12.Location = new System.Drawing.Point(-151, 98);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(86, 24);
			this.label12.TabIndex = 45;
			this.label12.Text = "基本資料";
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(43, 44);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(133, 133);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox14.TabIndex = 44;
			this.pictureBox14.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(-151, 359);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 24);
			this.label10.TabIndex = 43;
			this.label10.Text = "帳戶資料";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPassword.Location = new System.Drawing.Point(296, 140);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(260, 33);
			this.txtPassword.TabIndex = 42;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtEmail.Location = new System.Drawing.Point(296, 76);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(260, 33);
			this.txtEmail.TabIndex = 41;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label11.Location = new System.Drawing.Point(220, 143);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 24);
			this.label11.TabIndex = 39;
			this.label11.Text = "密碼：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(213, 79);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(77, 24);
			this.label6.TabIndex = 40;
			this.label6.Text = "Email：";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(481, 183);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 46;
			this.btnCreate.Text = "新增管理員";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// btnChangeImage
			// 
			this.btnChangeImage.BackColor = System.Drawing.SystemColors.Window;
			this.btnChangeImage.Location = new System.Drawing.Point(56, 183);
			this.btnChangeImage.Name = "btnChangeImage";
			this.btnChangeImage.Size = new System.Drawing.Size(105, 23);
			this.btnChangeImage.TabIndex = 47;
			this.btnChangeImage.Text = "點我更換頭像";
			this.btnChangeImage.UseVisualStyleBackColor = false;
			// 
			// FrmAddAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 229);
			this.Controls.Add(this.btnChangeImage);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label6);
			this.Name = "FrmAddAdmin";
			this.Text = "FrmAddAdmin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnChangeImage;
	}
}