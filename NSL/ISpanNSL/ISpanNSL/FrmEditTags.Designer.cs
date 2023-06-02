namespace ISpanNSL
{
	partial class FrmEditTags
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTags));
			this.checkedListBoxTags = new System.Windows.Forms.CheckedListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListBoxTags
			// 
			this.checkedListBoxTags.CheckOnClick = true;
			this.checkedListBoxTags.FormattingEnabled = true;
			this.checkedListBoxTags.Location = new System.Drawing.Point(68, 86);
			this.checkedListBoxTags.MultiColumn = true;
			this.checkedListBoxTags.Name = "checkedListBoxTags";
			this.checkedListBoxTags.Size = new System.Drawing.Size(600, 208);
			this.checkedListBoxTags.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(512, 300);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 32);
			this.button2.TabIndex = 7;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(593, 300);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 6;
			this.button1.Text = "確定";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(277, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 39);
			this.label1.TabIndex = 5;
			this.label1.Text = "課程標籤編輯";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.Location = new System.Drawing.Point(594, 304);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 31);
			this.label12.TabIndex = 144;
			this.label12.Text = " ";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(513, 304);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 31);
			this.label2.TabIndex = 145;
			this.label2.Text = " ";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(163)))), ((int)(((byte)(104)))));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(69, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(602, 208);
			this.label3.TabIndex = 146;
			this.label3.Text = " ";
			// 
			// FrmEditTags
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(132)))));
			this.ClientSize = new System.Drawing.Size(739, 363);
			this.Controls.Add(this.checkedListBoxTags);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label3);
			this.Name = "FrmEditTags";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEditTags";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBoxTags;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}