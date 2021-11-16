using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.XuLy;
using QLBanGiay.DTO;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay.Forms.ThongTinUser
{
    public partial class FormThayPass : Form
    {
        FormThongTin f;
        int MaNV;
        common com = new common();
        NhanVienDPro NhanVienDPro = new NhanVienDPro();
        public FormThayPass()
        {
            InitializeComponent();
        }
        public FormThayPass(FormThongTin f, int id)

        {
            InitializeComponent();
            this.f = f;
            this.MaNV = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMKM.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKM.Focus();
            }
            else if (txtMKM.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // txtNhapLai.Focus();
            }
            else
            {
                NhanVienDPro.UpdatePassByMaNV(MaNV, txtMKM.Text);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.hienthi();
                this.Close();
            }
        }
    }
}
