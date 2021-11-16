
namespace QLBanGiay.Forms
{
    partial class FormNhaCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureTimKiem = new FontAwesome.Sharp.IconPictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.iconBtnReload = new FontAwesome.Sharp.IconButton();
            this.iconBtnXoa = new FontAwesome.Sharp.IconButton();
            this.iconbtnSua = new FontAwesome.Sharp.IconButton();
            this.iconBtnThem = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhaCC);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 737);
            this.panel1.TabIndex = 1;
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.SDT,
            this.DiaChi});
            this.dgvNhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhaCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            this.dgvNhaCC.Location = new System.Drawing.Point(0, 46);
            this.dgvNhaCC.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.RowHeadersWidth = 51;
            this.dgvNhaCC.RowTemplate.Height = 24;
            this.dgvNhaCC.Size = new System.Drawing.Size(1148, 691);
            this.dgvNhaCC.TabIndex = 1;
            this.dgvNhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCC_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNCC.DefaultCellStyle = dataGridViewCellStyle17;
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 200;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNCC.DefaultCellStyle = dataGridViewCellStyle18;
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 350;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.DefaultCellStyle = dataGridViewCellStyle19;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 250;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle20;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 850;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.iconPictureTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.iconBtnReload);
            this.panel2.Controls.Add(this.iconBtnXoa);
            this.panel2.Controls.Add(this.iconbtnSua);
            this.panel2.Controls.Add(this.iconBtnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 46);
            this.panel2.TabIndex = 0;
            // 
            // iconPictureTimKiem
            // 
            this.iconPictureTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.iconPictureTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureTimKiem.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureTimKiem.IconSize = 34;
            this.iconPictureTimKiem.Location = new System.Drawing.Point(1104, 10);
            this.iconPictureTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureTimKiem.Name = "iconPictureTimKiem";
            this.iconPictureTimKiem.Size = new System.Drawing.Size(42, 34);
            this.iconPictureTimKiem.TabIndex = 2;
            this.iconPictureTimKiem.TabStop = false;
            this.iconPictureTimKiem.Click += new System.EventHandler(this.iconPictureTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.Location = new System.Drawing.Point(820, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 29);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "  Nhập tên NCC ...";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
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
            this.iconBtnReload.Location = new System.Drawing.Point(334, 3);
            this.iconBtnReload.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnReload.Name = "iconBtnReload";
            this.iconBtnReload.Size = new System.Drawing.Size(115, 41);
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
            this.iconBtnXoa.Location = new System.Drawing.Point(226, 3);
            this.iconBtnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnXoa.Name = "iconBtnXoa";
            this.iconBtnXoa.Size = new System.Drawing.Size(80, 41);
            this.iconBtnXoa.TabIndex = 0;
            this.iconBtnXoa.Text = "Xóa";
            this.iconBtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnXoa.UseVisualStyleBackColor = true;
            this.iconBtnXoa.Click += new System.EventHandler(this.iconBtnXoa_Click);
            // 
            // iconbtnSua
            // 
            this.iconbtnSua.Enabled = false;
            this.iconbtnSua.FlatAppearance.BorderSize = 0;
            this.iconbtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSua.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconbtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnSua.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconbtnSua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnSua.IconSize = 35;
            this.iconbtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.Location = new System.Drawing.Point(123, 3);
            this.iconbtnSua.Margin = new System.Windows.Forms.Padding(2);
            this.iconbtnSua.Name = "iconbtnSua";
            this.iconbtnSua.Size = new System.Drawing.Size(80, 41);
            this.iconbtnSua.TabIndex = 0;
            this.iconbtnSua.Text = "Sửa";
            this.iconbtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnSua.UseVisualStyleBackColor = true;
            this.iconbtnSua.Click += new System.EventHandler(this.iconbtnSua_Click);
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
            this.iconBtnThem.Location = new System.Drawing.Point(10, 3);
            this.iconBtnThem.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnThem.Name = "iconBtnThem";
            this.iconBtnThem.Size = new System.Drawing.Size(99, 41);
            this.iconBtnThem.TabIndex = 0;
            this.iconBtnThem.Text = "Thêm";
            this.iconBtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnThem.UseVisualStyleBackColor = true;
            this.iconBtnThem.Click += new System.EventHandler(this.iconBtnThem_Click);
            // 
            // FormNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1148, 737);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNhaCC";
            this.Text = "FormNhaCC";
            this.Load += new System.EventHandler(this.FormNhaCC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton iconBtnReload;
        private FontAwesome.Sharp.IconButton iconBtnXoa;
        private FontAwesome.Sharp.IconButton iconbtnSua;
        private FontAwesome.Sharp.IconButton iconBtnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}