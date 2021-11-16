using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.Forms.DanhMuc;

using QLBanGiay.XuLy.DataProcessing;

namespace QLBanGiay.Forms
{
    public partial class FormDanhMuc : Form
    {
        DanhMucBLL DanhMucBLL = new DanhMucBLL();
        int d;

        public FormDanhMuc()
        {
            InitializeComponent();
        }

        public void hienthi()
        {
            DataTable table = DanhMucBLL.ShowDanhMuc();
            dgvDanhMuc.DataSource = table;
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDanhMuc f = new AddDanhMuc(this);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(d>=0 && d<dgvDanhMuc.Rows.Count && dgvDanhMuc.Rows[d].Cells[0].Value.ToString()!=null)
            {
                EditDanhMuc f = new EditDanhMuc(this);
                f.hienthi(dgvDanhMuc.Rows[d].Cells[0].Value.ToString(),dgvDanhMuc.Rows[d].Cells[1].Value.ToString(), dgvDanhMuc.Rows[d].Cells[2].Value.ToString());
                f.ShowDialog();
            }    
           
            
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            btnXoa.Enabled = true;//Cam nut xoa
            btnSua.Enabled = true;

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hienthi();
            txtSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = DanhMucBLL.search(txtSearch.Text);
            dgvDanhMuc.DataSource = table;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(d>=0 && d< dgvDanhMuc.Rows.Count)
            {
                if(new SanPhamDPro().getSanPhamDanhMuc(Int32.Parse(dgvDanhMuc.Rows[d].Cells[0].Value.ToString()))<=0)
                {
                    DanhMucBLL.DeleteDanhMuc(Int32.Parse(dgvDanhMuc.Rows[d].Cells[0].Value.ToString()));
                    hienthi();
                    d = -1;
                
           }
else
                {
                    DeleteConfirm f = new DeleteConfirm(dgvDanhMuc.Rows[d].Cells[0].Value.ToString());
                    f.ShowDialog();
                    d = -1;
                    hienthi();
                }
           }
            else
           {
                MessageBox.Show("Phải chọn một dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchDm_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "  Nhập tên danh mục ...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearchDm_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "  Nhập tên danh mục ...";
                txtSearch.ForeColor = Color.DarkGray;
            }
        }
    }
}
