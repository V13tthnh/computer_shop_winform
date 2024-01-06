using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace QuanLyCuaHangMayTinh.MainForm
{
    public partial class QuanLyNhanVien : UserControl
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        TaiKhoanBLL taikhoan = new TaiKhoanBLL();
        string imageUrl = "";
        int hd = 1;
        int manvMax = 0;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            grv_danhSachNV.DataSource = nvbll.layDSNV();
        }

        

        private void grv_danhSachNV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_danhSachNV.SelectedRows[0];
                txt_MaNV.Text = selectedRow.Cells[0].Value.ToString();
                txt_tenNV.Text = selectedRow.Cells[1].Value.ToString();
                cbb_gioiTinh.Text = selectedRow.Cells[2].Value.ToString();
                txt_diaChi.Text = selectedRow.Cells[3].Value.ToString();
                txt_sdt.Text = selectedRow.Cells[4].Value.ToString();
                txt_luong.Text = selectedRow.Cells[5].Value.ToString();
                pbAnhNV.Image = Image.FromFile(selectedRow.Cells[6].Value.ToString());
                txt_tenTaiKhoan.Text = selectedRow.Cells[8].Value.ToString();
                txt_matKhau.Text = selectedRow.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenNV.Text == "" || txt_sdt.Text == "" || txt_luong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                        NhanVienDTO nv = new NhanVienDTO(txt_tenNV.Text, cbb_gioiTinh.Text, txt_diaChi.Text, txt_sdt.Text, float.Parse(txt_luong.Text), imageUrl, hd);
                        if (nvbll.ThemNV(nv))
                        {
                            manvMax = nvbll.LayMaNVLonNhat();
                            TaiKhoanDTO tk = new TaiKhoanDTO(manvMax, txt_tenTaiKhoan.Text, txt_matKhau.Text, cbbQuyen.Text);
                            if (taikhoan.ThemTaiKhoan(tk))
                            {
                                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                grv_danhSachNV.DataSource = nvbll.layDSNV();
                                btn_reset.PerformClick();    
                            }
                            else
                            {
                                MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachNV.SelectedRows.Count > 0)
                {
                    //Lấy row hiện tại
                    DataGridViewRow selectedRow = grv_danhSachNV.SelectedRows[0];
                    string manv = selectedRow.Cells[0].Value.ToString();
                    if (taikhoan.XoaTK(manv))
                    {
                        if (nvbll.XoaNV(manv))
                        {
                            MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grv_danhSachNV.DataSource = nvbll.layDSNV();
                            btn_reset.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (nvbll.XoaNV(manv))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachNV.DataSource = nvbll.layDSNV();
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

        private void btnSuaNV_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachNV.SelectedRows.Count > 0)
                {
                    if (txt_MaNV.Text == "" || txt_tenNV.Text == "" || txt_diaChi.Text == "" || txt_luong.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridViewRow selectedRow = grv_danhSachNV.SelectedRows[0];
                        NhanVienDTO nv = new NhanVienDTO(int.Parse(txt_MaNV.Text), txt_tenNV.Text, cbb_gioiTinh.Text, txt_diaChi.Text, txt_sdt.Text, float.Parse(txt_luong.Text), imageUrl, hd);
                        TaiKhoanDTO tk = new TaiKhoanDTO(int.Parse(txt_MaNV.Text), txt_tenTaiKhoan.Text, txt_matKhau.Text, cbbQuyen.Text);
                        if (nvbll.SuaNV(nv))
                        {
                            if (taikhoan.SuaTaiKhoan(tk))
                            {
                                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                grv_danhSachNV.DataSource = nvbll.layDSNV();
                                btn_reset.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("Sửa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

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

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_tenNV.Text = "";
            txt_sdt.Text = "";
            txt_diaChi.Text = "";
            txt_luong.Text = "";
            cbb_gioiTinh.Text = "";
            txt_tenTaiKhoan.Text = "";
            txt_matKhau.Text = "";
            cbbQuyen.Text = "";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            grv_danhSachNV.DataSource = nvbll.TimKiemNV(txt_timKiemNV.Text);
        }

        private void btnBrowseImg_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Choose Image(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pbAnhNV.Image = Image.FromFile(of.FileName);
                    imageUrl = of.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_timKiemNV_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiemNV.Text == "")
            {
                grv_danhSachNV.DataSource = nvbll.layDSNV();
            }
        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
