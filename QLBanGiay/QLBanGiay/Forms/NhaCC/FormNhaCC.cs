using QLBanGiay.Forms.NhaCC;
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
    public partial class FormNhaCC : Form
    {
        NhaCCDPro nhaCCDPro = new NhaCCDPro();
        NhanVienDPro nhanVienDPro = new NhanVienDPro();
        int d;
        int maNV;
        public FormNhaCC(int ma)
        {
            InitializeComponent();
            maNV = ma;
        }    
        
        public void loadData()
        {
            DataTable dt = nhaCCDPro.showNhaCC();
            dgvNhaCC.DataSource = dt;
        }

        private void FormNhaCC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void iconBtnThem_Click(object sender, EventArgs e)
        {
            ThemNhaCC themNCC = new ThemNhaCC(this);
            themNCC.ShowDialog();
        }

        private void iconbtnSua_Click(object sender, EventArgs e)
        {
            if (d >= 0 && d < dgvNhaCC.Rows.Count && dgvNhaCC.Rows[d].Cells[0].Value.ToString() != null)
            {
                SuaNhaCC suaKH = new SuaNhaCC(this);
                suaKH.hienThi(dgvNhaCC.Rows[d].Cells[0].Value.ToString(), dgvNhaCC.Rows[d].Cells[1].Value.ToString(),
                    dgvNhaCC.Rows[d].Cells[2].Value.ToString(), dgvNhaCC.Rows[d].Cells[3].Value.ToString());
                suaKH.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconBtnXoa_Click(object sender, EventArgs e)
        {
            if (d >= 0 && d < dgvNhaCC.Rows.Count)
            {
                if (nhanVienDPro.getViTri(maNV) == 0)
                {
                    MessageBox.Show("Bạn không có quyền xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(new SanPhamDPro().getSanPham_maNhaCC(int.Parse(dgvNhaCC.Rows[d].Cells[0].Value.ToString())) <= 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        nhaCCDPro.DeleteNhaCC(Int32.Parse(dgvNhaCC.Rows[d].Cells[0].Value.ToString()));
                        d = -1;
                        loadData();
                    }
                }
                else
                {
                    XoaNhaCC xoaNhaCC = new XoaNhaCC(dgvNhaCC.Rows[d].Cells[0].Value.ToString());
                    xoaNhaCC.ShowDialog();
                    d = -1;
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            iconbtnSua.Enabled = true;
            iconBtnXoa.Enabled = true;
        }

        private void iconBtnReload_Click(object sender, EventArgs e)
        {
            loadData();
            txtTimKiem.Clear();
        }

        private void iconPictureTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = nhaCCDPro.Search(txtTimKiem.Text);
            dgvNhaCC.DataSource = dt;
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "  Nhập tên NCC ...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "  Nhập tên NCC ...";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }
    }
}
