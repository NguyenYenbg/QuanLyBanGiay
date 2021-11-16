
namespace QLBanGiay.Forms
{
    partial class FormHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconBtnReload = new FontAwesome.Sharp.IconButton();
            this.iconBtnXoa = new FontAwesome.Sharp.IconButton();
            this.iconBtnLoc = new FontAwesome.Sharp.IconButton();
            this.iconbtnXem = new FontAwesome.Sharp.IconButton();
            this.iconBtnThem = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 737);
            this.panel1.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.MaKH,
            this.MaNV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 46);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1148, 691);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 350;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 500;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 400;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 400;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.iconBtnReload);
            this.panel2.Controls.Add(this.iconBtnXoa);
            this.panel2.Controls.Add(this.iconBtnLoc);
            this.panel2.Controls.Add(this.iconbtnXem);
            this.panel2.Controls.Add(this.iconBtnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 46);
            this.panel2.TabIndex = 0;
            // 
            // iconBtnReload
            // 
            this.iconBtnReload.FlatAppearance.BorderSize = 0;
            this.iconBtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnReload.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconBtnReload.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconBtnReload.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconBtnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnReload.IconSize = 35;
            this.iconBtnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnReload.Location = new System.Drawing.Point(466, 3);
            this.iconBtnReload.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnReload.Name = "iconBtnReload";
            this.iconBtnReload.Size = new System.Drawing.Size(107, 41);
            this.iconBtnReload.TabIndex = 0;
            this.iconBtnReload.Text = "Reload";
            this.iconBtnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnReload.UseVisualStyleBackColor = true;
            this.iconBtnReload.Click += new System.EventHandler(this.iconBtnReload_Click);
            // 
            // iconBtnXoa
            // 
            this.iconBtnXoa.Enabled = false;
            this.iconBtnXoa.FlatAppearance.BorderSize = 0;
            this.iconBtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnXoa.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconBtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconBtnXoa.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconBtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnXoa.IconSize = 35;
            this.iconBtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnXoa.Location = new System.Drawing.Point(344, 3);
            this.iconBtnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnXoa.Name = "iconBtnXoa";
            this.iconBtnXoa.Size = new System.Drawing.Size(89, 41);
            this.iconBtnXoa.TabIndex = 0;
            this.iconBtnXoa.Text = "Xóa";
            this.iconBtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnXoa.UseVisualStyleBackColor = true;
            this.iconBtnXoa.Click += new System.EventHandler(this.iconBtnXoa_Click);
            // 
            // iconBtnLoc
            // 
            this.iconBtnLoc.FlatAppearance.BorderSize = 0;
            this.iconBtnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnLoc.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconBtnLoc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconBtnLoc.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconBtnLoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLoc.IconSize = 35;
            this.iconBtnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnLoc.Location = new System.Drawing.Point(117, 3);
            this.iconBtnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnLoc.Name = "iconBtnLoc";
            this.iconBtnLoc.Size = new System.Drawing.Size(84, 41);
            this.iconBtnLoc.TabIndex = 0;
            this.iconBtnLoc.Text = "Lọc";
            this.iconBtnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnLoc.UseVisualStyleBackColor = true;
            this.iconBtnLoc.Click += new System.EventHandler(this.iconBtnLoc_Click);
            // 
            // iconbtnXem
            // 
            this.iconbtnXem.Enabled = false;
            this.iconbtnXem.FlatAppearance.BorderSize = 0;
            this.iconbtnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnXem.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconbtnXem.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconbtnXem.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconbtnXem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnXem.IconSize = 35;
            this.iconbtnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnXem.Location = new System.Drawing.Point(224, 3);
            this.iconbtnXem.Margin = new System.Windows.Forms.Padding(2);
            this.iconbtnXem.Name = "iconbtnXem";
            this.iconbtnXem.Size = new System.Drawing.Size(88, 41);
            this.iconbtnXem.TabIndex = 0;
            this.iconbtnXem.Text = "Xem";
            this.iconbtnXem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnXem.UseVisualStyleBackColor = true;
            this.iconbtnXem.Click += new System.EventHandler(this.iconbtnXem_Click);
            // 
            // iconBtnThem
            // 
            this.iconBtnThem.FlatAppearance.BorderSize = 0;
            this.iconBtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnThem.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconBtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnThem.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconBtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnThem.IconSize = 35;
            this.iconBtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThem.Location = new System.Drawing.Point(2, 3);
            this.iconBtnThem.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnThem.Name = "iconBtnThem";
            this.iconBtnThem.Size = new System.Drawing.Size(94, 41);
            this.iconBtnThem.TabIndex = 0;
            this.iconBtnThem.Text = "Thêm";
            this.iconBtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnThem.UseVisualStyleBackColor = true;
            this.iconBtnThem.Click += new System.EventHandler(this.iconBtnThem_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1148, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnReload;
        private FontAwesome.Sharp.IconButton iconBtnXoa;
        private FontAwesome.Sharp.IconButton iconbtnXem;
        private FontAwesome.Sharp.IconButton iconBtnThem;
        private FontAwesome.Sharp.IconButton iconBtnLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}