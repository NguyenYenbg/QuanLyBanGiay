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
using QLBanGiay.Databases;
using System.IO;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay.Forms.SanPham
{
    public partial class AddSanPham : Form
    {
        common commonMethod = new common();
        FormSanPham FormsanPham;
       DanhMucBLL DanhMucBLL = new DanhMucBLL();
        SanPhamDPro SanPhamDPro = new SanPhamDPro();
        NhaCCDPro NhaCCDPro = new NhaCCDPro();
        List<NhaCCsDTO> nhacc = new List<NhaCCsDTO>();

        List<DanhMucsDTO> danhmuc = new List<DanhMucsDTO>();
        string colorpro = "255,255,255,255";
        public AddSanPham()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public AddSanPham(FormSanPham f)
        {
            InitializeComponent();
            FormsanPham = f;
            openFileDialog1.FileName = "";
        }
        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color x = colorDialog1.Color;
            colorpro = "" + x.A + "," + x.R + "," + x.G + ", " + x.B + "";
            txtMauSac.BackColor = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"E:\";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    pbAnhSP.Image = img;
                }
                catch (OutOfMemoryException x)
                {
                    MessageBox.Show("Kích thước ảnh quá lớn");
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DanhMucBLL.getitem(cbbDanhMuc.Text) == 0 && NhaCCDPro.getitemNCC(cbbNhaCC.Text) == 0)
            {
                MessageBox.Show("Danh mục ,Ncc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtTenSP.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtMoTa.Text.Trim() == "" || txtGia.Text.Trim() == "" )
            {
                MessageBox.Show("Du lieu không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
            }


            else
            {
                if (cbbDanhMuc.SelectedItem == null && cbbNhaCC.SelectedItem == null)
                {
                    MessageBox.Show("Chưa chọn danh mục,ncc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbDanhMuc.Focus();
                }
                else
                {
                    int ID = DanhMucBLL.getID(cbbDanhMuc.Text);
                    int maNCC = NhaCCDPro.getmaNCC(cbbNhaCC.Text);
                    if (openFileDialog1.FileName == "")
                    { MessageBox.Show("Cần chọn ảnh đại diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else
                    {
                        try
                        {

                            if (SanPhamDPro.getcountitem(txtTenSP.Text) == 0)
                            {
                                DateTime ngayhomnay = DateTime.Today;
                                SanPhamDPro.InsertSanPham(txtTenSP.Text, openFileDialog1.FileName,
                                    Int32.Parse(txtGia.Text), Int32.Parse(cbbKichCo.Text), colorpro,
                                    cbbLoaiGiay.SelectedItem.ToString(), Int32.Parse(txtSoLuong.Text),
                                    txtMoTa.Text, ngayhomnay.ToString("MM/dd/yyyy"), ID, maNCC);
                                FormsanPham.hienthi();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Trùng tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sai kiểu dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void AddSanPham_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            List<DanhMucsDTO> danhmuc = DanhMucBLL.danhMuc();
            for (int i = 0; i < danhmuc.Count; i++)
            {
                cbbDanhMuc.Items.Add(danhmuc[i].tenDM);
            }
            List<NhaCCsDTO> nhacc = NhaCCDPro.nhaCC();
            for (int i = 0; i < nhacc.Count; i++)
            {
                cbbNhaCC.Items.Add(nhacc[i].TenNCC);
            }

        }

        private void iconPictureClose_Click_1(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
