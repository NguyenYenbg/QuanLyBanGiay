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
namespace QLBanGiay.Forms
{
    public partial class FormDanhMuc : Form
    {
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDanhMuc f = new AddDanhMuc(this);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditDanhMuc f = new EditDanhMuc(this);
            f.ShowDialog();
        }
    }
}
