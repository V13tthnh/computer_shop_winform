using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDDTO
    {
        public int MaCTHD { get; set; }
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public CTHDDTO(int MaHD, int MaSP, int SoLuong, double DonGia) { 
            this.MaHD = MaHD;
            this.MaSP = MaSP;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }
    }
}
