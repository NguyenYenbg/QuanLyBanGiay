
namespace QLBanGiay.Forms.NhaCC
{
    partial class SuaNhaCC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnSua = new FontAwesome.Sharp.IconButton();
            this.iconPictureMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureClose = new FontAwesome.Sharp.IconPictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoDT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTenNCC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 379);
            this.panel2.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnHuy.Location = new System.Drawing.Point(406, 314);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 41);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Location = new System.Drawing.Point(298, 314);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 41);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(298, 264);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(338, 29);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(158, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(298, 205);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(338, 29);
            this.txtSoDT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(158, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Enabled = false;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.ForeColor = System.Drawing.Color.Black;
            this.txtMa.Location = new System.Drawing.Point(298, 86);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(338, 29);
            this.txtMa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(158, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NCC";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.ForeColor = System.Drawing.Color.Black;
            this.txtTenNCC.Location = new System.Drawing.Point(298, 144);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(338, 29);
            this.txtTenNCC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(158, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sửa thông tin nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.iconbtnSua);
            this.panel1.Controls.Add(this.iconPictureMinimize);
            this.panel1.Controls.Add(this.iconPictureMaximize);
            this.panel1.Controls.Add(this.iconPictureClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 50);
            this.panel1.TabIndex = 4;
            // 
            // iconbtnSua
            // 
            this.iconbtnSua.FlatAppearance.BorderSize = 0;
            this.iconbtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSua.ForeColor = System.Drawing.Color.White;
            this.iconbtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnSua.IconColor = System.Drawing.Color.White;
            this.iconbtnSua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnSua.IconSize = 35;
            this.iconbtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.Location = new System.Drawing.Point(0, 0);
            this.iconbtnSua.Margin = new System.Windows.Forms.Padding(2);
            this.iconbtnSua.Name = "iconbtnSua";
            this.iconbtnSua.Size = new System.Drawing.Size(196, 50);
            this.iconbtnSua.TabIndex = 7;
            this.iconbtnSua.Text = "Sửa nhà cung cấp";
            this.iconbtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnSua.UseVisualStyleBackColor = true;
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
            this.iconPictureMinimize.Location = new System.Drawing.Point(718, 5);
            this.iconPictureMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureMinimize.Name = "iconPictureMinimize";
            this.iconPictureMinimize.Size = new System.Drawing.Size(29, 31);
            this.iconPictureMinimize.TabIndex = 4;
            this.iconPictureMinimize.TabStop = false;
            this.iconPictureMinimize.Click += new System.EventHandler(this.iconPictureMinimize_Click);
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
            this.iconPictureMaximize.Location = new System.Drawing.Point(749, 5);
            this.iconPictureMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureMaximize.Name = "iconPictureMaximize";
            this.iconPictureMaximize.Size = new System.Drawing.Size(29, 31);
            this.iconPictureMaximize.TabIndex = 5;
            this.iconPictureMaximize.TabStop = false;
            this.iconPictureMaximize.Click += new System.EventHandler(this.iconPictureMaximize_Click);
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
            this.iconPictureClose.Location = new System.Drawing.Point(779, 5);
            this.iconPictureClose.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureClose.Name = "iconPictureClose";
            this.iconPictureClose.Size = new System.Drawing.Size(29, 31);
            this.iconPictureClose.TabIndex = 6;
            this.iconPictureClose.TabStop = false;
            this.iconPictureClose.Click += new System.EventHandler(this.iconPictureClose_Click);
            // 
            // SuaNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(815, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SuaNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaNhaCC";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureMaximize;
        private FontAwesome.Sharp.IconPictureBox iconPictureClose;
        private FontAwesome.Sharp.IconButton iconbtnSua;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
    }
}