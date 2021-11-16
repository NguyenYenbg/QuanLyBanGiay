using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.Forms.SanPham;
using QLBanGiay.DTO;
using QLBanGiay.Databases;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay.Forms
{
    public partial class FormSanPham : Form
    {
        SanPhamDPro SanPhamDPro = new SanPhamDPro();
        int d;
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hienthi();
            txtSearch.Clear();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddSanPham f = new AddSanPham(this);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaSanPham f = new SuaSanPham(this,d,dgvSanPham.Rows[d]);
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            List<SanPhamsDTO> table = SanPhamDPro.ShowSanPham();
            dgvSanPham.DataSource = table;
        }

      
        //luc view len datagrievew sẽ chuyen mã màu thành màu
        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (d >= 0 && d < dgvSanPham.Rows.Count)
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SanPhamDPro.DeleteSanPham(Int32.Parse(dgvSanPham.Rows[d].Cells[0].Value.ToString()));
                    d = -1;
                    hienthi();
                }
            }
            else
            {
                MessageBox.Show("Phải chọn một dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
        }

        private void dgvSanPham_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                string[] color = dgvSanPham.Rows[i].Cells[5].Value.ToString().Trim('"').Split(',').ToArray();
                dgvSanPham.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                dgvSanPham.Rows[i].Cells[5].Style.ForeColor = Color.Transparent;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SanPhamsDTO> table = SanPhamDPro.search(txtSearch.Text);
            dgvSanPham.DataSource = table;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "  Nhập tên sản phẩm ...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "  Nhập tên sản phẩm ...";
                txtSearch.ForeColor = Color.DarkGray;
            }
        }
    }
}
