using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace DAL
{
    public class KhachHangDAL : SQLDataAccess
    {
   
        SQLDataAccess connector = null;
        public KhachHangDAL() { 
            connector = new SQLDataAccess();
        }

        public DataTable LayDSKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", connector.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public KhachHangDTO TimKH(string sdt)
        {
            KhachHangDTO khachhangDTO = null;
            connector.Connect();
            {
                SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE sdt = @sdt", connector.con);
                command.Parameters.AddWithValue("@sdt", sdt);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    khachhangDTO = new KhachHangDTO();
                    khachhangDTO.MaKH = reader.GetInt32(0);
                    khachhangDTO.TenKH = reader.GetString(1);
                    khachhangDTO.GT = reader.GetString(2);
                    khachhangDTO.DiaChi = reader.GetString(3);
                    khachhangDTO.SDT = reader.GetString(4);
                }
                reader.Close();
                connector.Disconnect();
            }
            return khachhangDTO;
        }

        public bool ThemKH(KhachHangDTO kh)
        {
            try
            {
                connector.Connect();
                string sql = "insert into KhachHang values(N'" + kh.TenKH + "', N'" + kh.GT + "', N'" + kh.DiaChi + "','" + kh.SDT + "', '" + kh.TrangThai + "')";
                SqlCommand cmd = new SqlCommand(sql, connector.con);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
            return false;
            
        }

        public bool XoaKH(string makh)
        {
            try
            {
                connector.Connect();
                string sql = "delete from KhachHang where MaKH = '"+ makh + "'";
                SqlCommand cmd = new SqlCommand(sql, connector.con);
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

        public bool SuaKH(KhachHangDTO kh)
        {
            try
            {
                connector.Connect();
                string sql = "update KhachHang set TenKH = N'" + kh.TenKH+ "',GT = N'" + kh.GT+ "',DiaChi = N'" + kh.DiaChi+ "',SDT = '"+kh.SDT + "', TrangThai = '"+kh.TrangThai + "'  where MaKH = '" + kh.MaKH + "'";
                SqlCommand cmd = new SqlCommand(sql, connector.con);
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

        public DataTable TimKiemKH(string TenKH)
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where TenKH like N'%" + TenKH + "%'", connector.con);
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
