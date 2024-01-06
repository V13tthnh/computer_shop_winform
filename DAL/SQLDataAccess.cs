using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Configuration;
using System.Security.Policy;

namespace DAL
{
    public class SQLDataAccess
    {
        private static SQLDataAccess instance;

        public static SQLDataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLDataAccess();
                }
                return instance;

            }
        }
        public SqlConnection con = null;
        private static string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        private string strcon = @"Data Source=DESKTOP-NDKEKV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangMayTinh;Integrated Security=True";
        public SQLDataAccess()
        {
            con = new SqlConnection(strcon);
        }

        //Hàm mở kết nối nếu có lỗi thì trả về tầng BLL
        public void Connect()
        {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection(strcon);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }   

        public void Disconnect()
        {
            try
            {
                if (con != null || con.State == ConnectionState.Open)
                {
                    con.Close();
                }   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        } 
    }
}
