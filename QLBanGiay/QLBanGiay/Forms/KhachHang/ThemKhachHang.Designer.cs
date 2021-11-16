
namespace QLBanGiay.Forms.KhachHang
{
    partial class ThemKhachHang
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
            this.BtnThem = new FontAwesome.Sharp.IconButton();
            this.iconPictureClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnThem
            // 
            this.BtnThem.FlatAppearance.BorderSize = 0;
            this.BtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnThem.IconColor = System.Drawing.Color.White;
            this.BtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnThem.IconSize = 35;
            this.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThem.Location = new System.Drawing.Point(0, 0);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(201, 50);
            this.BtnThem.TabIndex = 1;
            this.BtnThem.Text = "Thêm khách hàng";
            this.BtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThem.UseVisualStyleBackColor = true;
            // 
            // iconPictureClose
            // 
            this.iconPictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.iconPictureClose.ForeColor = System.Drawing.Color.DarkRed;
            this.iconPictureClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureClose.IconColor = System.Drawing.Color.DarkRed;
            this.iconPictureClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureClose.IconSize = 29;
            this.iconPictureClose.Location = new System.Drawing.Point(779, 6);
            this.iconPictureClose.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureClose.Name = "iconPictureClose";
            this.iconPictureClose.Size = new System.Drawing.Size(29, 30);
            this.iconPictureClose.TabIndex = 6;
            this.iconPictureClose.TabStop = false;
            this.iconPictureClose.Click += new System.EventHandler(this.iconPictureClose_Click);
            // 
            // iconPictureMaximize
            // 
            this.iconPictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.iconPictureMaximize.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconPictureMaximize.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureMaximize.IconSize = 29;
            this.iconPictureMaximize.Location = new System.Drawing.Point(749, 6);
            this.iconPictureMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureMaximize.Name = "iconPictureMaximize";
            this.iconPictureMaximize.Size = new System.Drawing.Size(29, 30);
            this.iconPictureMaximize.TabIndex = 5;
            this.iconPictureMaximize.TabStop = false;
            this.iconPictureMaximize.Click += new System.EventHandler(this.iconPictureMaximize_Click);
            // 
            // iconPictureMinimize
            // 
            this.iconPictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.iconPictureMinimize.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureMinimize.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureMinimize.IconSize = 29;
            this.iconPictureMinimize.Location = new System.Drawing.Point(718, 6);
            this.iconPictureMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureMinimize.Name = "iconPictureMinimize";
            this.iconPictureMinimize.Size = new System.Drawing.Size(29, 30);
            this.iconPictureMinimize.TabIndex = 4;
            this.iconPictureMinimize.TabStop = false;
            this.iconPictureMinimize.Click += new System.EventHandler(this.iconPictureMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.iconPictureMinimize);
            this.panel1.Controls.Add(this.iconPictureMaximize);
            this.panel1.Controls.Add(this.iconPictureClose);
            this.panel1.Controls.Add(this.BtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(317, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(158, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(298, 121);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(338, 29);
            this.txtHoTen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(158, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(298, 182);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(338, 29);
            this.txtSoDT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(158, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(298, 241);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(338, 29);
            this.txtDiaChi.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnHuy.Location = new System.Drawing.Point(397, 298);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 42);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btnThemKH);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoDT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 379);
            this.panel2.TabIndex = 1;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemKH.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemKH.Location = new System.Drawing.Point(298, 298);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(94, 42);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(815, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnThem;
        private FontAwesome.Sharp.IconPictureBox iconPictureClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureMaximize;
        private FontAwesome.Sharp.IconPictureBox iconPictureMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemKH;
    }
}