using QLBanGiay.Forms.HoaDon;
using QLBanGiay.XuLy;
using QLBanGiay.XuLy.DataProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay.Forms.DangNhap
{
    public partial class FormDangNhap : Form
    {
        common commonMethod = new common();
        NhanVienDPro nhanVienDPro = new NhanVienDPro();
        public FormDangNhap()
        {
            InitializeComponent();           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string error = "";
            if (txtTaiKhoan.Text == "")
            {
                error = "Tài khoản không được để trống";
            }
            else if (txtMatKhau.Text == "")
            {
                error = "Mật khẩu không được để trống";
            }
 
            if (error == "")
            {
                string username = txtTaiKhoan.Text;
                string password = txtMatKhau.Text;
                if (!nhanVienDPro.getUsernamePassword(username, password))
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FormMainMenu fMainMenu = new FormMainMenu(nhanVienDPro.maNhanVien());
                    this.Hide();
                    fMainMenu.ShowDialog();
                    resetTK();
                    this.Show();
                }

            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetTK()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
