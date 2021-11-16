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
    public partial class EditDanhMuc : Form
    {
        common commonMethod = new common();
        FormDanhMuc FormdanhMuc;
        DanhMucBLL DanhMucBLL = new DanhMucBLL();
        common commomMethodFn = new common();
        int ma;
        string basename;
        public EditDanhMuc()
        {
            InitializeComponent();
            this.Text = string.Empty;   //place an empty
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public EditDanhMuc(FormDanhMuc f)
        {
            InitializeComponent();
            FormdanhMuc = f;

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // hiện ttin len text box để thực hiện sửa
        public void hienthi(string m, string ten, string mota )
        {
            ma = Int32.Parse(m);
            txtTenDM.Text = ten;
            basename = ten;
            txtMoTa.Text = mota;
        }
        private void EditDanhMuc_Load(object sender, EventArgs e)
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

        private void iconbtnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDM.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                txtTenDM.Focus();
            }

            else if(DanhMucBLL.getitem(txtTenDM.Text)==0|| txtTenDM.Text==basename)
            {
                DanhMucBLL.UpdateDanhMuc(ma, txtTenDM.Text, txtMoTa.Text);
                FormdanhMuc.hienthi();
                this.Close();
            }
            else
            {
                MessageBox.Show("Trùng tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
