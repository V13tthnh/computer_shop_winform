using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhaCungCapDAL: SQLDataAccess
    {
        SQLDataAccess connector = null;

        public NhaCungCapDAL()
        {
            connector = new SQLDataAccess();
        }
        public DataTable LayDSNhaCungCap()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from NhaCungCap", connector.con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }
            

        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("insert into NhaCungCap values(N'" + ncc.MaNCC + "',N'" + ncc.TenNCC + "',N'" + ncc.DiaChi + "', N'" + ncc.LienHe + "', '" + ncc.TenAnh + "')", connector.con);
                if(cmd.ExecuteNonQuery() > 0) {
                    return true;
                }

            }catch (Exception ex)
            {
                throw ex;
            }
            finally { 
                connector.Disconnect(); 
            }
            return false;
        }

        public bool XoaNCC(string MaNCC)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("delete from NhaCungCap where MaNCC = '" + MaNCC + "'", connector.con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
            return false;
        }

        public bool SuaNCC(NhaCungCapDTO ncc)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("update NhaCungCap set TenNCC = N'" + ncc.TenNCC + "', DiaChi = N'" + ncc.DiaChi + "', LienHe = N'" + ncc.LienHe + "', PhotoUrl = '" + ncc.TenAnh + "' where MaNCC = '" + ncc.MaNCC + "'", connector.con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
            return false;
        }

        public DataTable TimKiemNCC(string TenNCC)
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap where TenNCC like '%" + TenNCC + "%'", connector.con);
                DataTable dtNCC = new DataTable();
                da.Fill(dtNCC);
                return dtNCC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
        }
    }
}
