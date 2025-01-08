USE QuanLyBanGiay

GO
---------Nhân Viên
ALTER PROC Insert_NV
    (
      @MaNV VARCHAR(8) ,
      @HoTen NVARCHAR(50) ,
      @NgaySinh DATE ,
      @Sdt VARCHAR(15)
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhanVien WHERE MaNV=@MaNV
	IF(@CheckID=0)
    INSERT  INTO dbo.NhanVien
            ( MaNV, HoTen, NgaySinh, Sdt )
    VALUES  ( @MaNV, -- MaNV - varchar(8)
              @HoTen, -- HoTen - nvarchar(100)
              @NgaySinh, -- NgaySinh - date
              @Sdt  -- Sdt - varchar(15)
              )
GO
ALTER PROC Edit_NV
    (
      @MaNV VARCHAR(8) ,
      @HoTen NVARCHAR(50) ,
      @NgaySinh DATE ,
      @Sdt VARCHAR(15)
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhanVien WHERE MaNV=@MaNV
	IF(@CheckID=1)
	 UPDATE dbo.NhanVien SET MaNV=@MaNV,HoTen=@HoTen,Sdt=@Sdt WHERE MaNV=@MaNV
GO
---------Nhà Sản xuất
CREATE PROC Insert_NSX
    (
	@MaNSX  VARCHAR(8) ,
	@TenNSX  NVARCHAR(50) ,
	@QuocGia NVARCHAR(50) 
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaSanXuat WHERE MaNSX=@MaNSX
	IF(@CheckID=0)
	 INSERT INTO dbo.NhaSanXuat
	         ( MaNSX, TenNSX, QuocGia )
	 VALUES  ( @MaNSX , -- MaNSX - varchar(8)
	           @TenNSX, -- TenNSX - nvarchar(50)
	           @QuocGia  -- QuocGia - nvarchar(50)
	           )
GO
CREATE PROC Edit_NSX
    (
	@MaNSX  VARCHAR(8) ,
	@TenNSX  NVARCHAR(50) ,
	@QuocGia NVARCHAR(50) 
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaSanXuat WHERE MaNSX=@MaNSX
	IF(@CheckID=1)
	UPDATE dbo.NhaSanXuat SET MaNSX=@MaNSX ,TenNSX= @TenNSX ,QuocGia=@QuocGia 
GO
---------Nhà Cung Cấp
CREATE PROC Insert_NCC
    (
	@MaNCC VARCHAR(8) ,
	@TenNhaCungCap NVARCHAR(50) ,
	@DiaChi NVARCHAR(150) ,
	@Sdt VARCHAR(15)
	)
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC=@MaNCC
	IF(@CheckID=0)
	 INSERT INTO dbo.NhaCungCap
	         ( MaNCC, TenNhaCungCap, DiaChi, Sdt )
	 VALUES  ( @MaNCC, -- MaNCC - varchar(8)
	           @TenNhaCungCap, -- TenNhaCungCap - nvarchar(50)
	           @DiaChi, -- DiaChi - nvarchar(150)
	           @Sdt  -- Sdt - varchar(15)
	           )
GO
CREATE PROC Edit_NCC
    (
	@MaNCC VARCHAR(8) ,
	@TenNhaCungCap NVARCHAR(50) ,
	@DiaChi NVARCHAR(150) ,
	@Sdt VARCHAR(15)
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC=@MaNCC
	IF(@CheckID=1)
	UPDATE dbo.NhaCungCap SET MaNCC=@MaNCC ,TenNhaCungCap = @TenNhaCungCap ,DiaChi = @DiaChi,Sdt=@Sdt
GO
---------Loại giày
CREATE PROC Insert_LoaiGiay
    (
	@MaLoai VARCHAR(8) ,
	@TenLoa NVARCHAR(50) ,
	@GhiChu TEXT
	)
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.LoaiGiay WHERE MaLoai=@MaLoai
	IF(@CheckID=0)
	 INSERT INTO dbo.LoaiGiay
	         ( MaLoai, TenLoai, GhiChu )
	 VALUES  ( @MaLoai, -- MaLoai - varchar(8)
	           @TenLoa, -- TenLoai - nvarchar(50)
	           @GhiChu   -- GhiChu - text
	           )
GO
CREATE PROC Edit_LoaiGiay
(
	@MaLoai VARCHAR(8) ,
	@TenLoai NVARCHAR(50) ,
	@GhiChu TEXT
)
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.LoaiGiay WHERE MaLoai=@MaLoai
	IF(@CheckID=1)
	UPDATE dbo.LoaiGiay SET MaLoai=@MaLoai,TenLoai=@TenLoai,GhiChu=@GhiChu
GO