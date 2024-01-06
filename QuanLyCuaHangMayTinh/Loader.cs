using DTO;
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

namespace QuanLyCuaHangMayTinh
{
    public partial class frm_Loader : Form
    {
        TaiKhoanDTO taiKhoan = null;
        public frm_Loader(TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pb_load.Value < 100)
            {
                pb_load.Value += 50;
                label1.Text = pb_load.Value.ToString() + "%";
                
            }
            else
            {
                timer1.Stop();
                frm_QuanLy quanly = new frm_QuanLy(this.taiKhoan);
                quanly.ShowDialog();
                this.Close();
            }
        }
    }
}
