using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hddal = null;
        public HoaDonBLL() {
            hddal= new HoaDonDAL();
        }
        public int LayMaHDLonNhat()
        {
            return hddal.LayMaHDLonNhat();
        }
        public DataTable LayDSHD()
        {
            return hddal.LayDSHD();
        }

        public bool ThemHD(HoaDonDTO hoadon)
        {
            return hddal.ThemHD(hoadon);
        }
        public bool XoaHD(string MaNCC)
        {
            return hddal.XoaHD(MaNCC);
        }
        public bool SuaHD(HoaDonDTO hoadon)
        {
            return hddal.SuaHD(hoadon);
        }
        public DataTable TimKiemHD(string ngaylap)
        {
            return hddal.TimKiemHD(ngaylap);
        }

        public bool ThongKeDoanhThuHD()
        {
            return hddal.ThongKeDoanhThu();
        }
    }
}
