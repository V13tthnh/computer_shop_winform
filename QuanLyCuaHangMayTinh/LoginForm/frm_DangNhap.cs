using QuanLyCuaHangMayTinh.ChucNang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;

namespace QuanLyCuaHangMayTinh
{
    public partial class frm_DangNhap : Form
    {
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        public frm_DangNhap()
        {
            InitializeComponent();
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
        }

        private void x_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            TaiKhoanDTO tkdto = tkbll.DangNhap(username, password);
            if(tkdto != null)
            {
                MessageBox.Show("Đăng nhập thành công!!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frm_QuanLy quanLy = new frm_QuanLy(tkdto);
                //quanLy.ShowDialog();
                this.Hide();
                frm_Loader loader = new frm_Loader(tkdto);
                loader.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_remindme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_show_Click(object sender, EventArgs e)
        {
            if(pic_show.Visible == true)
            {
                txt_password.PasswordChar = '*';
                pic_show.Visible = false;
                pic_hidden.Visible = true;
            }
        }

        private void pic_hidden_Click(object sender, EventArgs e)
        {
            if (pic_hidden.Visible == true)
            {
                txt_password.PasswordChar = '\0';
                
                pic_hidden.Visible = false;
                pic_show.Visible = true;
            }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbl_forgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           
        }
    }
}
    