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
    public partial class AddNhanVien : Form
    {
        common commonMethod = new common();
        FormNhanVien FormnhanVien;

        public AddNhanVien()
        {
            InitializeComponent();
            this.ControlBox = false;    //remove the control box
            this.DoubleBuffered = true; //activate double buffer to reduce the flickering
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public AddNhanVien(FormNhanVien f)
        {
            InitializeComponent();
            FormnhanVien = f;

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
