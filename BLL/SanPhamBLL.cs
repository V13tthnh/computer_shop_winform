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
    public class SanPhamBLL
    {
        SanPhamDAL spdal;
        public SanPhamBLL()
        {
           spdal = new SanPhamDAL();
        }

        public DataTable LayDSSP()
        {
            return spdal.LayDSSP();
        }

        public DataTable LayDSTenAnhSP()
        {
            return spdal.LayTenAnhDSSP();
        }

        public bool ThemSP(SanPhamDTO sp)
        {
            return spdal.ThemSP(sp);
        }

        public bool XoaSP(string MaSP)
        {
            return spdal.XoaSP(MaSP);
        }
        public bool SuaSP(SanPhamDTO sp)
        {
            return spdal.SuaSP(sp);
        }

        public DataTable TimKiemSP(string tenSP)
        {
            return spdal.TimKiemSP(tenSP);
        }

        public DataTable TongTienNhap()
        {
            return spdal.TongTienNhap();
        }

        public DataTable TongSLTon()
        {
            return spdal.TongSLSanPham();
        }

        public bool CapNhatSoLuongSanPham(int masp, int sl)
        {
            return spdal.CapNhatSoLuongSanPham(masp, sl);
        }
    }
}
