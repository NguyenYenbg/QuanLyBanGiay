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
using System.IO;
using QLBanGiay.XuLy.DataProcessing;
using QLBanGiay.DTO;

namespace QLBanGiay.Forms.NhanVien
{
    public partial class AddNhanVien : Form
    {
        common commonMethod = new common();
        FormNhanVien FormnhanVien;
        NhanVienDPro NhanVienDPro = new NhanVienDPro();

        public AddNhanVien()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public AddNhanVien(FormNhanVien f)
        {
            InitializeComponent();
            FormnhanVien = f;
            openFileDialog1.FileName = "";

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "" || txtTaiKhoan.Text.Trim()=="" || txtPassword.Text.Trim()=="" || txtEmail.Text.Trim()=="" || txtSoDT.Text.Trim()=="" || txtDiaChi.Text.Trim()=="")

            {
                MessageBox.Show("Tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
            }
            else if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                txtTaiKhoan.Focus();
            }
            else if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Cần chọn ảnh đại diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int viTriNhanVien;
                    if (cbbQuyenHan.Text == "Admin")
                    {
                        viTriNhanVien = 1;
                    }
                    else
                    {
                        viTriNhanVien = 2;
                    }
                    try
                    {
                        DateTime ngayhomnay = DateTime.Today;
                        NhanVienDPro.InsertNhanVien(txtTaiKhoan.Text, txtPassword.Text, txtHoTen.Text, openFileDialog1.FileName, cbbGioiTinh.Text, int.Parse(txtSoDT.Text), txtDiaChi.Text, txtEmail.Text, viTriNhanVien, ngayhomnay.ToString("MM/dd/yyyy"));
                        FormnhanVien.hienthi();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sai kiểu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                     }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai kiểu dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"E:\";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    pbAnhNV.Image = img;
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }

            }
        }

        private void iconPictureClose_Click_1(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void pbAnhNV_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
