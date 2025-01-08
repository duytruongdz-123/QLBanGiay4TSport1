/*Quản lý bán giầy
1. Giầy (Mã giầy, Tên giầy, Mã NSX, Thông số KT, Mã loại, Giá thành, Mã Nhà cung cấp)
2. Nhà sản xuất (Mã NXS, Tên NSX, Quốc gia)
3. Nhà cung cấp (Mã Nhà cung cấp, Tên nhà cung cấp, Địa chỉ, Số điện thoại)
4. Loại giầy (Mã loại, Tên loại, Ghi chú)
5. Khách hàng (Mã khách hàng, Tên khách hàng, Địa chỉ, Số điện thoại)
6. Nhân viên (Mã nhân viên, Họ tên, Ngày sinh, Số điện thoại)
7. Phiếu nhập (Mã PN, Mã nhân viên, Mã nhà cung cấp, ngày nhập)
8. CT Phiếu nhập (Mã PN, Mã giầy, Số lượng, Đơn giá)
9. Phiếu xuất (Mã PX, Mã nhân viên, Mã khách hàng, ngày xuất)
10.CT Phiếu xuất (Mã PX, Mã giầy, Số lượng, Đơn giá)
*/





CREATE DATABASE QuanLyBanGiay
GO
USE QuanLyBanGiay

GO

CREATE TABLE NhanVien (
	MaNV VARCHAR(8) PRIMARY KEY,
	HoTen NVARCHAR(100),
	NgaySinh DATE NULL ,
	Sdt VARCHAR(15)
)
GO

CREATE TABLE NhaSanXuat(
	MaNSX VARCHAR(8) NOT NULL PRIMARY KEY,
	TenNSX NVARCHAR(50) ,
	QuocGia NVARCHAR(50)
)
GO
CREATE TABLE LoaiGiay(
	MaLoai VARCHAR(8) NOT NULL PRIMARY KEY,
	TenLoai NVARCHAR(50),
	GhiChu NVARCHAR(50)

)
GO

CREATE TABLE NhaCungCap(
	MaNCC VARCHAR(8) NOT NULL PRIMARY KEY,
	TenNhaCungCap NVARCHAR(50),
	DiaChi NVARCHAR(150),
	Sdt VARCHAR(15)
)
GO

CREATE TABLE KhachHang(
	MaKhachHang VARCHAR(8) NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(100) ,
	DiaChi NVARCHAR(150),
	Sdt VARCHAR(15),

	)
	GO
 CREATE TABLE Size
 (	
	MaSize VARCHAR(8) PRIMARY KEY,
	TenSize NVARCHAR(50) NULL
 )
 GO
CREATE TABLE Giay(
	MaGiay VARCHAR(8) NOT NULL PRIMARY KEY,
	TenGiay NVARCHAR(150) ,
	GiaThanh BIGINT ,
	ThongSoKT NVARCHAR(200),
	MaLoai VARCHAR(8) FOREIGN KEY(MaLoai) REFERENCES dbo.LoaiGiay(MaLoai),
	MaNSX VARCHAR(8) FOREIGN KEY(MaNSX) REFERENCES dbo.NhaSanXuat(MaNSX),
	MaNCC VARCHAR(8) FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
)
GO
CREATE TABLE CTGiay(
	MaGiay VARCHAR (8),
	MaSize VARCHAR(8),
	
	PRIMARY KEY(MaGiay,MaSize),
	FOREIGN KEY(MaGiay) REFERENCES Giay(MaGiay),
	FOREIGN KEY (MaSize) REFERENCES Size(MaSize)
)
CREATE TABLE PhieuNhap(
	MaPN VARCHAR(8) NOT NULL PRIMARY KEY,
	NgayNhap DATE,
	MaNV VARCHAR(8) FOREIGN KEY(MaNV) REFERENCES dbo.Nhanvien(MaNV),
	MaNCC VARCHAR(8) FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
) 
GO
CREATE TABLE CTPhieuNhap (
	MaPN VARCHAR(8) ,
	MaGiay VARCHAR(8),
	SoLuong INT,
	DonGia BIGINT,
	PRIMARY KEY(MaPN,MaGiay),
	FOREIGN KEY(MaPN) REFERENCES dbo.PhieuNhap(MaPN),
	FOREIGN KEY(MaGiay) REFERENCES dbo.Giay(MaGiay),
)
GO
CREATE TABLE PhieuXuat(
	MaPX VARCHAR(8) NOT NULL PRIMARY KEY,
	NgayXuat DATE,
	MaNV VARCHAR(8) FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	MaKhachHang VARCHAR(8) FOREIGN KEY(MaKhachHang) REFERENCES dbo.KhachHang(MaKhachHang),

)
GO
CREATE TABLE CTPhieuXuat (
	MaPX VARCHAR(8) ,
	MaGiay VARCHAR(8),
	SoLuong INT,
	DonGia BIGINT,
	PRIMARY KEY(MaPX,MaGiay),
	FOREIGN KEY(MaPX) REFERENCES dbo.PhieuXuat(MaPX),
	FOREIGN KEY(MaGiay) REFERENCES dbo.Giay(MaGiay),
)
GO

