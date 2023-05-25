namespace pjNSL
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.picPush = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picReport);
            this.panel1.Controls.Add(this.picTeacher);
            this.panel1.Controls.Add(this.picMember);
            this.panel1.Controls.Add(this.picPush);
            this.panel1.Location = new System.Drawing.Point(12, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 191);
            this.panel1.TabIndex = 1;
            // 
            // picReport
            // 
            this.picReport.Image = ((System.Drawing.Image)(resources.GetObject("picReport.Image")));
            this.picReport.Location = new System.Drawing.Point(814, 3);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(162, 180);
            this.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReport.TabIndex = 5;
            this.picReport.TabStop = false;
            this.picReport.Click += new System.EventHandler(this.picReport_Click);
            // 
            // picTeacher
            // 
            this.picTeacher.Image = ((System.Drawing.Image)(resources.GetObject("picTeacher.Image")));
            this.picTeacher.Location = new System.Drawing.Point(571, 3);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(162, 180);
            this.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeacher.TabIndex = 4;
            this.picTeacher.TabStop = false;
            this.picTeacher.Click += new System.EventHandler(this.picTeacher_Click);
            // 
            // picMember
            // 
            this.picMember.Image = ((System.Drawing.Image)(resources.GetObject("picMember.Image")));
            this.picMember.Location = new System.Drawing.Point(313, 3);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(162, 180);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMember.TabIndex = 3;
            this.picMember.TabStop = false;
            this.picMember.Click += new System.EventHandler(this.picMember_Click);
            // 
            // picPush
            // 
            this.picPush.Image = ((System.Drawing.Image)(resources.GetObject("picPush.Image")));
            this.picPush.Location = new System.Drawing.Point(71, 3);
            this.picPush.Name = "picPush";
            this.picPush.Size = new System.Drawing.Size(162, 180);
            this.picPush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPush.TabIndex = 2;
            this.picPush.TabStop = false;
            this.picPush.Click += new System.EventHandler(this.picPush_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(294, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(477, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(392, 114);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(285, 207);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1064, 568);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = " frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPush;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.PictureBox picMember;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

