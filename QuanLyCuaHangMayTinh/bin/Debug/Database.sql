create database QuanLyCuaHangMayTinh;

create table TaiKhoan(
	MaTK int identity(1, 1),
	MaNV int not null,
	TaiKhoan nvarchar(50) not null,
	MatKhau nvarchar(50) not null,
	Quyen nvarchar(15) not null,
	constraint PK_MaTK Primary key(MaTK)
);
alter table TaiKhoan add constraint FK_MaNV foreign key(MaNV) references NhanVien(MaNV)
drop table TaiKhoan
insert into TaiKhoan values
(1, 'admin123', 'abc@123', 'Admin'),
('NV002', 'staff123', 'abc@123', 'Nhân viên'),
('NV003','staff456', 'abc@123', 'Nhân viên'),
('NV004','staff789', 'abc@123', 'Nhân viên')

select max(MaHD) from hoadon
	
select * from khachhang
select * from taikhoan
select nv.*, TaiKhoan, MatKhau, Quyen from NhanVien nv, taikhoan tk where nv.MaNV = tk.MaNV
select * from SanPham, loaisanpham 

create table khachHang(
	MaKH int identity(1, 1),
	TenKH nvarchar(150) not null,
	GT nvarchar(3) check(GT = N'Nam' or GT = N'Nữ') not null,
	DiaChi nvarchar(150) not null,
	SDT nvarchar(150) not null,
	TrangThai int check(TrangThai in(1, 0)) not null
	constraint PK_MaKH Primary key(MaKH)
);

drop table KhachHang
INSERT INTO KhachHang(TenKH,GT,DiaChi,SDT,TrangThai) VALUES
(N'Nguyễn Quang Huy','Nam','TP HCM','0909123456', 0),
(N'Nguyễn Đức Huy','Nam',N'Đà Lạt','0804448966', 0), 
(N'Trần Đức Minh','Nam',N'Kiên Giang','0899638741', 0),
(N'Lê Thanh Ba',N'Nữ',N'Châu Đốc','0867720628', 0),
(N'Trương Minh Nhựt','Nam',N'TP HCM','0909563685', 0),
(N'Phan Tấn Trung', 'Nam', N'Sa Đéc, Đồng Tháp', '0987654321', 0),
(N'Nguyễn Huyền Trang', N'Nữ', N'Thái Nguyên', '0123456789', 0),
(N'Nguyễn Hữu Thuận','Nam','TP HCM','0909123456', 0),
(N'Nguyễn Đức Duy','Nam',N'Đà Lạt','0804448966', 0), 
(N'Nguyễn Minh Tân','Nam',N'Cai lậy','0899638741', 0)

select * from taikhoan
update TaiKhoan set TaiKhoan = 'admin12345', matkhau = 'abc@123', quyen = 'admin' where manv = 2
create table NhanVien(
	MaNV int identity(1, 1),
	TenNV nvarchar(150) Unique not null,
	GT nvarchar(3) not null,
	DiaChi nvarchar(150) not null,
	SDT nvarchar(150) not null,
	Luong float not null,
	Anh nvarchar(200) not null,
	TrangThai int check(TrangThai in(1, 0)) not null
	constraint PK_MaNV Primary key(MaNV)
);

select * from khachhang
drop table NhanVien
INSERT INTO NhanVien(TenNV,GT,DiaChi,SDT,Luong,Anh,TrangThai) VALUES
(N'Nguyễn Phú Vinh',N'Nam',N'TP HCM','0968837568',800000, 'images/noneImage.jpg', 1),

create Table HoaDon (
  MaHD int identity(1, 1),
  MaNV int not null,
  MaKH int not null,
  NgayLap date not null,
  TongHD float not null,
  MaKM int,
  constraint PK_MaHD Primary key(MaHD)
);
alter table HoaDon add constraint FK_MaNV_NHANVIEN foreign key(MaNV) references NhanVien(MaNV)
alter table HoaDon add constraint FK_MaKH_NHANVIEN foreign key(MaKH) references KhachHang(MaKH)
alter table HoaDon add constraint FK_MaKM_HoaDon foreign key(MaKM) references KhuyenMai(MaKM)
alter table HoaDon drop constraint  FK_MaKM_HoaDon
drop table HoaDon
insert into HoaDon values
(1, 1, '07/05/2023', 18990000, 1),
(1, 1, '07/05/2023', 18990000, 0),
('NV010', 2, '06/05/2023', 18499000, 'Không'),
('NV001', 3, '07/05/2023', 24690000, 'Không'),
('NV002', 4, '06/05/2023', 36990000, 'Không'),
('NV003', 5, '07/05/2023', 27990000, 'Không'),
('NV005', 6, '01/05/2023', 33990000, 'Không'),
('NV005', 7, '02/05/2023', 27990000, 'Không'),
('NV004', 8, '01/05/2023', 15490000, 'Không'),
('NV008', 9, '07/05/2023', 26490000, 'Không'),
('NV009', 10, '05/05/2023', 18499000, 'Không')


