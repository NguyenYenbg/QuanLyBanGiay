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
namespace QLBanGiay.Forms.NhanVien
{
    public partial class SuaNhanVien : Form
    {
        common commonMethod = new common();
        FormNhanVien FormnhanVien;
        public SuaNhanVien()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public SuaNhanVien(FormNhanVien f)
        {
            InitializeComponent();
            FormnhanVien = f;

        }
        private void SuaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }
    }
}
