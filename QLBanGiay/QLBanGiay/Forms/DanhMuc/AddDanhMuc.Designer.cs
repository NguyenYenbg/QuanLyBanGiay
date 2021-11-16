
namespace QLBanGiay.Forms.DanhMuc
{
    partial class AddDanhMuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnThemDM);
            this.panel3.Controls.Add(this.txtMoTa);
            this.panel3.Controls.Add(this.txtTenDM);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 376);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnHuy.Location = new System.Drawing.Point(456, 269);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 39);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemDM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDM.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnThemDM.Location = new System.Drawing.Point(332, 269);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(106, 39);
            this.btnThemDM.TabIndex = 6;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = false;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMoTa.Location = new System.Drawing.Point(288, 208);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(339, 29);
            this.txtMoTa.TabIndex = 5;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTenDM.Location = new System.Drawing.Point(288, 138);
            this.txtTenDM.Multiline = true;
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(339, 29);
            this.txtTenDM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm danh mục sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.iconPictureClose);
            this.panel2.Controls.Add(this.iconPictureMaximize);
            this.panel2.Controls.Add(this.iconPictureMinimize);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 50);
            this.panel2.TabIndex = 2;
            // 
            // iconPictureClose
            // 
            this.iconPictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.iconPictureClose.ForeColor = System.Drawing.Color.DarkRed;
            this.iconPictureClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureClose.IconColor = System.Drawing.Color.DarkRed;
            this.iconPictureClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureClose.IconSize = 25;
            this.iconPictureClose.Location = new System.Drawing.Point(785, 4);
            this.iconPictureClose.Name = "iconPictureClose";
            this.iconPictureClose.Size = new System.Drawing.Size(25, 25);
            this.iconPictureClose.TabIndex = 7;
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
            this.iconPictureMaximize.IconSize = 25;
            this.iconPictureMaximize.Location = new System.Drawing.Point(755, 4);
            this.iconPictureMaximize.Name = "iconPictureMaximize";
            this.iconPictureMaximize.Size = new System.Drawing.Size(25, 25);
            this.iconPictureMaximize.TabIndex = 6;
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
            this.iconPictureMinimize.IconSize = 25;
            this.iconPictureMinimize.Location = new System.Drawing.Point(724, 4);
            this.iconPictureMinimize.Name = "iconPictureMinimize";
            this.iconPictureMinimize.Size = new System.Drawing.Size(25, 25);
            this.iconPictureMinimize.TabIndex = 5;
            this.iconPictureMinimize.TabStop = false;
            this.iconPictureMinimize.Click += new System.EventHandler(this.iconPictureMinimize_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(177, 50);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Thêm danh mục ";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // AddDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(815, 429);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDanhMuc";
            this.Load += new System.EventHandler(this.AddDanhMuc_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureMaximize;
        private FontAwesome.Sharp.IconPictureBox iconPictureClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnHuy;
    }
}