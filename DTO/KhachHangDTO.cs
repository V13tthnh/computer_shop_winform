using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int MaKH { get; set; }
        public string TenKH { get; set;}
        public string GT { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int TrangThai { get; set; }

        public KhachHangDTO()
        {
            this.TenKH = "";
            this.GT = "";
            this.DiaChi = "";
            this.SDT = "";
            this.TrangThai = 0;
        }
        public KhachHangDTO(string TenKH, string GT, string DiaChi, string SDT, int TrangThai)
        {
            this.TenKH = TenKH;
            this.GT = GT;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.TrangThai = TrangThai;
        }

        public KhachHangDTO(int MaKH, string TenKH, string GT, string DiaChi, string SDT, int TrangThai)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.GT = GT;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.TrangThai = TrangThai;
        }
    }
}
