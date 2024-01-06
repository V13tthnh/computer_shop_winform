using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL connector = null; 
        public NhaCungCapBLL()
        {
            connector = new NhaCungCapDAL();
        }

        public DataTable LayDSNCC()
        {
            return connector.LayDSNhaCungCap();
        }

        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            return connector.ThemNCC(ncc);
        }

        public bool XoaNCC(string MaNCC)
        {
            return connector.XoaNCC(MaNCC);
        }

        public bool SuaNCC(NhaCungCapDTO ncc)
        {
            return connector.SuaNCC(ncc);
        }

        public DataTable TimKiemNCC(string TenNCC) {
            return connector.TimKiemNCC(TenNCC);
        }


 
    }
}