create Table CTHD (
  MaCTHD int identity(1, 1),
  MaHD int not null,
  MaSP int not null,
  SoLuong int not null,
  DonGia float not null
  constraint PK_MaCTHD Primary key(MaCTHD)
)
alter table CTHD add constraint FK_MaHD_CTHD foreign key(MaHD) references HoaDon(MaHD)
alter table CTHD add constraint FK_MaSP_CTHD foreign key(MaSP) references SanPham(MaSP)
alter table CTHD drop constraint FK_MaSP_CTHD
drop table CTHD
insert into CTHD values
(4, 4, 1, 18990000),
(2, 1, 1, 18499000),
(3, 6, 1, 24690000),
(4, 8, 1, 36990000),
(5, 2, 1, 27990000),
(6, 3, 1, 33990000),
(7, 2, 1, 27990000),
(8, 9, 1, 15490000),
(9, 5, 1, 26490000),
(10, 10, 1, 18499000)

drop table LoaiSanPham
create Table LoaiSanPham (
  MaLoai int identity(1, 1),
  TenLoaiSanPham nvarchar(15) not null,
  constraint PK_MaLoai Primary key(MaLoai)
)
select GiaTriGiam from KhuyenMai where TenKM = 'qweqweqwe'
insert into LoaiSanPham values
(N'Gaming'),
(N'Sinh viên'),
(N'Thiết kế đồ họa'),
(N'Mỏng nhẹ'),
(N'Văn phòng'),
(N'Bàn phím'),
(N'CPU'),
(N'SSD'),
(N'HDD'),
(N'RAM')

= 
create Table SanPham (
  MaSP int identity(1, 1),
  MaLoai int not null,
  MaNCC nvarchar(15) not null,
  TenSP nvarchar(150) not null, 
  SlTon int not null,
  DonGia float not null,
  MoTa nvarchar(250) not null,
  AnhSP nvarchar(200) not null,
  TrangThai int check(TrangThai in(1, 0)) not null,
  constraint PK_MaSP Primary key(MaSP)
)
select * from sanpham
alter table SanPham add constraint FK_MaLoai_SanPham foreign key(MaLoai) references LoaiSanPham(MaLoai)
alter table SanPham add constraint FK_MaNCC_SanPham foreign key(MaNCC) references NhaCungCap(MaNCC)
alter table SanPham drop constraint FK_MaLoai_SanPham
drop table SanPham
insert into SanPham values
(7, 'NCC001', N'MacBook Air 13 2020 M1', 23, 18499000, N'13.3 inch, 2560 x 1600 Pixels, IPS, IPS LCD LED Backlit, True Tone, Apple, M18 GB, LPDDR4SSD 256 GB,Apple M1 GPU 7 nhân', 'images/macbook1.jpg', 1),
(7, 'NCC001', N'MacBook Air M2 2022', 12, 27990000, N'13.6 inch, 2560 x 1644 Pixels, IPS, 60 Hz, 500 nits, Liquid Retina, Apple, M2, 8 - Core, 8 GB, LPDDR4, 3200 MHz, SSD 256 GB, Apple M2 GPU 8 nhân', 'images/macbook2.jpg', 1),
(3, 'NCC002', N'Laptop Asus TUF Gaming', 17, 15490000, N'15.6 inch, 1920 x 1080 Pixels, IPS, 144 Hz, Anti-glare LED-backlit, Intel, Core i5, 10300H8 GB, DDR4, 2933 MHz, SSD 512 GB ,NVIDIA GeForce GTX 1650 4GB; Intel UHD Graphics', 'images/asus1.jpg', 1),
(3, 'NCC005', N'Laptop Lenovo Gaming IdeaPad 3', 20, 18990000, N'15.6 inch, 1920 x 1080 Pixels, IPS, 120 Hz, 250 nits, IPS LCD LED Backlit, True ToneIntel, Core i5, 11320H,8 GB, DDR4, 3200 MHz,SSD 512 GB,NVIDIA GeForce RTX 3050 4GB; Intel Iris Xe Graphics', 'images/lenovo1.jpg', 1),
(5, 'NCC003', N'Laptop Dell Inspiron 16 N5620', 8, 26490000, N'16.0 inch, 1920 x 1200 Pixels, WVA, 60 Hz, 250 nits, Anti - GlareIntel, Core i5, 1240P,16 GB, DDR4, 3200 MHz,SSD 512 GB,Intel Iris Xe Graphics', 'images/dell1.jpg', 1),
(5, 'NCC002', N'Laptop Asus Vivobook Pro', 21, 24690000, N'15.6 inch Chính:, 2880 x 1620 Pixels, OLED, 120 Hz, 600 nits, OLED Chính:AMD, Ryzen 5, 5600H,16 GB, DDR4, 3200 MHz,SSD 512 GB,NVIDIA GeForce RTX 3050 4GB; AMD Radeon Graphics', 'images/asus2.jpg', 1),
(3, 'NCC005', N'Laptop Lenovo Gaming Legion 5', 5, 33990000, N'15.6 inch, 2560 x 1440 Pixels, IPS, 165 Hz, 300 nits, IPS LCD LED Backlit, True Tone,Intel, Core i7, 12700H,16 GB, DDR5, 4800 MHz,SSD 512 GB,NVIDIA GeForce RTX 3060 6GB; Intel Iris Xe Graphics', 'images/lenovo2.jpg', 1),
(3, 'NCC006', N'Laptop Acer Predator Gaming Helios', 11, 36990000, N'15.6 inch, 2560 x 1440 Pixels, IPS, 165 Hz, Acer ComfyView LED-backlit,Intel, Core i9, 11900H,16 GB , LPDDR4, 3200 MHz,SSD 512 GB,NVIDIA GeForce RTX 3060 6GB; Intel UHD Graphics','images/acer1.jpg', 1),
(7, 'NCC008', N'Laptop Gigabyte U4 UD-50VN823SO', 15, 15490000, N'14.0 inch, 1920 x 1080 Pixels, IPS, Anti-glare LED-backlit,Intel, Core i5, 1155G7,16 GB, DDR4, 3200 MHz,SSD 512 GB,Intel Iris Xe Graphics', 'images/gigabyte1.jpg', 1),
(7, 'NCC001', N'MacBook Air 13 2021 M1', 23, 18499000, N'13.3 inch, 2560 x 1600 Pixels, IPS, IPS LCD LED Backlit, True Tone, Apple, M18 GB, LPDDR4SSD 256 GB,Apple M1 GPU 7 nhân', 'images/macbook1.jpg', 1)

