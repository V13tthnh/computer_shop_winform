using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL : SQLDataAccess
    {
        SQLDataAccess conn = null;
        public NhanVienDAL()
        {
            conn = new SQLDataAccess();
        }

        public int LayMaNVLonNhat()
        {
            try
            {
                conn.Connect();
                SqlCommand cmd = new SqlCommand("select max(MaNV) from NhanVien", conn.con);
                cmd.CommandType = CommandType.Text;
                Int32 MaHD = (Int32)cmd.ExecuteScalar();
                return MaHD;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally { conn.Disconnect(); }
        }

        public DataTable layDSNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select nv.*, TaiKhoan, MatKhau, Quyen from NhanVien nv, taikhoan tk where nv.MaNV = tk.MaNV", conn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool themNhanVien(NhanVienDTO nv)
        {
            try
            {
                conn.Connect();
                string sql = string.Format("insert into NhanVien values(N'" + nv.TenNV + "', N'" + nv.GT + "', N'" + nv.DiaChi + "', '" + nv.SDT + "', '" + nv.Luong + "','" + nv.Anh + "', '" + nv.TrangThai + "')");
                SqlCommand cmd = new SqlCommand(sql, conn.con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Disconnect();
            }
            return false;
        }

        public bool xoaNhanVien(string MaNV)
        {
            try
            {
                conn.Connect();
                string sql = string.Format("delete from NhanVien where MaNV = '" + MaNV + "'");
                SqlCommand cmd = new SqlCommand(sql, conn.con);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Disconnect();
            }
            return false;
        }

        public bool suaNhanVien(NhanVienDTO nv)
        {
            try
            {
                conn.Connect();
                string sql = string.Format("update NhanVien set TenNV = N'" + nv.TenNV + "', DiaChi = N'" + nv.DiaChi + "', SDT = '" + nv.SDT + "', GT = N'" + nv.GT + "', Luong = '" + nv.Luong + "', Anh = N'" + nv.Anh + "', TrangThai = '" + nv.TrangThai + "' where MaNV = '" + nv.MaNV + "'");
                SqlCommand cmd = new SqlCommand(sql, conn.con);
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
                conn.Disconnect();
            }
            return false;
        }

        public DataTable timKiemNV(string TenNV)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from NhanVien where TenNV like N'%" + TenNV+"%'", conn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
