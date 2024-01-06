using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nvda = null;
        public NhanVienBLL()
        {
            nvda = new NhanVienDAL();
        }

        public int LayMaNVLonNhat()
        {
            return nvda.LayMaNVLonNhat();
        }

        public DataTable layDSNV()
        {
            return nvda.layDSNhanVien();
        }

        public bool ThemNV(NhanVienDTO nv)
        {
            return nvda.themNhanVien(nv);
        }

        public bool XoaNV(String MaNV)
        {
            return nvda.xoaNhanVien(MaNV);
        }

        public bool SuaNV(NhanVienDTO nv)
        {
            return nvda.suaNhanVien(nv);
        }

        public DataTable TimKiemNV(string TenNV)
        {
            return nvda.timKiemNV(TenNV);
        }
    }
}
