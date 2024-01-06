using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Management;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations.Schema;
using BLL;
using DTO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace QuanLyCuaHangMayTinh.MainForm
{
    public partial class QuanLyNhaCC : UserControl
    {
        NhaCungCapBLL nccBLL = new NhaCungCapBLL();
        string imageUrl = null;
        public QuanLyNhaCC()
        {
            InitializeComponent();
        }

        private void grv_danhsachNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void QuanLyNhaCC_Load(object sender, EventArgs e)
        {
            grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
            cbbTenNCC.DataSource = nccBLL.LayDSNCC();
            cbbTenNCC.DisplayMember = "TenNCC";
        }

        private void btn_themNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maNCC.Text == "" || cbbTenNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    NhaCungCapDTO ncc = new NhaCungCapDTO(txt_maNCC.Text, cbbTenNCC.Text, txt_diachi.Text, txt_lienHe.Text, imageUrl);
                    if (nccBLL.ThemNCC(ncc))
                    {
                        MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pb_timKiemNCC_Click(object sender, EventArgs e)
        {
            if(txt_timKiemNCC.Text == "")
            {
                grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
            }
            grv_danhSachNCC.DataSource = nccBLL.TimKiemNCC(txt_timKiemNCC.Text);
            
            
        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }   

        private void grv_danhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_danhSachNCC.SelectedRows[0];
                txt_maNCC.Text = selectedRow.Cells[0].Value.ToString();
                cbbTenNCC.Text = selectedRow.Cells[1].Value.ToString();
                txt_diachi.Text = selectedRow.Cells[2].Value.ToString();
                txt_lienHe.Text = selectedRow.Cells[3].Value.ToString();
                pb_logoNCC.Image = Image.FromFile(selectedRow.Cells[4].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Choose Image(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pb_logoNCC.Image = Image.FromFile(of.FileName);
                    imageUrl = of.FileName;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void txt_timKiemNCC_TextChanged(object sender, EventArgs e)
        {
            if(txt_timKiemNCC.Text == "")
            {
                grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
            }
        }

        private void btn_suaMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachNCC.SelectedRows.Count > 0)
                {
                    if (txt_maNCC.Text == "" || cbbTenNCC.Text == "" || txt_diachi.Text == "" || txt_lienHe.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridViewRow selectedRow = grv_danhSachNCC.SelectedRows[0];
                        NhaCungCapDTO ncc = new NhaCungCapDTO(txt_maNCC.Text, cbbTenNCC.Text, txt_diachi.Text, txt_lienHe.Text, imageUrl);
                        if (nccBLL.SuaNCC(ncc))
                        {
                            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Chọn vào dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoaMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachNCC.SelectedRows.Count > 0)
                {
                    //Lấy row hiện tại
                    DataGridViewRow selectedRow = grv_danhSachNCC.SelectedRows[0];
                    string mancc = selectedRow.Cells[0].Value.ToString();
                    //Xóa
                    if (nccBLL.XoaNCC(mancc))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chọn vào dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_diachi.Text = "";
            txt_lienHe.Text = "";
            txt_maNCC.Text = "";
            cbbTenNCC.Text = "";
            pb_logoNCC.Image = null;
            grv_danhSachNCC.DataSource = nccBLL.LayDSNCC();
        }
    }
}
