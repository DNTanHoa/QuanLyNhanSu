namespace QuanLyNhanSu.Win.UserControls
{
    partial class ThongBao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baseControl8 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl6 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl5 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl4 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl3 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl2 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl1 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.baseControl7 = new QuanLyNhanSu.Win.UserControls.BaseControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu Tăng Ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu Đi Sớm Về Trễ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn Xin Nghỉ Phép";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phiếu Bổ Sung Giờ";
            // 
            // baseControl8
            // 
            this.baseControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baseControl8.LinkText = "Đã Duyệt";
            this.baseControl8.ListViewId = "LanBoSungGio_ListView_DaDuyet";
            this.baseControl8.Location = new System.Drawing.Point(369, 35);
            this.baseControl8.Name = "baseControl8";
            this.baseControl8.ShowColor = false;
            this.baseControl8.Size = new System.Drawing.Size(85, 85);
            this.baseControl8.TabIndex = 17;
            // 
            // baseControl6
            // 
            this.baseControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(110)))), ((int)(((byte)(198)))));
            this.baseControl6.LinkText = "Đã Duyệt";
            this.baseControl6.ListViewId = "LanNghiPhep_ListView_DaDuyet";
            this.baseControl6.Location = new System.Drawing.Point(118, 308);
            this.baseControl6.Name = "baseControl6";
            this.baseControl6.ShowColor = false;
            this.baseControl6.Size = new System.Drawing.Size(85, 85);
            this.baseControl6.TabIndex = 15;
            // 
            // baseControl5
            // 
            this.baseControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(110)))), ((int)(((byte)(198)))));
            this.baseControl5.LinkText = "Cần Duyệt";
            this.baseControl5.ListViewId = "LanNghiPhep_ListView_CanDuyet";
            this.baseControl5.Location = new System.Drawing.Point(20, 308);
            this.baseControl5.Name = "baseControl5";
            this.baseControl5.ShowColor = true;
            this.baseControl5.Size = new System.Drawing.Size(85, 85);
            this.baseControl5.TabIndex = 14;
            // 
            // baseControl4
            // 
            this.baseControl4.BackColor = System.Drawing.Color.Navy;
            this.baseControl4.LinkText = "Đã Duyệt";
            this.baseControl4.ListViewId = "LanXinDiTre_ListView_DaDuyet";
            this.baseControl4.Location = new System.Drawing.Point(118, 173);
            this.baseControl4.Name = "baseControl4";
            this.baseControl4.ShowColor = false;
            this.baseControl4.Size = new System.Drawing.Size(85, 85);
            this.baseControl4.TabIndex = 13;
            // 
            // baseControl3
            // 
            this.baseControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseControl3.LinkText = "Cần Duyệt";
            this.baseControl3.ListViewId = "LanXinDiTre_ListView_CanDuyet";
            this.baseControl3.Location = new System.Drawing.Point(20, 173);
            this.baseControl3.Name = "baseControl3";
            this.baseControl3.ShowColor = true;
            this.baseControl3.Size = new System.Drawing.Size(85, 85);
            this.baseControl3.TabIndex = 12;
            // 
            // baseControl2
            // 
            this.baseControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baseControl2.LinkText = "Đã Duyệt";
            this.baseControl2.ListViewId = "LanTangCa_ListView_DaDuyet";
            this.baseControl2.Location = new System.Drawing.Point(118, 35);
            this.baseControl2.Name = "baseControl2";
            this.baseControl2.ShowColor = false;
            this.baseControl2.Size = new System.Drawing.Size(85, 85);
            this.baseControl2.TabIndex = 11;
            // 
            // baseControl1
            // 
            this.baseControl1.BackColor = System.Drawing.Color.Green;
            this.baseControl1.LinkText = "Cần Duyệt";
            this.baseControl1.ListViewId = "LanTangCa_ListView_CanDuyet";
            this.baseControl1.Location = new System.Drawing.Point(20, 35);
            this.baseControl1.Name = "baseControl1";
            this.baseControl1.ShowColor = true;
            this.baseControl1.Size = new System.Drawing.Size(85, 85);
            this.baseControl1.TabIndex = 10;
            // 
            // baseControl7
            // 
            this.baseControl7.BackColor = System.Drawing.Color.Olive;
            this.baseControl7.LinkText = "Cần Duyệt";
            this.baseControl7.ListViewId = "LanBoSungGio_ListView_CanDuyet";
            this.baseControl7.Location = new System.Drawing.Point(274, 35);
            this.baseControl7.Name = "baseControl7";
            this.baseControl7.ShowColor = true;
            this.baseControl7.Size = new System.Drawing.Size(85, 85);
            this.baseControl7.TabIndex = 16;
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseControl8);
            this.Controls.Add(this.baseControl7);
            this.Controls.Add(this.baseControl6);
            this.Controls.Add(this.baseControl5);
            this.Controls.Add(this.baseControl4);
            this.Controls.Add(this.baseControl3);
            this.Controls.Add(this.baseControl2);
            this.Controls.Add(this.baseControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongBao";
            this.Size = new System.Drawing.Size(480, 431);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private BaseControl baseControl1;
        private BaseControl baseControl2;
        private BaseControl baseControl3;
        private BaseControl baseControl4;
        private BaseControl baseControl5;
        private BaseControl baseControl6;
        private BaseControl baseControl8;
        private BaseControl baseControl7;
    }
}
