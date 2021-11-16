using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.Forms.NhanVien;
using QLBanGiay.DTO;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay.Forms
{
    public partial class FormNhanVien : Form
    {
        NhanVienDPro NhanVienDPro = new NhanVienDPro();
        int idUser;
        int d;
        DataTable user;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public FormNhanVien(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            user = NhanVienDPro.getNhanVienByMaNV(idUser);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (NhanVienDPro.getNhanVienByMaNV(idUser).Rows[0].ItemArray[9].ToString() == "1")
            {
                AddNhanVien f = new AddNhanVien(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            hienthi();
            txtSearch.Clear();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            List<NhanViensDTO> dt = NhanVienDPro.ShowNhanVien();
            dgvNhanVien.DataSource = dt;
            // fLogin f = new fLogin();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if (d >= 0 && d < dgvNhanVien.Rows.Count)
            {
                if (user.Rows[0].ItemArray[9].ToString().Equals("1") && idUser != int.Parse(dgvNhanVien.Rows[d].Cells[0].Value.ToString()) && d >= 0)
                {
                    NhanVienDPro.DeleteNhanVien(int.Parse(dgvNhanVien.Rows[d].Cells[0].Value.ToString()));
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xoa", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<NhanViensDTO> table = NhanVienDPro.search(txtSearch.Text);

            dgvNhanVien.DataSource = table;
        }

        private void txtSearchNV_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "  Nhập tên nhân viên ...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearchNV_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "  Nhập tên nhân viên ...";
                txtSearch.ForeColor = Color.DarkGray;
            }
        }
    }
}
