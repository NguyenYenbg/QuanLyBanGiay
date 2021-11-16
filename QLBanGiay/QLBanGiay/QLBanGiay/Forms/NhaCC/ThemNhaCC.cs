using QLBanGiay.XuLy;
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

namespace QLBanGiay.Forms.NhaCC
{
    public partial class ThemNhaCC : Form
    {
        common commonMethod = new common();
        FormNhaCC fNhaCC;
        NhaCCDPro nhaCCDPro=new NhaCCDPro();
        public ThemNhaCC()
        {
            InitializeComponent();
            //Form: xoá hộp điều khiển
            this.Text = string.Empty;   
            this.ControlBox = false;  
            this.DoubleBuffered = true; 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public ThemNhaCC(FormNhaCC f)
        {
            InitializeComponent();
            //Form: xoá hộp điều khiển
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            fNhaCC = f;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void ThemNhaCC_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNCC.Text.Trim().Equals(""))
                {
                    txtTenNCC.Focus();
                    throw new Exception("Tên không được để trống");
                }
                if (txtSoDT.Text.Trim().Equals(""))
                {
                    txtSoDT.Focus();
                    throw new Exception("Số điện thoại không được để trống");
                }
                if (!UInt64.TryParse(txtSoDT.Text, out UInt64 o))
                {
                    txtSoDT.Focus();
                    throw new Exception("Số điện thoại phải là số !");
                }
                if (txtDiaChi.Text.Trim().Equals(""))
                {
                    txtDiaChi.Focus();
                    throw new Exception("Địa chỉ không được để trống");
                }

                nhaCCDPro.InsertNhaCC(txtTenNCC.Text, Int64.Parse(txtSoDT.Text), txtDiaChi.Text);
                fNhaCC.loadData();
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
