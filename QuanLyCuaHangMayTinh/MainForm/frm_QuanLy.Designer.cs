using DTO;

namespace QuanLyCuaHangMayTinh.ChucNang
{
    partial class frm_QuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_banHang = new System.Windows.Forms.Button();
            this.panel_move = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.btn_nhanVien = new System.Windows.Forms.Button();
            this.btn_khachHang = new System.Windows.Forms.Button();
            this.btn_sanPham = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_nhaCungCap = new System.Windows.Forms.Button();
            this.btn_khuyenMai = new System.Windows.Forms.Button();
            this.btn_baoCaoThongKe = new System.Windows.Forms.Button();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.lbl_quyen = new System.Windows.Forms.Label();
            this.lbl_tenTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dataTime = new System.Windows.Forms.Label();
            this.lbl_xinChao = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.btn_banHang);
            this.panel2.Controls.Add(this.panel_move);
            this.panel2.Controls.Add(this.panel_center);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pb_icon);
            this.panel2.Controls.Add(this.btn_nhanVien);
            this.panel2.Controls.Add(this.btn_khachHang);
            this.panel2.Controls.Add(this.btn_sanPham);
            this.panel2.Controls.Add(this.btn_bill);
            this.panel2.Controls.Add(this.btn_nhaCungCap);
            this.panel2.Controls.Add(this.btn_khuyenMai);
            this.panel2.Controls.Add(this.btn_baoCaoThongKe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 768);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_banHang
            // 
            this.btn_banHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_banHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_banHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banHang.ForeColor = System.Drawing.Color.White;
            this.btn_banHang.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_sell_501;
            this.btn_banHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banHang.Location = new System.Drawing.Point(7, 167);
            this.btn_banHang.Name = "btn_banHang";
            this.btn_banHang.Size = new System.Drawing.Size(243, 47);
            this.btn_banHang.TabIndex = 1;
            this.btn_banHang.Text = "     Bán hàng";
            this.btn_banHang.UseVisualStyleBackColor = false;
            this.btn_banHang.Click += new System.EventHandler(this.btn_banHang_Click);
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.White;
            this.panel_move.Location = new System.Drawing.Point(4, 167);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(4, 50);
            this.panel_move.TabIndex = 2;
            // 
            // panel_center
            // 
            this.panel_center.Location = new System.Drawing.Point(250, 75);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(1006, 648);
            this.panel_center.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(67, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 29);
            this.label11.TabIndex = 4;
            this.label11.Text = "system2vn";
            // 
            // pb_icon
            // 
            this.pb_icon.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.computer;
            this.pb_icon.Location = new System.Drawing.Point(72, 13);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(109, 99);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 3;
            this.pb_icon.TabStop = false;
            // 
            // btn_nhanVien
            // 
            this.btn_nhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_nhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanVien.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_staff_50;
            this.btn_nhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanVien.Location = new System.Drawing.Point(5, 220);
            this.btn_nhanVien.Name = "btn_nhanVien";
            this.btn_nhanVien.Size = new System.Drawing.Size(245, 51);
            this.btn_nhanVien.TabIndex = 3;
            this.btn_nhanVien.Text = "     Nhân viên";
            this.btn_nhanVien.UseVisualStyleBackColor = false;
            this.btn_nhanVien.Click += new System.EventHandler(this.btn_nhanVien_Click);
            // 
            // btn_khachHang
            // 
            this.btn_khachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_khachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_khachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachHang.ForeColor = System.Drawing.Color.White;
            this.btn_khachHang.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_customer_50;
            this.btn_khachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachHang.Location = new System.Drawing.Point(5, 277);
            this.btn_khachHang.Name = "btn_khachHang";
            this.btn_khachHang.Size = new System.Drawing.Size(245, 51);
            this.btn_khachHang.TabIndex = 4;
            this.btn_khachHang.Text = "     Khách hàng";
            this.btn_khachHang.UseVisualStyleBackColor = false;
            this.btn_khachHang.Click += new System.EventHandler(this.btn_khachHang_Click);
            // 
            // btn_sanPham
            // 
            this.btn_sanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_sanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanPham.ForeColor = System.Drawing.Color.White;
            this.btn_sanPham.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_laptop_50;
            this.btn_sanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanPham.Location = new System.Drawing.Point(5, 334);
            this.btn_sanPham.Name = "btn_sanPham";
            this.btn_sanPham.Size = new System.Drawing.Size(245, 51);
            this.btn_sanPham.TabIndex = 5;
            this.btn_sanPham.Text = "     Sản phẩm";
            this.btn_sanPham.UseVisualStyleBackColor = false;
            this.btn_sanPham.Click += new System.EventHandler(this.btn_mayTinh_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_bill_50;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(5, 391);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(245, 52);
            this.btn_bill.TabIndex = 6;
            this.btn_bill.Text = "     Hóa đơn";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_nhaCungCap
            // 
            this.btn_nhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_nhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_nhaCungCap.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_supplier_50;
            this.btn_nhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaCungCap.Location = new System.Drawing.Point(5, 449);
            this.btn_nhaCungCap.Name = "btn_nhaCungCap";
            this.btn_nhaCungCap.Size = new System.Drawing.Size(245, 52);
            this.btn_nhaCungCap.TabIndex = 7;
            this.btn_nhaCungCap.Text = "      Nhà cung cấp";
            this.btn_nhaCungCap.UseVisualStyleBackColor = false;
            this.btn_nhaCungCap.Click += new System.EventHandler(this.btn_nhaCungCap_Click);
            // 
            // btn_khuyenMai
            // 
            this.btn_khuyenMai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_khuyenMai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_khuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khuyenMai.ForeColor = System.Drawing.Color.White;
            this.btn_khuyenMai.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_sale_50;
            this.btn_khuyenMai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenMai.Location = new System.Drawing.Point(5, 507);
            this.btn_khuyenMai.Name = "btn_khuyenMai";
            this.btn_khuyenMai.Size = new System.Drawing.Size(245, 54);
            this.btn_khuyenMai.TabIndex = 8;
            this.btn_khuyenMai.Text = "     Khuyến mãi";
            this.btn_khuyenMai.UseVisualStyleBackColor = false;
            this.btn_khuyenMai.Click += new System.EventHandler(this.btn_khuyenMai_Click);
            // 
            // btn_baoCaoThongKe
            // 
            this.btn_baoCaoThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_baoCaoThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_baoCaoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baoCaoThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_baoCaoThongKe.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_chart_50;
            this.btn_baoCaoThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baoCaoThongKe.Location = new System.Drawing.Point(5, 567);
            this.btn_baoCaoThongKe.Name = "btn_baoCaoThongKe";
            this.btn_baoCaoThongKe.Size = new System.Drawing.Size(245, 53);
            this.btn_baoCaoThongKe.TabIndex = 9;
            this.btn_baoCaoThongKe.Text = "      Báo cáo thống kê";
            this.btn_baoCaoThongKe.UseVisualStyleBackColor = false;
            this.btn_baoCaoThongKe.Click += new System.EventHandler(this.btn_baoCaoThongKe_Click);
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.pnlheader.Controls.Add(this.pbHide);
            this.pnlheader.Controls.Add(this.lbl_quyen);
            this.pnlheader.Controls.Add(this.lbl_tenTK);
            this.pnlheader.Controls.Add(this.label1);
            this.pnlheader.Controls.Add(this.lbl_dataTime);
            this.pnlheader.Controls.Add(this.lbl_xinChao);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(253, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1003, 69);
            this.pnlheader.TabIndex = 0;
            this.pnlheader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            // 
            // pbHide
            // 
            this.pbHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbHide.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.minimize;
            this.pbHide.Location = new System.Drawing.Point(961, 0);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(42, 69);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHide.TabIndex = 28;
            this.pbHide.TabStop = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // lbl_quyen
            // 
            this.lbl_quyen.AutoSize = true;
            this.lbl_quyen.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_quyen.ForeColor = System.Drawing.Color.White;
            this.lbl_quyen.Location = new System.Drawing.Point(126, 39);
            this.lbl_quyen.Name = "lbl_quyen";
            this.lbl_quyen.Size = new System.Drawing.Size(54, 21);
            this.lbl_quyen.TabIndex = 27;
            this.lbl_quyen.Text = "label4";
            // 
            // lbl_tenTK
            // 
            this.lbl_tenTK.AutoSize = true;
            this.lbl_tenTK.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_tenTK.ForeColor = System.Drawing.Color.White;
            this.lbl_tenTK.Location = new System.Drawing.Point(126, 10);
            this.lbl_tenTK.Name = "lbl_tenTK";
            this.lbl_tenTK.Size = new System.Drawing.Size(54, 21);
            this.lbl_tenTK.TabIndex = 26;
            this.lbl_tenTK.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quyền: ";
            // 
            // lbl_dataTime
            // 
            this.lbl_dataTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dataTime.AutoSize = true;
            this.lbl_dataTime.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_dataTime.ForeColor = System.Drawing.Color.White;
            this.lbl_dataTime.Location = new System.Drawing.Point(951, 22);
            this.lbl_dataTime.Name = "lbl_dataTime";
            this.lbl_dataTime.Size = new System.Drawing.Size(49, 21);
            this.lbl_dataTime.TabIndex = 24;
            this.lbl_dataTime.Text = "timer";
            // 
            // lbl_xinChao
            // 
            this.lbl_xinChao.AutoSize = true;
            this.lbl_xinChao.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_xinChao.ForeColor = System.Drawing.Color.White;
            this.lbl_xinChao.Location = new System.Drawing.Point(47, 10);
            this.lbl_xinChao.Name = "lbl_xinChao";
            this.lbl_xinChao.Size = new System.Drawing.Size(73, 21);
            this.lbl_xinChao.TabIndex = 2;
            this.lbl_xinChao.Text = "Xin chào";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Controls.Add(this.btn_quit);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(253, 718);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1003, 50);
            this.pnlFooter.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Liên hệ qua email: system2vn@gmail.com";
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_quit.BackgroundImage = global::QuanLyCuaHangMayTinh.Properties.Resources.logout;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(881, 0);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(122, 50);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(253, 69);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1003, 649);
            this.pnlContainer.TabIndex = 23;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.panel_move;
            // 
            // frm_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 768);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlheader);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLy_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Button btn_nhanVien;
        private System.Windows.Forms.Button btn_khachHang;
        private System.Windows.Forms.Button btn_sanPham;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_nhaCungCap;
        private System.Windows.Forms.Button btn_khuyenMai;
        private System.Windows.Forms.Button btn_baoCaoThongKe;
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lbl_dataTime;
        private System.Windows.Forms.Label lbl_xinChao;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Panel panel_move;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Button btn_banHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_quyen;
        private System.Windows.Forms.Label lbl_tenTK;
        private System.Windows.Forms.PictureBox pbHide;
    }
}