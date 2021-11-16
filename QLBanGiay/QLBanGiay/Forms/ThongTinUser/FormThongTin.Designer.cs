
namespace QLBanGiay.Forms.ThongTinUser
{
    partial class FormThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongTin));
            this.panelInforUser = new System.Windows.Forms.Panel();
            this.iconPictureClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnThayPass = new System.Windows.Forms.Button();
            this.btnUpdateThongTin = new System.Windows.Forms.Button();
            this.pbAnhNV = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVitri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInforUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInforUser
            // 
            this.panelInforUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.panelInforUser.Controls.Add(this.iconPictureClose);
            this.panelInforUser.Controls.Add(this.btnThayPass);
            this.panelInforUser.Controls.Add(this.btnUpdateThongTin);
            this.panelInforUser.Controls.Add(this.pbAnhNV);
            this.panelInforUser.Controls.Add(this.label12);
            this.panelInforUser.Controls.Add(this.lblVitri);
            this.panelInforUser.Controls.Add(this.label4);
            this.panelInforUser.Controls.Add(this.lblSoDT);
            this.panelInforUser.Controls.Add(this.label10);
            this.panelInforUser.Controls.Add(this.lblEmail);
            this.panelInforUser.Controls.Add(this.lblDiaChi);
            this.panelInforUser.Controls.Add(this.label9);
            this.panelInforUser.Controls.Add(this.label1);
            this.panelInforUser.Controls.Add(this.lblGioiTinh);
            this.panelInforUser.Controls.Add(this.label8);
            this.panelInforUser.Controls.Add(this.lblTenNV);
            this.panelInforUser.Controls.Add(this.label6);
            this.panelInforUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInforUser.Location = new System.Drawing.Point(0, 0);
            this.panelInforUser.Name = "panelInforUser";
            this.panelInforUser.Size = new System.Drawing.Size(565, 489);
            this.panelInforUser.TabIndex = 45;
            this.panelInforUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInforUser_Paint);
            // 
            // iconPictureClose
            // 
            this.iconPictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(128)))));
            this.iconPictureClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureClose.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureClose.IconSize = 27;
            this.iconPictureClose.Location = new System.Drawing.Point(529, 9);
            this.iconPictureClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconPictureClose.Name = "iconPictureClose";
            this.iconPictureClose.Size = new System.Drawing.Size(27, 27);
            this.iconPictureClose.TabIndex = 38;
            this.iconPictureClose.TabStop = false;
            this.iconPictureClose.Click += new System.EventHandler(this.iconPictureClose_Click);
            // 
            // btnThayPass
            // 
            this.btnThayPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(134)))), ((int)(((byte)(60)))));
            this.btnThayPass.FlatAppearance.BorderSize = 0;
            this.btnThayPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayPass.ForeColor = System.Drawing.Color.White;
            this.btnThayPass.Location = new System.Drawing.Point(143, 400);
            this.btnThayPass.Name = "btnThayPass";
            this.btnThayPass.Size = new System.Drawing.Size(117, 41);
            this.btnThayPass.TabIndex = 37;
            this.btnThayPass.Text = "Đổi mật khẩu";
            this.btnThayPass.UseVisualStyleBackColor = false;
            this.btnThayPass.Click += new System.EventHandler(this.btnThayPass_Click);
            // 
            // btnUpdateThongTin
            // 
            this.btnUpdateThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(134)))), ((int)(((byte)(60)))));
            this.btnUpdateThongTin.FlatAppearance.BorderSize = 0;
            this.btnUpdateThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateThongTin.ForeColor = System.Drawing.Color.White;
            this.btnUpdateThongTin.Location = new System.Drawing.Point(319, 400);
            this.btnUpdateThongTin.Name = "btnUpdateThongTin";
            this.btnUpdateThongTin.Size = new System.Drawing.Size(114, 41);
            this.btnUpdateThongTin.TabIndex = 36;
            this.btnUpdateThongTin.Text = "Cập nhật";
            this.btnUpdateThongTin.UseVisualStyleBackColor = false;
            this.btnUpdateThongTin.Click += new System.EventHandler(this.btnUpdateThongTin_Click);
            // 
            // pbAnhNV
            // 
            this.pbAnhNV.Image = ((System.Drawing.Image)(resources.GetObject("pbAnhNV.Image")));
            this.pbAnhNV.Location = new System.Drawing.Point(45, 73);
            this.pbAnhNV.Name = "pbAnhNV";
            this.pbAnhNV.Size = new System.Drawing.Size(150, 150);
            this.pbAnhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnhNV.TabIndex = 35;
            this.pbAnhNV.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(41, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Thông tin cá nhân";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblVitri
            // 
            this.lblVitri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVitri.AutoSize = true;
            this.lblVitri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitri.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVitri.Location = new System.Drawing.Point(377, 259);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(15, 24);
            this.lblVitri.TabIndex = 5;
            this.lblVitri.Text = " ";
            this.lblVitri.Click += new System.EventHandler(this.lblVitri_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(241, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quyền hạng:";
            // 
            // lblSoDT
            // 
            this.lblSoDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSoDT.Location = new System.Drawing.Point(377, 164);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(15, 24);
            this.lblSoDT.TabIndex = 5;
            this.lblSoDT.Text = " ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(262, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Điện thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(377, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(15, 24);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = " ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDiaChi.Location = new System.Drawing.Point(377, 309);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(15, 24);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = " ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(299, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(289, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa chỉ:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGioiTinh.Location = new System.Drawing.Point(377, 119);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(15, 24);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = " ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(278, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Giới tính:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTenNV.Location = new System.Drawing.Point(377, 73);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(15, 24);
            this.lblTenNV.TabIndex = 5;
            this.lblTenNV.Text = " ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(289, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ tên:";
            // 
            // FormThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(565, 489);
            this.Controls.Add(this.panelInforUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongTin";
            this.Load += new System.EventHandler(this.FormThongTin_Load);
            this.panelInforUser.ResumeLayout(false);
            this.panelInforUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInforUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureClose;
        private System.Windows.Forms.Button btnThayPass;
        private System.Windows.Forms.Button btnUpdateThongTin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVitri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbAnhNV;
    }
}