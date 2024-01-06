namespace QuanLyCuaHangMayTinh.MainForm
{
    partial class QuanLyHoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbQuanLyHoaDon = new System.Windows.Forms.TabControl();
            this.tp_quanLyHoaDon = new System.Windows.Forms.TabPage();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_suaHD = new System.Windows.Forms.Button();
            this.btn_themHD = new System.Windows.Forms.Button();
            this.btn_xoaHD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.grv_danhSachHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_makH = new System.Windows.Forms.TextBox();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpQuanLyCTHD = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pb_timKiemCTHD = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grv_DSCTHD = new Guna.UI.WinForms.GunaDataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuanLyHoaDon.SuspendLayout();
            this.tp_quanLyHoaDon.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danhSachHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpQuanLyCTHD.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiemCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DSCTHD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuanLyHoaDon
            // 
            this.tbQuanLyHoaDon.Controls.Add(this.tp_quanLyHoaDon);
            this.tbQuanLyHoaDon.Controls.Add(this.tpQuanLyCTHD);
            this.tbQuanLyHoaDon.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tbQuanLyHoaDon.Location = new System.Drawing.Point(3, 0);
            this.tbQuanLyHoaDon.Name = "tbQuanLyHoaDon";
            this.tbQuanLyHoaDon.SelectedIndex = 0;
            this.tbQuanLyHoaDon.Size = new System.Drawing.Size(1283, 758);
            this.tbQuanLyHoaDon.TabIndex = 0;
            this.tbQuanLyHoaDon.SelectedIndexChanged += new System.EventHandler(this.tbCTHD_SelectedIndexChanged);
            // 
            // tp_quanLyHoaDon
            // 
            this.tp_quanLyHoaDon.Controls.Add(this.btn_reset);
            this.tp_quanLyHoaDon.Controls.Add(this.btn_suaHD);
            this.tp_quanLyHoaDon.Controls.Add(this.btn_themHD);
            this.tp_quanLyHoaDon.Controls.Add(this.btn_xoaHD);
            this.tp_quanLyHoaDon.Controls.Add(this.panel2);
            this.tp_quanLyHoaDon.Controls.Add(this.grv_danhSachHoaDon);
            this.tp_quanLyHoaDon.Controls.Add(this.label12);
            this.tp_quanLyHoaDon.Controls.Add(this.txtTimKiemTheoTen);
            this.tp_quanLyHoaDon.Controls.Add(this.btnTimKiem);
            this.tp_quanLyHoaDon.Controls.Add(this.groupBox1);
            this.tp_quanLyHoaDon.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tp_quanLyHoaDon.Location = new System.Drawing.Point(4, 27);
            this.tp_quanLyHoaDon.Name = "tp_quanLyHoaDon";
            this.tp_quanLyHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tp_quanLyHoaDon.Size = new System.Drawing.Size(1275, 727);
            this.tp_quanLyHoaDon.TabIndex = 0;
            this.tp_quanLyHoaDon.Text = "Hóa đơn";
            this.tp_quanLyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.circle_of_two_clockwise_arrows_rotation1;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(636, 328);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(182, 58);
            this.btn_reset.TabIndex = 99;
            this.btn_reset.Text = "     Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_suaHD
            // 
            this.btn_suaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_suaHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_suaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_suaHD.ForeColor = System.Drawing.Color.Black;
            this.btn_suaHD.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.repair2;
            this.btn_suaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaHD.Location = new System.Drawing.Point(432, 328);
            this.btn_suaHD.Name = "btn_suaHD";
            this.btn_suaHD.Size = new System.Drawing.Size(182, 58);
            this.btn_suaHD.TabIndex = 98;
            this.btn_suaHD.Text = "     Sửa";
            this.btn_suaHD.UseVisualStyleBackColor = false;
            this.btn_suaHD.Click += new System.EventHandler(this.btn_suaHD_Click_1);
            // 
            // btn_themHD
            // 
            this.btn_themHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_themHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_themHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_themHD.ForeColor = System.Drawing.Color.Black;
            this.btn_themHD.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_add_641;
            this.btn_themHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themHD.Location = new System.Drawing.Point(10, 328);
            this.btn_themHD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_themHD.Name = "btn_themHD";
            this.btn_themHD.Size = new System.Drawing.Size(182, 58);
            this.btn_themHD.TabIndex = 96;
            this.btn_themHD.Text = "     Thêm";
            this.btn_themHD.UseVisualStyleBackColor = false;
            this.btn_themHD.Click += new System.EventHandler(this.btn_themHD_Click_1);
            // 
            // btn_xoaHD
            // 
            this.btn_xoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_xoaHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_xoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoaHD.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaHD.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.bin3;
            this.btn_xoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaHD.Location = new System.Drawing.Point(220, 328);
            this.btn_xoaHD.Name = "btn_xoaHD";
            this.btn_xoaHD.Size = new System.Drawing.Size(182, 58);
            this.btn_xoaHD.TabIndex = 97;
            this.btn_xoaHD.Text = "     Xóa";
            this.btn_xoaHD.UseVisualStyleBackColor = false;
            this.btn_xoaHD.Click += new System.EventHandler(this.btn_xoaHD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(6, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 52);
            this.panel2.TabIndex = 95;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(568, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 18);
            this.label15.TabIndex = 45;
            this.label15.Text = "Danh sách hóa đơn";
            // 
            // grv_danhSachHoaDon
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.grv_danhSachHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grv_danhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_danhSachHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.grv_danhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_danhSachHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_danhSachHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_danhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grv_danhSachHoaDon.ColumnHeadersHeight = 20;
            this.grv_danhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.MaKH,
            this.NgayLap,
            this.TongTien});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_danhSachHoaDon.DefaultCellStyle = dataGridViewCellStyle12;
            this.grv_danhSachHoaDon.EnableHeadersVisualStyles = false;
            this.grv_danhSachHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachHoaDon.Location = new System.Drawing.Point(10, 459);
            this.grv_danhSachHoaDon.Name = "grv_danhSachHoaDon";
            this.grv_danhSachHoaDon.RowHeadersVisible = false;
            this.grv_danhSachHoaDon.RowHeadersWidth = 51;
            this.grv_danhSachHoaDon.RowTemplate.Height = 24;
            this.grv_danhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_danhSachHoaDon.Size = new System.Drawing.Size(1259, 262);
            this.grv_danhSachHoaDon.TabIndex = 0;
            this.grv_danhSachHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grv_danhSachHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_danhSachHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_danhSachHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_danhSachHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_danhSachHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.grv_danhSachHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_danhSachHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_danhSachHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_danhSachHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_danhSachHoaDon.ThemeStyle.HeaderStyle.Height = 20;
            this.grv_danhSachHoaDon.ThemeStyle.ReadOnly = false;
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_danhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_danhSachHoaDon_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongHD";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(840, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 18);
            this.label12.TabIndex = 94;
            this.label12.Text = "Tìm kiếm theo tên:";
            // 
            // txtTimKiemTheoTen
            // 
            this.txtTimKiemTheoTen.Location = new System.Drawing.Point(844, 350);
            this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
            this.txtTimKiemTheoTen.Size = new System.Drawing.Size(299, 26);
            this.txtTimKiemTheoTen.TabIndex = 93;
            this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1149, 350);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 26);
            this.btnTimKiem.TabIndex = 92;
            this.btnTimKiem.Text = "Tìm ";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtp_ngayLap);
            this.groupBox1.Controls.Add(this.txt_tongTien);
            this.groupBox1.Controls.Add(this.txt_makH);
            this.groupBox1.Controls.Add(this.txt_maNV);
            this.groupBox1.Controls.Add(this.txt_maHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 312);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtp_ngayLap
            // 
            this.dtp_ngayLap.Location = new System.Drawing.Point(764, 57);
            this.dtp_ngayLap.Name = "dtp_ngayLap";
            this.dtp_ngayLap.Size = new System.Drawing.Size(297, 26);
            this.dtp_ngayLap.TabIndex = 16;
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(764, 131);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(297, 26);
            this.txt_tongTien.TabIndex = 14;
            // 
            // txt_makH
            // 
            this.txt_makH.Location = new System.Drawing.Point(311, 201);
            this.txt_makH.Name = "txt_makH";
            this.txt_makH.Size = new System.Drawing.Size(297, 26);
            this.txt_makH.TabIndex = 13;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(311, 131);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(297, 26);
            this.txt_maNV.TabIndex = 11;
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(311, 57);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.ReadOnly = true;
            this.txt_maHD.Size = new System.Drawing.Size(297, 26);
            this.txt_maHD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng:";
            // 
            // tpQuanLyCTHD
            // 
            this.tpQuanLyCTHD.Controls.Add(this.panel1);
            this.tpQuanLyCTHD.Controls.Add(this.pb_timKiemCTHD);
            this.tpQuanLyCTHD.Controls.Add(this.txtTimKiem);
            this.tpQuanLyCTHD.Controls.Add(this.label4);
            this.tpQuanLyCTHD.Controls.Add(this.grv_DSCTHD);
            this.tpQuanLyCTHD.Controls.Add(this.groupBox4);
            this.tpQuanLyCTHD.Location = new System.Drawing.Point(4, 27);
            this.tpQuanLyCTHD.Name = "tpQuanLyCTHD";
            this.tpQuanLyCTHD.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyCTHD.Size = new System.Drawing.Size(1275, 727);
            this.tpQuanLyCTHD.TabIndex = 1;
            this.tpQuanLyCTHD.Text = "Chi tiết hóa đơn";
            this.tpQuanLyCTHD.UseVisualStyleBackColor = true;
            this.tpQuanLyCTHD.Click += new System.EventHandler(this.tpQuanLyCTHD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(6, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 52);
            this.panel1.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(552, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "Danh sách chi tiết hóa đơn";
            // 
            // pb_timKiemCTHD
            // 
            this.pb_timKiemCTHD.BackColor = System.Drawing.Color.White;
            this.pb_timKiemCTHD.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.search;
            this.pb_timKiemCTHD.Location = new System.Drawing.Point(1225, 286);
            this.pb_timKiemCTHD.Name = "pb_timKiemCTHD";
            this.pb_timKiemCTHD.Size = new System.Drawing.Size(41, 26);
            this.pb_timKiemCTHD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_timKiemCTHD.TabIndex = 43;
            this.pb_timKiemCTHD.TabStop = false;
            this.pb_timKiemCTHD.Click += new System.EventHandler(this.pb_timKiemCTHD_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(940, 286);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(326, 26);
            this.txtTimKiem.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(849, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm kiếm:";
            // 
            // grv_DSCTHD
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grv_DSCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grv_DSCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_DSCTHD.BackgroundColor = System.Drawing.Color.White;
            this.grv_DSCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_DSCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DSCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DSCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grv_DSCTHD.ColumnHeadersHeight = 25;
            this.grv_DSCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHD,
            this.MaHoaDon,
            this.MaSP,
            this.SoLuong,
            this.DonGia});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DSCTHD.DefaultCellStyle = dataGridViewCellStyle9;
            this.grv_DSCTHD.EnableHeadersVisualStyles = false;
            this.grv_DSCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DSCTHD.Location = new System.Drawing.Point(7, 377);
            this.grv_DSCTHD.Name = "grv_DSCTHD";
            this.grv_DSCTHD.RowHeadersVisible = false;
            this.grv_DSCTHD.RowHeadersWidth = 51;
            this.grv_DSCTHD.RowTemplate.Height = 24;
            this.grv_DSCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_DSCTHD.Size = new System.Drawing.Size(1265, 347);
            this.grv_DSCTHD.TabIndex = 1;
            this.grv_DSCTHD.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grv_DSCTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DSCTHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_DSCTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_DSCTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_DSCTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_DSCTHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_DSCTHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DSCTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.grv_DSCTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_DSCTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_DSCTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_DSCTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DSCTHD.ThemeStyle.HeaderStyle.Height = 25;
            this.grv_DSCTHD.ThemeStyle.ReadOnly = false;
            this.grv_DSCTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DSCTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DSCTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_DSCTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DSCTHD.ThemeStyle.RowsStyle.Height = 24;
            this.grv_DSCTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DSCTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DSCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_DSCTHD_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDonGia);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.txtMaSP);
            this.groupBox4.Controls.Add(this.txtMaHD);
            this.groupBox4.Controls.Add(this.txtMaCTHD);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1262, 258);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(679, 119);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(277, 26);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(679, 60);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(277, 26);
            this.txtSoLuong.TabIndex = 11;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(213, 179);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(277, 26);
            this.txtMaSP.TabIndex = 10;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(213, 119);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(277, 26);
            this.txtMaHD.TabIndex = 9;
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(213, 60);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(277, 26);
            this.txtMaCTHD.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label11.Location = new System.Drawing.Point(569, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Đơn giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label10.Location = new System.Drawing.Point(569, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label9.Location = new System.Drawing.Point(64, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(77, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(94, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã CTHD:";
            // 
            // MaCTHD
            // 
            this.MaCTHD.DataPropertyName = "MaCTHD";
            this.MaCTHD.HeaderText = "Mã CTHD";
            this.MaCTHD.MinimumWidth = 6;
            this.MaCTHD.Name = "MaCTHD";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHD";
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbQuanLyHoaDon);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "QuanLyHoaDon";
            this.Size = new System.Drawing.Size(1283, 758);
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.tbQuanLyHoaDon.ResumeLayout(false);
            this.tp_quanLyHoaDon.ResumeLayout(false);
            this.tp_quanLyHoaDon.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danhSachHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpQuanLyCTHD.ResumeLayout(false);
            this.tpQuanLyCTHD.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiemCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DSCTHD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbQuanLyHoaDon;
        private System.Windows.Forms.TabPage tp_quanLyHoaDon;
        private Guna.UI.WinForms.GunaDataGridView grv_danhSachHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ngayLap;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_makH;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpQuanLyCTHD;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView grv_DSCTHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pb_timKiemCTHD;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimKiemTheoTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_suaHD;
        private System.Windows.Forms.Button btn_themHD;
        private System.Windows.Forms.Button btn_xoaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}
