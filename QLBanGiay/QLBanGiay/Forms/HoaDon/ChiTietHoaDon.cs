using QLBanGiay.DTO;
using QLBanGiay.XuLy.DataProcessing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay.Forms.HoaDon
{
    public partial class ChiTietHoaDon : Form
    {
        FormHoaDon fHoaDon;
        int maHD;
        int maKH;
        int maNV;
        DataTable tableKH;
        DataTable tableNV;
        KhachHangDPro khachHangDPro = new KhachHangDPro();
        NhanVienDPro nhanVienDPro = new NhanVienDPro();

        // List<SanPhamsDTO> listSanPham;
        SanPhamDPro sanPhamDPro = new SanPhamDPro();
        ChiTietHoaDonDPro chiTietHoaDonDPro = new ChiTietHoaDonDPro();

        public ChiTietHoaDon()
        {
            InitializeComponent();            
        }

        public ChiTietHoaDon(FormHoaDon f, DataGridViewRow row)
        {
            InitializeComponent();

            //hiển thị thông tin
            this.fHoaDon = f;
            maHD = int.Parse(row.Cells[0].Value.ToString());
            lblMaHD.Text = maHD.ToString();
            lblNgayBan.Text = row.Cells[1].Value.ToString();
            maKH = int.Parse(row.Cells[2].Value.ToString());
            maNV = int.Parse(row.Cells[3].Value.ToString());

            tableKH = khachHangDPro.searchMa(maKH);
            lblTenKH.Text = tableKH.Rows[0].ItemArray[0].ToString();
            lblSDT.Text = tableKH.Rows[0].ItemArray[1].ToString();
            lblDiaChi.Text = tableKH.Rows[0].ItemArray[2].ToString();

            tableNV = nhanVienDPro.searchMa(maNV);
            lblMaNV.Text = maNV.ToString();
            lblTenNV.Text = tableNV.Rows[0].ItemArray[0].ToString();

            //hiển thị sản phẩm
            //listSanPham = sanPhamDPro.ShowSanPham();
            DataTable dtSP = chiTietHoaDonDPro.getCTHoaDonByMa(maHD);
            int d = 0;
            int tongTien = 0;
            int soLuong = 0;
            dgvChiTietHD.Rows.Clear();
            dgvChiTietHD.Rows.Add();
            foreach(DataRow dtr in dtSP.Rows)
            {
                ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();
                chiTietHoaDonDTO.MaSP = int.Parse(dtr.ItemArray[1].ToString());
                chiTietHoaDonDTO.SLBan = int.Parse(dtr.ItemArray[2].ToString());
                dgvChiTietHD.Rows[d].Cells[0].Value = chiTietHoaDonDTO.MaSP;
                DataTable dt = sanPhamDPro.getSanPhamByMa(chiTietHoaDonDTO.MaSP);
                dgvChiTietHD.Rows[d].Cells[1].Value = dt.Rows[0].ItemArray[1].ToString();
                dgvChiTietHD.Rows[d].Cells[2].Value = chiTietHoaDonDTO.SLBan;
                dgvChiTietHD.Rows[d].Cells[3].Value = dt.Rows[0].ItemArray[3].ToString();
                dgvChiTietHD.Rows[d].Cells[4].Value = chiTietHoaDonDTO.SLBan * int.Parse(dt.Rows[0].ItemArray[3].ToString());
                d++;
                dgvChiTietHD.Rows.Add();
                tongTien+= chiTietHoaDonDTO.SLBan * int.Parse(dt.Rows[0].ItemArray[3].ToString());
                soLuong += chiTietHoaDonDTO.SLBan;
            }
            lblTongTien.Text = tongTien.ToString();
            lblsl.Text = soLuong.ToString();

        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            excelApp.Cells[rowIndex, 1] = "Chi tiết hóa đơn";
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Mã hóa đơn: ";
            excelApp.Cells[rowIndex, 2] = lblMaHD.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Ngày bán: ";
            excelApp.Cells[rowIndex, 2] = lblNgayBan.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Tên khách hàng: ";
            excelApp.Cells[rowIndex, 2] = lblTenKH.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Địa chỉ KH: ";
            excelApp.Cells[rowIndex, 2] = lblDiaChi.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Số điện thoại KH: ";
            excelApp.Cells[rowIndex, 2] = lblSDT.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Nhân viên lập HĐ: ";
            excelApp.Cells[rowIndex, 2] = lblTenNV.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Tổng tiền thanh toán: ";
            excelApp.Cells[rowIndex, 2] = lblTongTien.Text;
            rowIndex++;
            //header table
            for (int i = 1; i < dgvChiTietHD.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i] = dgvChiTietHD.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            for (int i = 0; i < dgvChiTietHD.Rows.Count; i++)
            {
                for (int j = 0; j < dgvChiTietHD.Columns.Count; j++)
                {
                    if (dgvChiTietHD.Rows[i].Cells[j].Value != null)
                    {
                        excelApp.Cells[i + rowIndex, j + 1] = dgvChiTietHD.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }

       

        
    }
}
