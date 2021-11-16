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

namespace QLBanGiay.Forms.SanPham
{
    public partial class SuaSanPham : Form
    {
        common commonMethod = new common();
        FormSanPham FormsanPham;
        public SuaSanPham()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public SuaSanPham(FormSanPham f)
        {
            InitializeComponent();
            FormsanPham = f;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuaSanPham_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void iconPictureMaximize_Click(object sender, EventArgs e)
        {
            commonMethod.MaximizeForm(this);
        }
    }
}
