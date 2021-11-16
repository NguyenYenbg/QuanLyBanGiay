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
namespace QLBanGiay.Forms
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNhanVien f = new AddNhanVien(this);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaNhanVien f = new SuaNhanVien(this);
            f.ShowDialog();
        }
    }
}
