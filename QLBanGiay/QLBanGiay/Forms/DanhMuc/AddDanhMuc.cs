using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanGiay.XuLy;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay.Forms.DanhMuc
{
  
    public partial class AddDanhMuc : Form
    {
        common commonMethod = new common();
        FormDanhMuc FormdanhMuc;
        DanhMucBLL DanhMucBLL = new DanhMucBLL();
        
        public AddDanhMuc()
        {
            InitializeComponent();
        }
        public AddDanhMuc(FormDanhMuc f)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            FormdanhMuc = f;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDanhMuc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void iconPictureMaximize_Click(object sender, EventArgs e)
        {
            commonMethod.MaximizeForm(this);
        }

        private void iconPictureMinimize_Click(object sender, EventArgs e)
        {
            commonMethod.MinimizeForm(this);
        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            if(txtTenDM.Text.Trim()=="")
            {
                MessageBox.Show("Tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                txtTenDM.Focus();
            }

            else if(DanhMucBLL.getitem(txtTenDM.Text)==0)
            {
                DanhMucBLL.InsertDanhMuc(txtTenDM.Text, txtMoTa.Text);
                FormdanhMuc.hienthi();
                this.Close();
             }
            else
            {
                MessageBox.Show("Trùng tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }
    }
}
