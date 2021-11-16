using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.DTO;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay.Forms.DanhMuc
{
    public partial class DeleteConfirm : Form
    {
        string maDM;
        int t;
        public DeleteConfirm()
        {
            InitializeComponent();
        }
        public DeleteConfirm(string z)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            maDM = z;
            loadData();
        }
        public void loadData()
        {
            List<DanhMucsDTO> danhmuc = new DanhMucBLL().danhMuc();
            for (int i = 0; i < danhmuc.Count; i++)
            {
                if (int.Parse(maDM) != danhmuc[i].maDM)
                {
                    cbb_danhMuc.Items.Add(danhmuc[i].tenDM);
                }
            }
            t = cbb_danhMuc.Items.Count;
            if (t > 0)
                cbb_danhMuc.SelectedIndex = 0;
        }

        private void DeleteConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && t == 0)
            {
                MessageBox.Show("Không còn danh mục nào khác để chuyển!");
                radioButton1.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked)
                {
                    new DanhMucBLL().DeleteDanhMuc(Int32.Parse(maDM));
                }
                else
                {
                    new SanPhamDPro().ChangeDanhMuc(new DanhMucBLL().getID(cbb_danhMuc.Text),Int32.Parse(maDM));
                    new DanhMucBLL().DeleteDanhMuc(Int32.Parse(maDM));
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }
    }
}
