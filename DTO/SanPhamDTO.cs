using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public int MaSP { get; set; }
        public int MaLoai { get; set; }
        public string MaNCC { get; set; }
        public string TenSP { get; set; }
        public int SLTon { get; set; }
        public double DonGia { get; set; }
        public string MoTa { get; set; }
        public string AnhSP { get; set; }
        public int TrangThai { get; set; }


        public SanPhamDTO(int MaLoai, string MaNCC, string TenSP, int SLTon, double DonGia, string MoTa, string AnhSP, int TrangThai) {
            this.MaLoai = MaLoai;
            this.MaNCC = MaNCC;
            this.TenSP = TenSP;
            this.SLTon = SLTon;
            this.DonGia = DonGia;
            this.MoTa = MoTa;
            this.AnhSP = AnhSP;
            this.TrangThai = TrangThai;
        }
    }
}
