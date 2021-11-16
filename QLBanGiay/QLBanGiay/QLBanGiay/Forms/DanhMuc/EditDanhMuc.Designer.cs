
namespace QLBanGiay.Forms.DanhMuc
{
    partial class EditDanhMuc
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
            this.btnSua = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnSua = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 638);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 564);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Location = new System.Drawing.Point(596, 394);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 52);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(471, 291);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 42);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtHoTen.Location = new System.Drawing.Point(471, 169);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(506, 42);
            this.txtHoTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên danh mục";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(420, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập nhật danh mục sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.iconPictureClose);
            this.panel2.Controls.Add(this.iconPictureMaximize);
            this.panel2.Controls.Add(this.iconPictureMinimize);
            this.panel2.Controls.Add(this.iconbtnSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 74);
            this.panel2.TabIndex = 2;
            // 
            // iconPictureClose
            // 
            this.iconPictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(128)))));
            this.iconPictureClose.ForeColor = System.Drawing.Color.DarkRed;
            this.iconPictureClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconPictureClose.IconColor = System.Drawing.Color.DarkRed;
            this.iconPictureClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureClose.IconSize = 38;
            this.iconPictureClose.Location = new System.Drawing.Point(1175, 8);
            this.iconPictureClose.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureClose.Name = "iconPictureClose";
            this.iconPictureClose.Size = new System.Drawing.Size(38, 38);
            this.iconPictureClose.TabIndex = 10;
            this.iconPictureClose.TabStop = false;
            this.iconPictureClose.Click += new System.EventHandler(this.iconPictureClose_Click);
            // 
            // iconPictureMaximize
            // 
            this.iconPictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(128)))));
            this.iconPictureMaximize.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconPictureMaximize.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureMaximize.IconSize = 38;
            this.iconPictureMaximize.Location = new System.Drawing.Point(1129, 8);
            this.iconPictureMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureMaximize.Name = "iconPictureMaximize";
            this.iconPictureMaximize.Size = new System.Drawing.Size(38, 38);
            this.iconPictureMaximize.TabIndex = 9;
            this.iconPictureMaximize.TabStop = false;
            this.iconPictureMaximize.Click += new System.EventHandler(this.iconPictureMaximize_Click);
            // 
            // iconPictureMinimize
            // 
            this.iconPictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(128)))));
            this.iconPictureMinimize.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureMinimize.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureMinimize.IconSize = 38;
            this.iconPictureMinimize.Location = new System.Drawing.Point(1083, 8);
            this.iconPictureMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureMinimize.Name = "iconPictureMinimize";
            this.iconPictureMinimize.Size = new System.Drawing.Size(38, 38);
            this.iconPictureMinimize.TabIndex = 6;
            this.iconPictureMinimize.TabStop = false;
            this.iconPictureMinimize.Click += new System.EventHandler(this.iconPictureMinimize_Click);
            // 
            // iconbtnSua
            // 
            this.iconbtnSua.FlatAppearance.BorderSize = 0;
            this.iconbtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSua.ForeColor = System.Drawing.Color.Black;
            this.iconbtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnSua.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconbtnSua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnSua.IconSize = 35;
            this.iconbtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.Location = new System.Drawing.Point(8, 4);
            this.iconbtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnSua.Name = "iconbtnSua";
            this.iconbtnSua.Size = new System.Drawing.Size(266, 56);
            this.iconbtnSua.TabIndex = 8;
            this.iconbtnSua.Text = "Sửa danh mục";
            this.iconbtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnSua.UseVisualStyleBackColor = true;
            // 
            // EditDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1223, 643);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDanhMuc";
            this.Load += new System.EventHandler(this.EditDanhMuc_Load);
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
        private FontAwesome.Sharp.IconButton iconbtnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSua;
        private FontAwesome.Sharp.IconPictureBox iconPictureMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureMaximize;
        private FontAwesome.Sharp.IconPictureBox iconPictureClose;
    }
}