alter table sanpham drop column KhuyenMai

create Table NhaCungCap (
  MaNCC nvarchar(15),
  TenNCC nvarchar(150),
  DiaChi nvarchar(150),
  LienHe nvarchar(150),
  PhotoUrl nvarchar(200)
  constraint PK_MaNCC Primary key(MaNCC)
)

drop table NhaCungCap
insert into NhaCungCap values
('NCC001', 'Apple', N'87 Ni Sư Huỳnh Liên, Quận Tân Bình, Tp.Hồ Chí Minh', '0914159946', 'images/Apple.jpg'),
('NCC002', 'Asus',  N'39 Nguyễn Bỉnh Khiêm, Phường 1, Quận Gò Vấp, Tp.Hồ Chí Minh', '(028)71097868', 'images/Asus.jpg'),
('NCC003', 'Dell', N'5 Quốc Tử Giám, P. Văn Chương, Q.Đống Đa, Hà Nội', '(024)32051005', 'images/Dell.jpg'),
('NCC004', 'LG', N'299 Minh Khai, Từ Sơn, Bắc Ninh', '(024)32030188', 'images/LG.jpg'),
('NCC005', 'Levono', N'61 Thợ Nhuộm, Hoàn Kiếm, Hà Nội', '(022)23636088', 'images/Lenovo.jpg'),
('NCC006', 'Acer', N'CT4A Bắc Linh Đàm, Hà Nội', '0968864140', 'images/Acer.jpg'),
('NCC007', 'Intel', N'123 Cách mạng tháng 8, Q.Đống Đa, Hà Nội', '0914159946', 'images/Intel.jpg'),
('NCC008', 'Gigabyte', N'238 Nguyễn Trãi, Q.Ba Đình, Hà Nội', '0483325251', 'images/Gigabyte.jpg'),
('NCC009', 'Kingmax',  N'165 Nguyễn Biểu, Q5, TP.Hồ Chí Minh', '0836278125', 'images/Kingmax.jpg'),
('NCC010', 'Seagate', N'235 Võ Văn Tần, Q3, TP.Hồ Chí Minh', '0883233317', 'images/Seagate.jpg'),
('NCC011', 'Samsung',  N'238 Lạc Long Quân, Q.Tân Bình, TP.Hồ Chí Minh', '083456718', 'images/Samsung.jpg')

create Table KhuyenMai (
  MaKM int identity(1, 1),
  TenKM nvarchar(150) not null,
  GiaTriGiam int not null,
  NgayBatDau datetime not null,
  NgayKetThuc datetime not null,
  TrangThai int not null
  constraint PK_MaKM Primary key(MaKM)
);
drop table KhuyenMai
insert into KhuyenMai values('QWEQWEQWE', 30, 04-06-2023, 01-07-2023, 1);

















