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
    public class KhuyenMaiBLL
    {
        KhuyenMaiDAL connector = null;
        public KhuyenMaiBLL()
        {
            connector = new KhuyenMaiDAL();
        }

        public DataTable LayDSKM()
        {
            return connector.LayDSKM();
        }

        public DataTable TimKiemKM(string GiaTriGiam)
        {
            return connector.TimKiemKM(GiaTriGiam);
        }

        public bool SuaKM(KhuyenMaiDTO KM)
        {
            return connector.SuaKM(KM);
        }

        public bool XoaKM(string MaKM)
        {
            return connector.XoaKM(MaKM); 
        }

        public bool ThemKM(KhuyenMaiDTO KM)
        {
            return connector.ThemKM(KM);
        }

        public int LayGiaTriGiam(string TenKM)
        {
            return connector.LayGiaTriGiam(TenKM);
        }
    }
}
