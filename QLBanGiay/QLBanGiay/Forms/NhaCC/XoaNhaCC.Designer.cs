
namespace QLBanGiay.Forms.NhaCC
{
    partial class XoaNhaCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn có chắc chắn muốn xóa?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuyển sản phẩm sang nhà cung cấp:";
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(80, 130);
            this.cbb_NCC.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(201, 28);
            this.cbb_NCC.TabIndex = 5;
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(184, 189);
            this.btn_no.Margin = new System.Windows.Forms.Padding(2);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(97, 41);
            this.btn_no.TabIndex = 7;
            this.btn_no.Text = "Hủy";
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.ForeColor = System.Drawing.Color.White;
            this.btn_yes.Location = new System.Drawing.Point(80, 189);
            this.btn_yes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(97, 41);
            this.btn_yes.TabIndex = 6;
            this.btn_yes.Text = "Xác nhận";
            this.btn_yes.UseVisualStyleBackColor = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // XoaNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(464, 256);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.cbb_NCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "XoaNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaNhaCC";
            this.Load += new System.EventHandler(this.XoaNhaCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_yes;
    }
}