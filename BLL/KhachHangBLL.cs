using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khda = null;
     
        public KhachHangBLL() {
            khda = new KhachHangDAL();
        }

        public DataTable LayDSKH()
        {
            return khda.LayDSKH();
        }

        public bool ThemKH(KhachHangDTO kh)
        {
            return khda.ThemKH(kh);
        }

        public bool XoaKH(string kh)
        {
            return khda.XoaKH(kh);
        }

        public bool SuaKH(KhachHangDTO kh)
        {
            return khda.SuaKH(kh);
        }

        public DataTable TimKH(string tenkh)
        {
            return khda.TimKiemKH(tenkh);
        }

        public KhachHangDTO LayKH(string sdt)
        {
            return khda.TimKH(sdt);
        }
    }
}
