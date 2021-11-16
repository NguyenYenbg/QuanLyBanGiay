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

namespace QLBanGiay.Forms.SanPham
{
    public partial class SuaSanPham : Form
    {
        common commonMethod = new common();
        FormSanPham FormsanPham;
        DanhMucBLL DanhMucBLL = new DanhMucBLL();
        SanPhamDPro SanPhamDPro = new SanPhamDPro();
        NhaCCDPro NhaCCDPro = new NhaCCDPro();
        List<NhaCCsDTO> nhacc = new List<NhaCCsDTO>();
        List<DanhMucsDTO> danhmuc = new List<DanhMucsDTO>();
        string colorpro;
        DataGridViewRow row;
        public SuaSanPham()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public SuaSanPham(FormSanPham f, int d, DataGridViewRow row)

        {
            InitializeComponent();
            FormsanPham = f;
            this.row = row;
        }
     
        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void iconPictureMaximize_Click(object sender, EventArgs e)
        {
            commonMethod.MaximizeForm(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DanhMucBLL.getitem(cbbDanhMuc.Text) == 0 && NhaCCDPro.getitemNCC(cbbNhaCC.Text) == 0)
            {
                MessageBox.Show("Danh mục,NCC không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTenSP.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtMoTa.Text.Trim() == "" || txtGia.Text.Trim() == "")

            {
                MessageBox.Show("Du  lieu không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
            }
            else
            {
                int ID = DanhMucBLL.getID(cbbDanhMuc.Text);
                int maNCC = NhaCCDPro.getmaNCC(cbbNhaCC.Text);
                string imagelink = openFileDialog1.FileName;

                if (SanPhamDPro.getcountitem(txtTenSP.Text) == 0 || txtTenSP.Text == row.Cells[1].Value.ToString())
                {

                    SanPhamDPro.UpdateSanPham(int.Parse(row.Cells[0].Value.ToString()), txtTenSP.Text, openFileDialog1.FileName, Int32.Parse(txtGia.Text), Int32.Parse(cbbKichCo.Text), colorpro, cbbLoaiGiay.SelectedItem.ToString(), Int32.Parse(txtSoLuong.Text), txtMoTa.Text, ID, maNCC);
                    FormsanPham.hienthi();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Trùng tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
        }

        private void SuaSanPham_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            txtTenSP.Text = row.Cells[1].Value.ToString();
            string avatalink = SanPhamDPro.getavalink(int.Parse(row.Cells[0].Value.ToString()));
            try
            {
                pbAnhSP.Image = Image.FromFile(avatalink);
                //img = new Bitmap(@"" + linkAvatar + "");
            }
            catch (Exception)
            {
                //img = new Bitmap(linkAvatar);
                //img = (Bitmap)Image.FromFile(row["avatar"].ToString().Replace("\\", "\\\\"));
                pbAnhSP.Image = Image.FromFile(@"D:\HaUI\he\window\BTL\BTL_QLBanGiay\Giay.jpg");
            }
            //pbAnhSP.Image = (Bitmap)Image.FromFile(avatalink);
            //pbAnhSP.Image = Image.FromFile(avatalink);
            openFileDialog1.FileName = avatalink;

            txtGia.Text = row.Cells[3].Value.ToString();
            cbbKichCo.Text = row.Cells[4].Value.ToString();
            txtMauSac.BackColor = row.Cells[5].Style.BackColor;
            cbbLoaiGiay.Text = row.Cells[6].Value.ToString();
            txtSoLuong.Text = row.Cells[7].Value.ToString();
            txtMoTa.Text = row.Cells[8].Value.ToString();

            colorpro = "" + txtMauSac.BackColor.A + "," + txtMauSac.BackColor.R + "," + txtMauSac.BackColor.G + ", " + txtMauSac.BackColor.B + "";


            this.FormBorderStyle = FormBorderStyle.None;
            List<DanhMucsDTO> danhmuc = DanhMucBLL.danhMuc();
            for (int i = 0; i < danhmuc.Count; i++)
            {
                if (int.Parse(row.Cells[11].Value.ToString()) == danhmuc[i].maDM)
                {
                    cbbDanhMuc.Text = danhmuc[i].tenDM;
                }
                cbbDanhMuc.Items.Add(danhmuc[i].tenDM);
            }
            List<NhaCCsDTO> nhacc = NhaCCDPro.nhaCC();
            for (int i = 0; i < nhacc.Count; i++)
            {
                if (int.Parse(row.Cells[12].Value.ToString()) == nhacc[i].MaNCC)
                {
                    cbbNhaCC.Text = nhacc[i].TenNCC;
                }
                cbbNhaCC.Items.Add(nhacc[i].TenNCC);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"E:\";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog1.FileName);
                pbAnhSP.Image = img;
            }
        }

        private void iconPictureClose_Click_1(object sender, EventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
