using QLBanGiay.DTO;
using QLBanGiay.Forms.HoaDon;
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

namespace QLBanGiay.Forms
{
    public partial class FormHoaDon : Form
    {
        HoaDonDPro hoaDonDPro = new HoaDonDPro();
        ChiTietHoaDonDPro chiTietHoaDonDPro = new ChiTietHoaDonDPro();
        List<HoaDonsDTO> hoaDonsDTO = new List<HoaDonsDTO>();
        NhanVienDPro nhanVienDPro = new NhanVienDPro();
        int d;
        int maNV;
       
        public FormHoaDon()
        {
            InitializeComponent();           
        }
        public FormHoaDon(int ma)
        {
            InitializeComponent();
            maNV = ma;
        }
        public void loadData()
        {
            DataTable dt = hoaDonDPro.showHoaDon();
            dgvHoaDon.DataSource = dt;
        }
        public void loadData(DataTable dt)
        {
            dgvHoaDon.DataSource = dt;
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            iconbtnXem.Enabled = true;
            iconBtnXoa.Enabled = true;
        }
        
        private void iconBtnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void iconBtnThem_Click(object sender, EventArgs e)
        {
            AddHoaDon addHoaDon = new AddHoaDon(this,maNV);
            addHoaDon.ShowDialog();
        }
        
        private void iconBtnLoc_Click(object sender, EventArgs e)
        {
            LocHoaDon locHD = new LocHoaDon(this);
            locHD.ShowDialog();
        }

        private void iconBtnXoa_Click(object sender, EventArgs e)
        {
            if (d >= 0 && d < dgvHoaDon.Rows.Count)
            {
                if (nhanVienDPro.getViTri(maNV) == 0)
                {
                    MessageBox.Show("Bạn không có quyền xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chiTietHoaDonDPro.deleteCTHoaDon(int.Parse(dgvHoaDon.Rows[d].Cells[0].Value.ToString()));
                    hoaDonDPro.DeleteHoaDon(Int32.Parse(dgvHoaDon.Rows[d].Cells[0].Value.ToString()));
                    d = -1;
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconbtnXem_Click(object sender, EventArgs e)
        {
            if (d >= 0 && d < dgvHoaDon.Rows.Count)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(this,dgvHoaDon.Rows[d]);
                chiTietHoaDon.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
