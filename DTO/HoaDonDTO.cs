using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {   
        public int MaHD { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public string NgayLap { get; set; }
        public double TongHD { get; set; }
        public int MaKM { get; set; }


        public HoaDonDTO( int maNV, int maKH, string ngayLap, double tongHD, int maKM)
        {
            MaNV = maNV;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongHD = tongHD;
            MaKM = maKM;
        }
    }
}
