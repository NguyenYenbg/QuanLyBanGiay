using QLBanGiay.XuLy.DataProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay.Forms.HoaDon
{
    public partial class LocHoaDon : Form
    {
        FormHoaDon fHoaDon;
        HoaDonDPro hoaDonDPro = new HoaDonDPro();
        public LocHoaDon()
        {
            InitializeComponent();           
        }
        public LocHoaDon(FormHoaDon f)
        {
            InitializeComponent();
            //Form: xoá hộp điều khiển
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            fHoaDon = f;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                var tuNgay = dtpTuNgay.Value;
                var denNgay = dtpDenNgay.Value;
                if (DateTime.Compare(tuNgay, denNgay) > 0)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                    return;
                }
                DataTable dt = hoaDonDPro.locHD(tuNgay, denNgay);                
                fHoaDon.loadData(dt);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
