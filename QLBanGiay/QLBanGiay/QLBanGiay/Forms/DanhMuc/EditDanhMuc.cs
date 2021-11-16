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
namespace QLBanGiay.Forms.DanhMuc
{
    public partial class EditDanhMuc : Form
    {
        common commonMethod = new common();
        FormDanhMuc FormdanhMuc;

        common commomMethodFn = new common();
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
    }
}
