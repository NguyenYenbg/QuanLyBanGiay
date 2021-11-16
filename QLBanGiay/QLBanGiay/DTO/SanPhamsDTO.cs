using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace QLBanGiay.DTO
{
    class SanPhamsDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public Bitmap AnhSP { get; set; }
        public int GiaSP { get; set; }
        public int KichCo { get; set; }
        public string MauSac { get; set; }
        public string LoaiGiay { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public string NgayTao { get; set; }
        public string NgaySua { get; set; }
        public int MaDM { get; set; }
        public int MaNCC { get; set; }
    }
}
