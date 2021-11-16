using QLBanGiay.DTO;
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
    public partial class XoaNhaCC : Form
    {
        string maNCC;
        int t;
        public XoaNhaCC()
        {
            InitializeComponent();
        }
        public XoaNhaCC(string m)
        {
            InitializeComponent();
            maNCC = m;
            loadCbb();
        }
        public void loadCbb()
        {
            List<NhaCCsDTO> nhaCCDPros = new NhaCCDPro().nhaCC();
            for(int i=0; i<nhaCCDPros.Count; i++)
            {
                if (int.Parse(maNCC) != nhaCCDPros[i].MaNCC)
                {
                    cbb_NCC.Items.Add(nhaCCDPros[i].TenNCC);
                }
            }
            t = cbb_NCC.Items.Count;
            if (t > 0)
                cbb_NCC.SelectedIndex = 0;
        }
        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            try
            {
                new SanPhamDPro().ChangeSP_toNCC(new NhaCCDPro().getmaNCC(cbb_NCC.Text), int.Parse(maNCC));
                new NhaCCDPro().DeleteNhaCC(int.Parse(maNCC));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }

        private void XoaNhaCC_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
