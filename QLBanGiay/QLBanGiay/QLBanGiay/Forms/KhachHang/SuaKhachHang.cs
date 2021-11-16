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

namespace QLBanGiay.Forms.KhachHang
{
    public partial class SuaKhachHang : Form
    {
        common commonMethod = new common();
        FormKhachHang fKhachHang;
        KhachHangDPro khachHangDPro = new KhachHangDPro();
        public SuaKhachHang()
        {
            InitializeComponent();
            //Form: xoá hộp điều khiển
            this.Text = string.Empty; 
            this.ControlBox = false;  
            this.DoubleBuffered = true; 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public SuaKhachHang(FormKhachHang f)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            fKhachHang = f;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Trim().Equals(""))
                {
                    txtHoTen.Focus();
                    throw new Exception("Họ tên không được để trống !");

                }
                if (txtSoDT.Text.Trim().Equals(""))
                {
                    throw new Exception("Số điện thoại không được để trống !");
                }
                if (!UInt64.TryParse(txtSoDT.Text, out UInt64 o))
                {
                    throw new Exception("Số điện thoại phải là số !");
                }    
                if (txtDiaChi.Text.Trim().Equals(""))
                {
                    throw new Exception("Địa chỉ không được để trống !");
                }

                khachHangDPro.UpdateKhachHang(Int32.Parse(txtMa.Text),txtHoTen.Text,Int64.Parse(txtSoDT.Text),txtDiaChi.Text);
                fKhachHang.loadData();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void hienThi(string ma, string ten, string sdt,string diachi)
        {
            txtMa.Text = ma;
            txtHoTen.Text = ten;
            txtSoDT.Text = sdt;
            txtDiaChi.Text = diachi;

        }
    }
}
