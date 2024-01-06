using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhuyenMaiDAL
    {
        SQLDataAccess connector = null;
        public KhuyenMaiDAL()
        {
            connector = new SQLDataAccess();
        }
        public DataTable LayDSKM()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from KhuyenMai", connector.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int LayGiaTriGiam(string TenKM)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("select GiaTriGiam from KhuyenMai where TenKM = '"+TenKM+"'", connector.con);
                cmd.CommandType = CommandType.Text;
                Int32 GiaTriGiam = (Int32)cmd.ExecuteScalar();
                return GiaTriGiam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { connector.Disconnect(); }
        }
        public bool ThemKM(KhuyenMaiDTO KM)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("insert into KhuyenMai values(N'" +KM.TenKM + "',N'" + KM.GiaTriGiam + "',N'" + KM.NgayBatDau + "', N'" + KM.NgayKetThuc + "', '"+KM.TrangThai+"')", connector.con);
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

        public bool XoaKM(string MaKM)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("delete from KhuyenMai where MaKM = '" + MaKM + "'", connector.con);
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

        public bool SuaKM(KhuyenMaiDTO KM)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("update KhuyenMai set TenKM = N'" + KM.TenKM + "', GiaTriGiam = N'" + KM.GiaTriGiam + "', NgayBatDau = N'" + KM.NgayBatDau + "', NgayKetThuc = '" + KM.NgayKetThuc + "', TrangThai = '"+KM.TrangThai + "' where MaKM = '" + KM.MaKM + "'", connector.con);
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

        public DataTable TimKiemKM(string GiaTriGiam)
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select * from KhuyenMai where GiaTriGiam = '" + GiaTriGiam + "'", connector.con);
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
