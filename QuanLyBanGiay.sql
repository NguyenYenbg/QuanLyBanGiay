go
use master
go
if exists (select name from sys.databases where name='QuanLyBanGiay')
	drop database QuanLyBanGiay
go
create database QuanLyBanGiay
go
use QuanLyBanGiay

go
create table DanhMuc
(
	MaDM int identity primary key not null,
	TenDM nvarchar(50),
	MoTa ntext,
	NgayTao date default getdate(),
	NgaySua date default null
)

go
create table NhaCC
(
	MaNCC int identity primary key not null,
	TenNCC nvarchar(50),
	SDT bigint,
	DiaChi nvarchar(150)
)

go 
create table SanPham
(
	MaSP int identity primary key not null,
	TenSP nvarchar(50),
	AnhSP nvarchar(200),
	GiaSP int,
	KichCo int,
	MauSac nvarchar(200),
	LoaiGiay nvarchar(5),--loại giày:nam 0, nữ 1
	SoLuong int,
	MoTa ntext,
	NgayTao date default getdate(),
	NgaySua date default null,
	MaDM int,
	MaNCC int,
	constraint fk_DanhMuc foreign key(MaDM) references DanhMuc(MaDM),
	constraint fk_NhaCC foreign key(MaNCC) references NhaCC(MaNCC)
)

go
create table NhanVien
(
	MaNV int identity primary key not null,
	UserName nvarchar(50),
	PassWord nvarchar(50),
	HoTenNV nvarchar(50),
	AnhNV nvarchar(200),
	GioiTinh nvarchar(5),
	SoDT int,
	DiaChi nvarchar(200),
	Email varchar(50),
	ViTri int,	--admin:1, Nhân viên:0
	NgayTao date default getdate(),
	NgaySua date default null
)

go
create table KhachHang
(
	MaKH int identity primary key not null,
	TenKH nvarchar(50),
	SDT bigint,
	DiaChi nvarchar(200)
)

go 
create table HoaDon
(
	MaHD int identity primary key not null,
	NgayLap datetime default getdate(),
	MaKH int not null,
	MaNV int not null,
	constraint fk_KhachHang foreign key(MaKH) references Khachhang(MaKH),
	constraint fk_NhanVien foreign key(MaNV) references NhanVien(MaNV)
)

go
create table CTHoaDon
(
	MaHD int not null,
	MaSP int not null,
	SLBan int
	constraint pk_CTHoaDon primary key(MaHD, MaSP),
	constraint fk_HoaDon foreign key(MaHD) references HoaDon(MaHD),
	constraint fk_SanPham foreign key(MaSP) references SanPham(MaSP)
)


--
go	--NhaCC
insert into NhaCC(TenNCC,SDT,DiaChi) values(N'Adidas',02432006707,N'458 Minh Khai, Hai Bà Trưng, Hà Nội')
insert into NhaCC(TenNCC,SDT,DiaChi) values(N'Converse',1900886876,N'Số 03 Tạ Hiện, Hàng Buồm, Hoàn Kiếm, Hà Nội')
insert into NhaCC(TenNCC,SDT,DiaChi) values(N'Vans',02838181848,N'458 Minh Khai, Hai Bà Trưng, Hà Nội')
--insert into NhaCC(MaNCC,TenNCC,SDT,DiaChi) values(N'New Balance','1900 636 401',N'135 Hàng Bông, Hoàn Kiếm, Hà Nội')
--insert into NhaCC(MaNCC,TenNCC,SDT,DiaChi) values(N'Fila','024 2123 7742',N'Khu đô thị Vinhomes Ocean Park, Xã Kiêu Kỵ, Huyện Gia Lâm, Hà Nội')

go	 --Danh mục
insert into DanhMuc(TenDM, MoTa) values(N'Giày nam trẻ em',N'Các loại giày nam dành cho trẻ em')
insert into DanhMuc(TenDM, MoTa) values(N'Giày Nữ trẻ em',N'Các loại giày nữ dành cho trẻ em')
insert into DanhMuc(TenDM, MoTa) values(N'Giày nam thanh thiếu niên',N'Các loại giày nam dành cho thanh thiếu niên')
insert into DanhMuc(TenDM, MoTa) values(N'Giày nữ thanh thiếu niên',N'Các loại giày nữ dành cho thanh thiếu niên')
insert into DanhMuc(TenDM, MoTa) values(N'Giày thể thao',N'Các loại giày nữ dành cho thanh thiếu niên')

go	--Nhân viên
insert into NhanVien (UserName,PassWord, HoTenNV,GioiTinh,SoDT,DiaChi,Email,ViTri) values(N'ny',N'123',N'Nguyễn Thị Yến',N'Nữ',1234567800,N'BG',N'ny@gmail.com','0')
insert into NhanVien(UserName,PassWord, HoTenNV,GioiTinh,SoDT,DiaChi,Email,ViTri) values(N'NgocTam',N'123',N'Vũ Ngọc Tâm',N'Nữ',0839363593,N'Nam Định',N'ngoctamnd1504@gmail.com',1)
insert into NhanVien(UserName,PassWord, HoTenNV,GioiTinh,SoDT,DiaChi,Email,ViTri) values(N'TrongHiep',N'123',N'Vũ Trong Hiep',N'Nam',0839363593,N'Nam Định',N'ngoctamnd1504@gmail.com',0)


go	--Khách hàng
insert into KhachHang(TenKH,SDT,DiaChi) values(N'Trần Thị Ngọc',0345987387,N'Ninh Bình')
insert into KhachHang(TenKH,SDT,DiaChi) values(N'Nguyễn Lan Anh',0569875688,N'Bắc Ninh')

go	--Sản phẩm
insert into SanPham(TenSP, GiaSP, KichCo,MauSac, LoaiGiay, SoLuong,MoTa,MaDM,MaNCC)
	values(N'Giày Juno Trắng',500000,40,'255,0,0,0', N'Nam', 50,N'Giày Juno  viền trắng, giày thể thao nam 2021 full box bill',5,1)
	
insert into SanPham(TenSP, GiaSP, KichCo,MauSac, LoaiGiay, SoLuong,MoTa,MaDM,MaNCC)
	values(N'Giày Vans Caro',159000,38,'255,0,0,0', N'Nữ', 50,N'Giày Vans Caro lười viền trắng, giày thể thao nữ 2021 full box bill',5,3)

insert into SanPham(TenSP, GiaSP, KichCo,MauSac, LoaiGiay, SoLuong,MoTa,MaDM, MaNCC)
	values(N'Giày Vans Trắng',200000,37,'255,0,0,0', N'Nữ', 50,N'Giày Vans Caro lười viền trắng, giày thể thao nữ 2021 full box bill',5,2)



go	--Hóa đơn
insert into HoaDon(MaKH,MaNV) values(1,1)
insert into HoaDon( MaKH,MaNV) values(2,1)

go	--CT hóa đơn
insert into CTHoaDon(MaHD,MaSP,SLBan) values(1,1,5)
insert into CTHoaDon(MaHD,MaSP,SLBan) values(1,2,4)
insert into CTHoaDon(MaHD,MaSP,SLBan) values(2,2,2)


--
select *from DanhMuc
select *from SanPham
select *from NhanVien
select *from KhachHang
select *from NhaCC
select *from HoaDon
select *from CTHoaDon
