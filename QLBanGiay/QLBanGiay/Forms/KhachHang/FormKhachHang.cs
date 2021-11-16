using QLBanGiay.DTO;
using QLBanGiay.Forms.KhachHang;
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
    public partial class FormKhachHang : Form
    {
        KhachHangDPro khachHangDPro = new KhachHangDPro();
        List<KhachHangsDTO> khachHangs = new List<KhachHangsDTO>();
        NhanVienDPro nhanVienDPro = new NhanVienDPro();
        int d;
        int maNV;
        public FormKhachHang(int ma)
        {
            InitializeComponent();
            maNV = ma;
        }

        public void loadData()
        {
            DataTable dt = khachHangDPro.showKhachHang();
            dgvKhachHang.DataSource = dt;
        }
        public void add_KhachHang(int maKH, string tenKH, Int64 soDT, string diaChi)
        {
            KhachHangsDTO khachHang = new KhachHangsDTO();
            khachHang.MaKH = maKH;
            khachHang.TenKH = tenKH;
            khachHang.SDT = soDT;
            khachHang.DiaChi = diaChi;
            khachHangs.Add(khachHang);
        }
        public void hienThi()
        {
            dgvKhachHang.Rows.Clear();
            dgvKhachHang.Rows.Add();
            for(int i=0; i<khachHangs.Count; i++)
            {
                dgvKhachHang.Rows[i].Cells[0].Value = khachHangs[i].MaKH;
                dgvKhachHang.Rows[i].Cells[1].Value = khachHangs[i].TenKH;
                dgvKhachHang.Rows[i].Cells[2].Value = khachHangs[i].SDT;
                dgvKhachHang.Rows[i].Cells[3].Value = khachHangs[i].DiaChi;
                dgvKhachHang.Rows.Add();
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            iconbtnSua.Enabled = true;
            iconBtnXoa.Enabled = true;
        }

        private void iconBtnThem_Click(object sender, EventArgs e)
        {
            ThemKhachHang themKH = new ThemKhachHang(this);
            themKH.ShowDialog();
        }

        private void iconbtnSua_Click(object sender, EventArgs e)
        {
            if(d>=0 && d< dgvKhachHang.Rows.Count && dgvKhachHang.Rows[d].Cells[0].Value.ToString() != null)
            {
                SuaKhachHang suaKH = new SuaKhachHang(this);
                suaKH.hienThi(dgvKhachHang.Rows[d].Cells[0].Value.ToString(), dgvKhachHang.Rows[d].Cells[1].Value.ToString(), 
                    dgvKhachHang.Rows[d].Cells[2].Value.ToString(), dgvKhachHang.Rows[d].Cells[3].Value.ToString());
                suaKH.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void iconBtnXoa_Click(object sender, EventArgs e)
        {
            if(d>=0 && d < dgvKhachHang.Rows.Count)
            {
                if (nhanVienDPro.getViTri(maNV) == 0)
                {
                    MessageBox.Show("Bạn không có quyền xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    khachHangDPro.DeleteKhachHang(Int32.Parse(dgvKhachHang.Rows[d].Cells[0].Value.ToString()));
                    d = -1;
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconBtnReload_Click(object sender, EventArgs e)
        {
            loadData();
            txtTimKiem.Clear();
        }

        private void iconPictureTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = khachHangDPro.Search(txtTimKiem.Text);
            dgvKhachHang.DataSource = dt;
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if(txtTimKiem.Text== "  Nhập tên khách hàng ...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "  Nhập tên khách hàng ...";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }
    }
}
