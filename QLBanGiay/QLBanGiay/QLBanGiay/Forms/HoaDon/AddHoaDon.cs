using QLBanGiay.DTO;
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

namespace QLBanGiay.Forms.HoaDon
{
    public partial class AddHoaDon : Form
    {
        int maNV;
        common commonMethod = new common();
        FormHoaDon fHoaDon;
        List<ChiTietHoaDonDTO> chiTietHoaDonDTOs = new List<ChiTietHoaDonDTO>();
        KhachHangDPro khachHangDPro = new KhachHangDPro();
        ChiTietHoaDonDPro chiTietHoaDonDPro = new ChiTietHoaDonDPro();
        KhachHangsDTO kh = new KhachHangsDTO();
        HoaDonDPro hoaDonDPro = new HoaDonDPro();
        HoaDonsDTO hoaDonsDTO = new HoaDonsDTO();
        int tongTien = 0;
        int d;

        public AddHoaDon()
        {
            InitializeComponent();
        }
        public AddHoaDon(FormHoaDon f, int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.fHoaDon = f;
        }

        
        private void AddHoaDon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            NhanVienDPro nhanVienDPro = new NhanVienDPro();
            DataTable dt = nhanVienDPro.searchMa(maNV);
            lblNhanVien.Text = nhanVienDPro.searchMa(maNV).Rows[0].ItemArray[0].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddSPtoHD addSPtoHD = new AddSPtoHD(this);
            addSPtoHD.ShowDialog();
        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }
        private void iconPictureMaximize_Click(object sender, EventArgs e)
        {
            commonMethod.MaximizeForm(this);
        }

        public void addSP_to_HD(int maSP, string tenSP, int slBan, int giaSP)
        {
            ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();
            chiTietHoaDonDTO.MaSP = maSP;
            chiTietHoaDonDTO.TenSP = tenSP;
            chiTietHoaDonDTO.SLBan = slBan;
            chiTietHoaDonDTO.GiaSP = giaSP;
            chiTietHoaDonDTOs.Add(chiTietHoaDonDTO);
            tongTien += (slBan * giaSP);
            lblTongTien.Text = tongTien.ToString();
        }
        public void hienThi()
        {
            dgvSPMua.Rows.Clear();
            dgvSPMua.Rows.Add();
            for(int i=0; i < chiTietHoaDonDTOs.Count; i++)
            {
                dgvSPMua.Rows[i].Cells[0].Value = chiTietHoaDonDTOs[i].MaSP;
                dgvSPMua.Rows[i].Cells[1].Value = chiTietHoaDonDTOs[i].TenSP;
                dgvSPMua.Rows[i].Cells[2].Value = chiTietHoaDonDTOs[i].SLBan;
                dgvSPMua.Rows[i].Cells[3].Value = chiTietHoaDonDTOs[i].GiaSP;
                dgvSPMua.Rows[i].Cells[4].Value = chiTietHoaDonDTOs[i].SLBan * chiTietHoaDonDTOs[i].GiaSP;
                dgvSPMua.Rows.Add();               
            }
        }

        private void dgvSPMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                tongTien -= chiTietHoaDonDTOs[d].GiaSP;
                chiTietHoaDonDTOs.RemoveAt(d);
                d = -1;
                lblTongTien.Text = tongTien.ToString();
                hienThi();
            }
            catch (Exception )
            {
                MessageBox.Show("Chọn 1 sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconBtnCheckKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoDTKH.Text.Trim().Equals(""))
                {
                    txtSoDTKH.Focus();
                    throw new Exception("Số điện thoại không được để trống");
                }
                if (!UInt64.TryParse(txtSoDTKH.Text, out UInt64 o))
                {
                    txtSoDTKH.Focus();
                    throw new Exception("Số điện thoại phải là số !");
                }

                Int64 sdt = Int64.Parse(txtSoDTKH.Text);
                if (!khachHangDPro.getSDT(sdt))
                {
                    throw new Exception("Số điện thoại chưa tồn tại !");
                }
                else
                {
                    DataTable dt = khachHangDPro.SearchSDT(sdt);
                    txtTenKH.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtDiaChi.Text = dt.Rows[0].ItemArray[3].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoDTKH.Text.Trim().Equals(""))
                {
                    txtSoDTKH.Focus();
                    throw new Exception("Số điện thoại không được để trống");
                }
                if (!UInt64.TryParse(txtSoDTKH.Text, out UInt64 o))
                {
                    txtSoDTKH.Focus();
                    throw new Exception("Số điện thoại phải là số !");
                }
                if (txtTenKH.Text.Trim().Equals(""))
                {
                    txtSoDTKH.Focus();
                    throw new Exception("Tên khách hàng không được để trống");
                }
                if (txtDiaChi.Text.Trim().Equals(""))
                {
                    txtSoDTKH.Focus();
                    throw new Exception("Địa chỉ không được để trống");
                }
                /*
                if (dgvSPMua.DataSource == null)
                {
                    throw new Exception("Bạn vui lòng chọn sản phẩm ");
                }
                */

                kh.TenKH = txtTenKH.Text;
                kh.SDT = Int64.Parse(txtSoDTKH.Text);
                kh.DiaChi = txtDiaChi.Text;
                
                //nếu sdt chưa tồn tại thì thêm vào csdl
                if (!khachHangDPro.getSDT(kh.SDT))
                {
                    khachHangDPro.InsertKhachHang(kh.TenKH, kh.SDT, kh.DiaChi);
                }
               
                //lấy ra mã khách hàng
                DataTable dtKH = khachHangDPro.SearchSDT(kh.SDT);
                kh.MaKH = int.Parse(dtKH.Rows[0].ItemArray[0].ToString());

                //add hóa đơn
                hoaDonDPro.InsertHoaDon(kh.MaKH, maNV);
                //lấy ra mã hóa đơn
                int maHD = hoaDonDPro.getMaHD();

                //add chi tiết hóa đơn
                //duyệt lần lượt danh sách chi tiết HĐ và add vào bảng CTHoaDon
                foreach (ChiTietHoaDonDTO cthd in chiTietHoaDonDTOs)
                {
                    chiTietHoaDonDPro.InsertCTHoaDon(maHD, cthd.MaSP, cthd.SLBan);
                }
                fHoaDon.loadData();
                MessageBox.Show("Hóa đơn của bạn đã được tạo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
