using QLBanGiay.DTO;
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

namespace QLBanGiay.Forms.HoaDon
{
    public partial class AddSPtoHD : Form
    {
        common commonMethod = new common();
        AddHoaDon fAddHoaDon;
        List<SanPhamsDTO> dsSP = new List<SanPhamsDTO>();
        SanPhamDPro sanPhamDPro = new SanPhamDPro();
        int t;
        public AddSPtoHD()
        {
            InitializeComponent();
        }

        public AddSPtoHD(AddHoaDon f)
        {
            InitializeComponent();
            fAddHoaDon = f;
        }

        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }

        private void AddSPtoHD_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dsSP = sanPhamDPro.ShowSanPham();
            for(int i=0; i<dsSP.Count; i++)
            {
                cbbTenSP.Items.Add(dsSP[i].TenSP);
            }
            t = cbbTenSP.Items.Count;
            if (t > 0)
                cbbTenSP.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {               
                if (int.Parse(nudSoLuong.Value.ToString()) <= 0)
                {
                    throw new Exception("Số lượng phải lớn hơn 0");
                }

                foreach(SanPhamsDTO sp in dsSP)
                {
                    if (sp.TenSP == cbbTenSP.Text)
                    {
                        fAddHoaDon.addSP_to_HD(sp.MaSP, sp.TenSP, int.Parse(nudSoLuong.Value.ToString()), sp.GiaSP);
                    }
                }
                fAddHoaDon.hienThi();
                cbbTenSP.Text = "";
                nudSoLuong.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
