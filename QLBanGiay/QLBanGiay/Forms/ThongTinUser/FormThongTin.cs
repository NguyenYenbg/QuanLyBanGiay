using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.Forms.NhanVien;
using QLBanGiay.DTO;
using QLBanGiay.XuLy.DataProcessing;
using QLBanGiay.XuLy;
namespace QLBanGiay.Forms.ThongTinUser
{

    public partial class FormThongTin : Form
    {
        common com = new common();
        DataTable dtUser;
        int idUser;
        NhanVienDPro NhanVienDPro = new NhanVienDPro();
        public FormThongTin()
        {
            InitializeComponent();
        }
        public FormThongTin(int id)
        {
            InitializeComponent();
            idUser = id;
            hienthi();

        }

        //hiển thị tất cả các thông tin của user đăng nhập  tưf bảng nv lên form thôngtinuser
         public void hienthi()
        {
            dtUser = NhanVienDPro.getNhanVienByMaNV(idUser);
            lblTenNV.Text = dtUser.Rows[0].ItemArray[3].ToString();

            if (!dtUser.Rows[0].ItemArray[4].ToString().Equals(""))
            {
                pbAnhNV.Image = Image.FromFile(dtUser.Rows[0].ItemArray[4].ToString());
            }


            lblGioiTinh.Text = dtUser.Rows[0].ItemArray[5].ToString();
            lblSoDT.Text = dtUser.Rows[0].ItemArray[6].ToString();
            lblDiaChi.Text = dtUser.Rows[0].ItemArray[7].ToString();
            lblEmail.Text = dtUser.Rows[0].ItemArray[8].ToString();
            lblVitri.Text = dtUser.Rows[0].ItemArray[9].ToString() == "1" ? "Admin" : "Nhân viên";


        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelInforUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {

        }

        private void lblVitri_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            com.ExitForm(this);
        }

        private void btnUpdateThongTin_Click(object sender, EventArgs e)
        {
            SuaNhanVien SuaNhanVien = new SuaNhanVien(this, idUser, NhanVienDPro.getNhanVienByMaNV(idUser));
            SuaNhanVien.Show();
        }

        private void btnThayPass_Click(object sender, EventArgs e)
        {
            FormThayPass f = new FormThayPass(this, idUser);
            f.ShowDialog();
        }
    }
}
