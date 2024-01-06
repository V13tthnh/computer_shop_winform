using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace QuanLyCuaHangMayTinh.ChucNang
{
    public partial class BanHang : UserControl
    {
        private TaiKhoanDTO tkdto;
        HoaDonBLL hdbll = new HoaDonBLL();
        CTHDBLL cthd = new CTHDBLL();
        KhachHangBLL khbll = new KhachHangBLL();
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        LoaiSanPhamBLL loaispbll = new LoaiSanPhamBLL();
        SanPhamBLL spbll = new SanPhamBLL();
        KhuyenMaiBLL khuyenmai = new KhuyenMaiBLL();
        double tongHD = 0;
        string tenKH = "";
        int mahd = 0;
        double loinhuan = 0;
        DateTime now = DateTime.Now;
        public BanHang(TaiKhoanDTO tkdto)
        {
            InitializeComponent();
            this.tkdto = tkdto;
            //Lấy mã hóa đơn lớn nhất là mã hóa đơn vừa thêm vào;
            mahd = hdbll.LayMaHDLonNhat() <= 0 ? mahd = 0 : mahd = hdbll.LayMaHDLonNhat();
        }
        public void loadComboboxTenSP()
        {
            cbb_TenSP.DataSource = spbll.LayDSSP();
            cbb_TenSP.DisplayMember = "TenSP";
        }
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
        }
        DataTable table = new DataTable();

        decimal tongsl = 0;
        decimal tongTT = 0;
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            tongsl = nud_SL.Value;
            tongTT = nud_SL.Value * decimal.Parse(txt_DonGia.Text);
            if (nud_SL.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string masp = txt_MaSP.Text;
                DataTable tb = spbll.LayDSSP();
                //Kiểm tra số lượng bán với số lượng tồn nếu SL bán vượt qua số lượng tồn thì xuất thông báo
                foreach (DataRow rows in tb.Rows)
                {
                    if (rows["MaSP"].ToString() == masp.ToString())
                    {
                        if (decimal.Parse(rows["SLTon"].ToString()) < nud_SL.Value)
                        {
                            MessageBox.Show("Số lượng hàng tồn không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //Kiểm tra nếu trong datagridview có 2 dòng dữ liệu trùng nhau, thì bỏ 1 dòng đồng thời tăng số lượng và thành tiền của dùng kia lên
                for (int i = 0; i < grv_DSHD.Rows.Count - 1; i++)
                {
                    if (masp == grv_DSHD.Rows[i].Cells[0].Value.ToString())
                    {
                        tongsl += decimal.Parse(grv_DSHD.Rows[i].Cells[2].Value.ToString());
                        tongTT = decimal.Parse(grv_DSHD.Rows[i].Cells[3].Value.ToString()) * tongsl;
                        tongHD = 0;
                        grv_DSHD.Rows.Remove(grv_DSHD.Rows[i]);
                        break;
                    }
                }
                string tensp = cbb_TenSP.Text;
                table.Rows.Add(int.Parse(txt_MaSP.Text), tensp, tongsl, double.Parse(txt_DonGia.Text), 0, tongTT);
                grv_DSHD.DataSource = table;

            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printHoaDon;
            printHoaDon.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 500, 600);
            printPreviewDialog.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "" || nud_SL.Text == "0" || grv_DSHD.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    try
                    {
                        int manv = int.Parse(tkdto.MaNV.ToString());
                        HoaDonDTO hoadon = new HoaDonDTO(manv, int.Parse(txt_MaKH.Text), now.ToString("yyyy-MM-dd"), tongHD, 0);
                        //Thêm hóa đơn
                        if (hdbll.ThemHD(hoadon))
                        {
                            //Thêm chi tiết hóa đơn
                            for (int i = 0; i < grv_DSHD.Rows.Count - 1; i++)
                            {
                                int masp = int.Parse(grv_DSHD.Rows[i].Cells[0].Value.ToString());
                                int soluong = int.Parse(grv_DSHD.Rows[i].Cells[2].Value.ToString());
                                double dongia = double.Parse(grv_DSHD.Rows[i].Cells[3].Value.ToString());
                                CTHDDTO cthddto = new CTHDDTO(mahd, masp, soluong, dongia);
                                cthd.ThemCTHD(cthddto);
                                //Cập nhật số lượng sản phẩm
                                spbll.CapNhatSoLuongSanPham(masp, soluong);
                            }
                            DialogResult dialogresult = MessageBox.Show("Thanh toán thành công, bạn có muốn thêm hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (DialogResult.Yes == dialogresult)
                            {
                                btnInHoaDon.PerformClick();
                            }
                            //loinhuan += double.Parse(txtTienThua.Text);
                            txtSDT.Text = "";
                            lblTongHD.Text = "THĐ";
                            txtTienKhachTra.Text = "0";
                            txtTienThua.Text = "0.0 vnđ";
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void BanHang_Load_1(object sender, EventArgs e)
        {
            loadComboboxTenSP();
            table.Columns.Add(grv_DSHD.Columns[0].Name.ToString(), typeof(int));
            table.Columns.Add(grv_DSHD.Columns[1].Name.ToString(), typeof(string));
            table.Columns.Add(grv_DSHD.Columns[2].Name.ToString(), typeof(decimal));
            table.Columns.Add(grv_DSHD.Columns[3].Name.ToString(), typeof(double));
            table.Columns.Add(grv_DSHD.Columns[4].Name.ToString(), typeof(string));
            table.Columns.Add(grv_DSHD.Columns[5].Name.ToString(), typeof(double));
            grv_DSHD.DataSource = table;
            cbbMaKhuyenMai.DataSource = khuyenmai.LayDSKM();
            cbbMaKhuyenMai.DisplayMember = "TenKM";
        }

        //Hàm xóa 1 dòng dữ liệu trên datagridview sau khi click chuột trái vào dòng đó 2 lần
        private int rowIndex = 0;
        private void grv_DSHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grv_DSHD.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.grv_DSHD.CurrentCell = this.grv_DSHD.Rows[e.RowIndex].Cells[1];
                if (!grv_DSHD.Rows[this.rowIndex].IsNewRow)
                {
                    this.grv_DSHD.Rows.RemoveAt(this.rowIndex);
                }
            }
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTienKhachTra.Text != null)
                {
                    double tienThua = double.Parse(txtTienKhachTra.Text) - tongHD;
                    txtTienThua.Text = string.Format("{0:n}", tienThua) + " vnđ";
                }
                else
                {
                    txtTienThua.Text = "0.0 vnđ";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbb_TenSP_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = spbll.TimKiemSP(cbb_TenSP.Text);
            foreach (DataRow row in dt.Rows)
            {
                txt_MaSP.Text = row["MaSP"].ToString();
                txt_DonGia.Text = row["DonGia"].ToString();
                pb_Anh.Image = Image.FromFile(row["AnhSP"].ToString());

            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            KhachHangDTO data = khbll.LayKH(txtSDT.Text);
            if (data != null)
            {
                txt_MaKH.Text = data.MaKH.ToString();
                txtTenKH.Text = data.TenKH.ToString();
            }
            else
            {
                txt_MaKH.Text = "";
                txtTenKH.Text = "";
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            tongHD = 0;
            for (int i = 0; i < grv_DSHD.Rows.Count - 1; i++)
            {
                tongHD += double.Parse(grv_DSHD.Rows[i].Cells[5].Value.ToString());
            }
            lblTongHD.Text = string.Format("{0:n}", tongHD) + " vnđ";
        }

        private void txtTienThua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
            txtTienKhachTra.Text = "0";
            cbb_TenSP.Text = "";
            lblTongHD.Text = "THĐ";
        }

        private void printHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            tenKH = txtTenKH.Text;
            e.Graphics.DrawString("CỬA HÀNG MÁY TÍNH SYSTEM2VN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(30, 5));
            e.Graphics.DrawString("HÓA ĐƠN MUA HÀNG", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(155, 30));
            e.Graphics.DrawString("Số hóa đơn: " + mahd, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(155, 50));
            e.Graphics.DrawString("Ngày: " + now.ToString("dd-MM-yyy"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, 80));
            e.Graphics.DrawString("In lúc: " + now.ToString("hh:mm:ss"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(250, 80));
            e.Graphics.DrawString("Mã nhân viên: " + tkdto.MaNV.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString("Tên Khách hàng: " + txtTenKH.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(250, 100));
            e.Graphics.DrawString("________________________________________________________________________________________________________________", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 120));
            e.Graphics.DrawString("Tên mặt hàng", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, 140));
            e.Graphics.DrawString("|", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(280, 140));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(290, 140));
            e.Graphics.DrawString("|", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(360, 140));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(370, 140));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 160));
            int y = 180, tongsl = 0;
            for (int i = 0; i < grv_DSHD.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(grv_DSHD.Rows[i].Cells["TenSP"].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(5, y));
                e.Graphics.DrawString(grv_DSHD.Rows[i].Cells["SoLuong"].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(290, y));
                e.Graphics.DrawString(string.Format("{0:n}", double.Parse(grv_DSHD.Rows[i].Cells["DonGia"].Value.ToString())), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(370, y));
                tongsl += int.Parse(grv_DSHD.Rows[i].Cells["SoLuong"].Value.ToString());
                y += 20;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString("Tổng số lượng: " + tongsl, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(300, y + 20));
            e.Graphics.DrawString("Ghi chú: ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(30, y + 20));
            e.Graphics.DrawString("Tổng thành tiền: " + string.Format("{0:n}", tongHD), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(300, y + 40));
            e.Graphics.DrawString("Khuyến mãi: Không", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(300, y + 60));
            e.Graphics.DrawString("Tổng cộng: " + string.Format("{0:n}", tongHD), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(300, y + 80));
            e.Graphics.DrawString("Người bán hàng", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(50, y + 120));
            e.Graphics.DrawString("Người đặt hàng", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(280, y + 120));
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            double giamgia = double.Parse(lblTongHD.Text) * (100 - khuyenmai.LayGiaTriGiam(cbbMaKhuyenMai.Text) / 100);
            lblTongHD.Text = giamgia.ToString();
        }

        private void btnChonKM_Click(object sender, EventArgs e)
        {
            double giamgia = double.Parse(lblTongHD.Text) * ((100 - khuyenmai.LayGiaTriGiam(cbbMaKhuyenMai.Text)) / 100);
            lblTongHD.Text = string.Format("{0:n}", giamgia) + " vnđ";
        }
    }
}
