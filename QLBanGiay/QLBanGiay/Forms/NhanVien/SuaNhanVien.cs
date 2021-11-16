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
using QLBanGiay.XuLy.DataProcessing;
using QLBanGiay.Databases;
using QLBanGiay.DTO;
using QLBanGiay.Forms.ThongTinUser;
namespace QLBanGiay.Forms.NhanVien
{
    public partial class SuaNhanVien : Form
    {
        common commonMethod = new common();
        NhanVienDPro NhanVienDPro = new NhanVienDPro();
        int maUser;

        FormThongTin f;
        DataRow row;
        public SuaNhanVien()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public SuaNhanVien(FormThongTin f, int userid, DataTable r)
        {
            InitializeComponent();
            this.f = f;
            this.row = r.Rows[0];

        }
        private void SuaNhanVien_Load(object sender, EventArgs e)
        {

            hienthi();
        }
        public void hienthi()
        {
            txtTaiKhoan.Text = row.ItemArray[1].ToString();
            txtHoTen.Text = row.ItemArray[3].ToString();
            //string avatalink = NhanVienBLL.imageLink(int.Parse(row.ItemArray[0].ToString()));
            //pbAnhNV.Image = Image.FromFile(avatalink);
            string avatarLink = row.ItemArray[4].ToString();
            if (!avatarLink.Equals(""))
                pbAnhNV.Image = Image.FromFile(avatarLink);
            openFileDialog1.FileName = avatarLink;
          
            cbbGioiTinh.Text = row.ItemArray[5].ToString();
            txtSoDT.Text = row.ItemArray[6].ToString();
            txtDiaChi.Text = row.ItemArray[7].ToString();
            txtEmail.Text = row.ItemArray[8].ToString();
            if (row.ItemArray[9].ToString() == "1")
            {
                cbbQuyenHan.Text = "Admin";
            }
            else
            {
                cbbQuyenHan.Text = "Employee";

            }
        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

       
      
        

       

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtSoDT.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string imagelink = openFileDialog1.FileName;
                int vitri;
                if (cbbQuyenHan.Text == "Admin")
                {
                    vitri = 1;
                }
                else
                {
                    vitri = 2;
                }
                NhanVienDPro.UpdateNhanVien(int.Parse(row.ItemArray[0].ToString()), txtTaiKhoan.Text, txtHoTen.Text, imagelink, cbbGioiTinh.Text, int.Parse(txtSoDT.Text), txtDiaChi.Text, txtEmail.Text, vitri);
                f.hienthi();
                this.Close();
                //NhanVienDPro.UpdateNhanVien(int.Parse(row.ItemArray[0].ToString()), txtTaiKhoan.Text, txtHoTen.Text, openFileDialog1.FileName, cbbGioiTinh.Text, Int32.Parse(txtSoDT.Text), txtDiaChi.Text, txtEmail.Text, role);
                // f.hienthi();
                // this.Close();
            }
        }

        private void btnAddAvatar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"C:\";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog1.FileName);
                pbAnhNV.Image = img;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
