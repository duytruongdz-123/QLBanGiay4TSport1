Create database QuanLyBanGiay
USE [QuanLyBanGiay]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTGiay](
	[MaGiay] [varchar](8) NOT NULL,
	[MaSize] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiay] ASC,
	[MaSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaPN] [varchar](8) NOT NULL,
	[MaGiay] [varchar](8) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [bigint] NULL,
	[ChiPhiPhatSinh] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaGiay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPhieuXuat](
	[MaPX] [varchar](8) NOT NULL,
	[MaGiay] [varchar](8) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [bigint] NULL,
	[ChiPhiPhatSinh] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC,
	[MaGiay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Giay](
	[MaGiay] [varchar](8) NOT NULL,
	[TenGiay] [nvarchar](150) NULL,
	[GiaThanh] [bigint] NULL,
	[MaLoai] [varchar](8) NULL,
	[MaNSX] [varchar](8) NULL,
	[MaNCC] [varchar](8) NULL,
	[ThongSoKT] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](8) NOT NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Sdt] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiGiay](
	[MaLoai] [varchar](8) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](8) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Sdt] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](8) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[Sdt] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNSX] [varchar](8) NOT NULL,
	[TenNSX] [nvarchar](50) NULL,
	[QuocGia] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [varchar](8) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNV] [varchar](8) NULL,
	[MaNCC] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [varchar](8) NOT NULL,
	[NgayXuat] [date] NULL,
	[MaNV] [varchar](8) NULL,
	[MaKhachHang] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Size](
	[MaSize] [varchar](8) NOT NULL,
	[TenSize] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PhieuNhapView] AS 
	SELECT MaPN,NgayNhap,TenNCC,HoTen
	FROM dbo.PhieuNhap
	INNER JOIN dbo.NhanVien ON NhanVien.MaNV = PhieuNhap.MaNV
	INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = PhieuNhap.MaNCC
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SanPhamView] AS
 SELECT  CTGiay.MaGiay,TenGiay,GiaThanh,TenLoai,LoaiGiay.MaLoai,ThongSoKT,TenNCC,TenNSX,TenSize
    FROM    dbo.Giay
            INNER JOIN dbo.LoaiGiay ON LoaiGiay.MaLoai = Giay.MaLoai
            INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = Giay.MaNCC
            INNER JOIN dbo.NhaSanXuat ON NhaSanXuat.MaNSX = Giay.MaNSX
            INNER JOIN (CTGiay  INNER JOIN dbo.Size ON Size.MaSize = dbo.CTGiay.MaSize ) ON CTGiay.MaGiay = Giay.MaGiay
GO
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G12', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G12', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G12', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G13', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G13', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G13', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G14', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G14', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G14', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G15', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G15', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G15', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G16', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G16', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G16', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G17', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G17', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G17', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G18', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G18', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G18', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G19', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G19', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G19', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G20', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G20', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G20', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G21', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G21', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G21', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G3', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G3', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G3', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G3', N'41')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G4', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G4', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G4', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G4', N'41')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G5', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G5', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G5', N'38')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G5', N'40')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G5', N'41')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G6', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G6', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G6', N'40')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G6', N'41')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G7', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G7', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G7', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G7', N'40')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G7', N'41')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G8', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G8', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G8', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G8', N'40')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G8', N'41')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G9', N'35')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G9', N'36')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G9', N'37')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G9', N'40')
INSERT [dbo].[CTGiay] ([MaGiay], [MaSize]) VALUES (N'G9', N'41')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G12', 10, 11000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G13', 10, 9000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G14', 10, 10000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G15', 10, 1750000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G16', 10, 2484000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G17', 10, 1800000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G3', 10, 7000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G4', 10, 20000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G5', 10, 33990000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G6', 10, 20500000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G7', 10, 19000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G8', 10, 34000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10001', N'G9', 10, 10000000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10021', N'G18', 10, 3200000, NULL)
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'10022', N'G19', 10, 1490000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX10', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX100', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX101', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX102', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX103', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX104', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX105', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX109', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX11', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX110', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX111', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX112', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX113', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX114', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX115', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX116', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX118', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX119', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX120', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX121', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX122', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX123', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX124', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX125', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX126', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX13', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX130', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX131', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX132', N'G14', 3, 1005000, 5000)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX133', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX134', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX135', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX136', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX137', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX139', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX14', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX140', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX141', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX142', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX143', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX144', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX145', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX146', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX147', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX15', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX151', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX152', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX153', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX154', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX155', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX156', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX157', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX158', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX16', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX160', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX161', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX162', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX163', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX164', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX165', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX166', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX167', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX168', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX17', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX172', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX173', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX174', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX175', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX176', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX177', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX178', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX179', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX18', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX181', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX182', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX184', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX185', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX186', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX187', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX188', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX189', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX19', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX194', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX195', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX196', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX197', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX198', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX199', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX20', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX200', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX202', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX204', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX205', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX206', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX207', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX209', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX21', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX210', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX214', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX215', N'G13', 2, 1800000, NULL)
GO
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX216', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX217', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX219', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX220', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX221', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX223', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX224', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX225', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX226', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX227', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX25', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX26', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX27', N'G14', 3, 1006000, 6000)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX28', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX29', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX30', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX31', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX32', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX34', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX35', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX36', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX37', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX38', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX39', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX4', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX40', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX41', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX42', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX46', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX47', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX48', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX49', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX5', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX50', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX51', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX52', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX53', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX55', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX56', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX57', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX58', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX59', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX6', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX60', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX61', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX62', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX63', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX67', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX68', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX69', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX7', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX70', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX71', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX72', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX73', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX74', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX76', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX77', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX78', N'G3', 1, 700000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX79', N'G4', 1, 2000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX8', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX80', N'G5', 3, 10197000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX81', N'G6', 2, 4100000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX82', N'G7', 2, 3800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX83', N'G8', 1, 3400000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX84', N'G9', 1, 1000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX88', N'G12', 2, 2200000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX89', N'G13', 2, 1800000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX9', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX90', N'G14', 3, 3000000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX91', N'G15', 3, 525000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX92', N'G16', 1, 248400, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX93', N'G17', 3, 540000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX94', N'G18', 2, 640000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX95', N'G19', 3, 447000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX97', N'G20', 2, 600000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX98', N'G21', 2, 218000, NULL)
INSERT [dbo].[CTPhieuXuat] ([MaPX], [MaGiay], [SoLuong], [DonGia], [ChiPhiPhatSinh]) VALUES (N'PX99', N'G3', 1, 700000, NULL)
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G12', N'Chuck Taylor All Start Dainty', 1100000, N'M1', N'NSX4', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G13', N'143990v', 900000, N'M1', N'NSX4', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G14', N'Dainty Canvas', 1000000, N'M1', N'NSX4', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G15', N'Đế vuông 7p dây chéo', 175000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G16', N'gót vuông đính đá Lilian', 248400, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G17', N'2p mũi tròn', 180000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G18', N'Gót trong quai nhựa  9p', 320000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G19', N'5p da mờ', 149000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G20', N'da mềm đế 10 p', 300000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G21', N'da bóng  5p', 109000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G22
', N' Vans Classic Slipon
', 1050000, N'M4', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G23
', N'Vans Baron
', 1200000, N'M4', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G24
', N'Vans Old Skool
', 1100000, N'M4', N'NSX4', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G25
', N'Vans Vaul Checker Slipon 
', 2200000, N'M1', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G26
', N'Vans Style 36
', 2400000, N'M1', N'NSX1', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G27
', N'Vans Kelly Green
', 1300000, N'M4', N'NSX2', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G28
', N'Vans Kelly Red
', 1450000, N'M1', N'NSX2', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G29
', N'Vans Checker Mix
', 1300000, N'M4', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G3', N'NMD SF', 700000, N'M1', N'NSX2', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G30
', N'Vans Thrasher Slip on
', 1250000, N'M1', N'NSX4', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G31
', N'Vans SK8 Old Skool
', 1400000, N'M1', N'NSX4', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G32
', N'Vans SK8- Supreme Skull Pile
', 4500000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G33
', N'Vans Pear of God
', 19800000, N'M4', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G34
', N'"Vans  
Authentic"
', 1100000, N'M4', N'NSX2', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G35
', N'Adidat Tubula
', 1500000, N'M1', N'NSX2', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G36
', N'Vans ChillVibes
', 1900000, N'M1', N'NSX1', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G37
', N'Chuck Taylor All Star
', 1500000, N'M4', N'NSX4', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G38
', N'Chuck Taylor All Star II
', 1200000, N'M4', N'NSX1', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G39
', N'Jack Purcell
', 1700000, N'M1', N'NSX2', N'NCC3', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G4', N'Stansmith Floral', 2000000, N'M1', N'NSX2', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G40
', N'One Star
', 1450000, N'M1', N'NSX2', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G41
', N'Star Chevron
', 1250000, N'M4', N'NSX2', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G42
', N'Vans Checker Slipon
', 1200000, N'M1', N'NSX1', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G5', N'NMD R2', 3399000, N'M1', N'NSX2', N'NCC1', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G6', N'Tubalar ', 2050000, N'M1', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G7', N'Gazelle', 1900000, N'M1', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G8', N'NMD XR1 Camo', 3400000, N'M1', N'NSX2', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[Giay] ([MaGiay], [TenGiay], [GiaThanh], [MaLoai], [MaNSX], [MaNCC], [ThongSoKT]) VALUES (N'G9', N' All Star Classic', 1000000, N'M1', N'NSX4', N'NCC2', N'Màu đỏ,Vải mịn,chất liệu vải, đế cao su,Khi thời tiết nóng lên bạn chỉ muốn xỏ chân ngay vào đôi giày thông thoáng, mát mẻ với quai mảnh đơn giản.
')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12001', N'Lê Mai Anh', N'Hà Nội', N'1667234123')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'120012', N'Lê Mai Anh Đức', N'Sơn Tây', N'01698934211')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12002', N'Nguyễn Phú Đăng', N'Hà Nội', N'1667234124')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12003', N'Nguyễn Thanh Điền', N'Hà Nội', N'1667234125')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12004', N'Nguyễn Ngọc Điển', N'Hà Nội', N'1667234126')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12005', N'Nguyễn Quốc Định', N'Hà Nội', N'1667234127')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12006', N'Lê Anh Đức', N'Hà Nội', N'1667234128')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12007', N'Trần Ngọc Đoàn', N'Ninh Bình', N'1667234129')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12008', N'Lê Minh Đông', N'Ninh Bình', N'1667234130')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12009', N'Trần Xuân Nam', N'Ninh Bình', N'1667234131')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12010', N'Trần Trung Đức', N'Ninh Bình', N'1667234132')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12011', N'Lại Đăng Giang', N'Hưng Yên', N'1667234133')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12012', N'Vũ Thế Trung Giáp', N'Hưng Yên', N'1667234134')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12013', N'Lương Thị Thanh Hà', N'Hưng Yên', N'1667234135')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12014', N'Nguyễn Hữu Hà', N'Hưng Yên', N'1667234136')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12015', N'Bùi Văn Hải', N'Hưng Yên', N'1667234137')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12016', N'Nguyễn Thanh Hải', N'Hưng Yên', N'1667234138')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12017', N'Phan Nguyên Hải', N'Nam Định', N'1667234139')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12018', N'Tống Thị Hạnh', N'Nam Định', N'1667234140')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12019', N'Trịnh Trung Hiếu', N'Nam Định', N'1667234141')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12020', N'Vũ Mạnh Hiếu', N'Nam Định', N'1667234142')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12021', N'Vũ Trọng Hiếu', N'Nam Định', N'1667234143')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12022', N'Lê Mai Anh', N'Nam Định', N'1667234144')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12023', N'Đặng Thị Thu Hiền', N'Nam Định', N'1667234145')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12024', N'Lê Mai Anh', N'Nam Định', N'1667234146')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12025', N'Nguyễn Duy Anh', N'Nam Định', N'1667234147')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12026', N'Phạm Thu Chi', N'Quảng Ninh', N'1667234148')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12027', N'Nguyễn Tiến Anh', N'Quảng Ninh', N'1667234149')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12028', N'Nguyễn Tuấn Anh', N'Quảng Ninh', N'1667234150')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12029', N'Phạm Trần Quyền Anh', N'Quảng Ninh', N'1667234151')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12030', N'Khổng Ngọc Loan', N'Quảng Ninh', N'1667234152')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12031', N'Hoàng Quốc Huy', N'Quảng Ninh', N'1667234153')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12032', N'Nguyễn Đức Anh', N'Bắc Ninh', N'1667234154')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12033', N'Phạm Xuân Bảo', N'Bắc Ninh', N'1667234155')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12034', N'Phùng Văn Bắc', N'Bắc Ninh', N'1667234156')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12035', N'Đặng Thị Thùy Biên', N'Bắc Ninh', N'1667234157')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12036', N'Nguyễn Văn Biển', N'Bắc Ninh', N'1667234158')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12037', N'Đinh Văn Binh', N'Bắc Ninh', N'1667234159')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12038', N'Bùi Hữu Bình', N'Bắc Ninh', N'1667234160')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12039', N'Đặng Trần Ngọc Châu', N'Bắc Ninh', N'1667234161')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12040', N'Khuất Đình Chiến', N'Thanh hóa', N'1667234162')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12041', N'Lê Đình Chinh', N'Thanh hóa', N'1667234163')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12042', N'Hoàng Quốc Huy', N'Thanh hóa', N'1667234164')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12043', N'Nguyễn Quốc Chưởng', N'Thanh hóa', N'1667234165')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12044', N'Vũ Chí Công', N'Thanh hóa', N'1667234166')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12045', N'Nguyễn Văn Cương', N'Thanh hóa', N'1667234167')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12046', N'Lê Văn Cường', N'Thanh hóa', N'1667234168')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12047', N'Nguyễn Văn Cường', N'Thanh hóa', N'1667234169')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12048', N'Phùng Văn Cường', N'Thanh hóa', N'1667234170')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12049', N'Mai Văn Diệu', N'Nghệ An', N'1667234171')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12050', N'Phạm Thị Thùy Dung', N'Nghệ An', N'1667234172')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12051', N'Nguyễn Đình Duy', N'Nghệ An', N'1667234173')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12052', N'Phạm Lâm Duy', N'Nghệ An', N'1667234174')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12053', N'Nguyễn Huyền Trang', N'Nghệ An', N'1667234175')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12054', N'Dương Trí Dũng', N'Nghệ An', N'1667234176')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12055', N'Phạm Thùy Dương', N'Nghệ An', N'1667234177')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12056', N'Nguyễn Văn Dũng', N'Nghệ An', N'1667234178')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12057', N'Trần Đình Dũng', N'Nghệ An', N'1667234179')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12058', N'Nguyễn Kiều Oanh', N'Hải Phòng', N'1667234180')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12059', N'Trần Quế Anh', N'Hải Phòng', N'1667234181')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12060', N'Nguyễn Thanh Dương', N'Hải Phòng', N'1667234182')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12061', N'Nguyễn Đình Đại', N'Hải Phòng', N'1667234183')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12062', N'Nguyễn Thanh Thúy', N'Hải Phòng', N'1667234184')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12063', N'Nông Thành Đạt', N'Hải Phòng', N'1667234185')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12064', N'Nguyễn Thị Phượng', N'Hải Phòng', N'1667234186')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12065', N'Phạm Trịnh Đạt', N'Hải Phòng', N'1667234187')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12066', N'Lê Thị Linh', N'Hải Phòng', N'1667234188')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12067', N'Lê Văn Điệp', N'Hải Phòng', N'1667234189')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12068', N'Đỗ Công Định', N'Hà Nội', N'1667234190')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12069', N'Trần Huy Định', N'Hà Nội', N'1667234191')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12070', N'Hoàng Ngọc Anh', N'Hà Nội', N'1667234192')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12071', N'Nguyễn Tài Duyên', N'Hà Nội', N'1667234193')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12072', N'Lâm Mỹ Lệ', N'Hà Nội', N'1667234194')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12073', N'Chu Thị Phương', N'Hà Nội', N'1667234195')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12074', N'Bùi Minh Tuệ', N'Hà Nội', N'1667234196')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12075', N'Bùi Thị Hà', N'Hà Nội', N'1667234197')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12076', N'Nguyễn Thị Thúy Hằng', N'Hà Nội', N'1667234198')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12077', N'Trần Lê Khánh Lộc', N'Hà Nội', N'1667234199')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12078', N'Ngô Lê Bảo Ngọc', N'Hà Nội', N'1667234200')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12079', N'Đoàn Thị Phương Lan', N'Hà Nội', N'1667234201')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12080', N'Nguyễn Thị Thanh Nhi', N'Hà Nội', N'1667234202')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12081', N'Nguyễn Thị Mỹ Hoa', N'Hà Nội', N'1667234203')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12082', N'Nguyễn Trường An', N'Hà Nội', N'1667234204')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12083', N'Trần Văn An', N'Hà Nội', N'1667234205')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12084', N'Trịnh Thị Thùy An', N'Hà Nội', N'1667234206')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12085', N'Nguyễn Đức Anh', N'Hà Nội', N'1667234207')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12086', N'Ngô Đình Phúc', N'Hà Nội', N'1667234208')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12087', N'Phạm Tuấn Anh', N'Hà Nội', N'1667234209')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12088', N'Phạm Việt Anh', N'Hà Nội', N'1667234210')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12089', N'Tạ Ngọc ánh', N'Hà Nội', N'1667234211')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12090', N'Lưu Xuân Bách', N'Hà Nội', N'1667234212')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12091', N'Đào Công Bình', N'Hà Nội', N'1667234213')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12092', N'Hoàng Phan Bình', N'Ninh Bình', N'1667234214')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12093', N'Trần Văn Châu', N'Ninh Bình', N'1667234215')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12094', N'Vũ Văn Chiên', N'Ninh Bình', N'1667234216')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12095', N'Đoàn Văn Chinh', N'Ninh Bình', N'1667234217')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12096', N'Tạ Trung Chính', N'Ninh Bình', N'1667234218')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12097', N'Lê Ngọc Linh', N'Ninh Bình', N'1667234219')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12098', N'Trần Huy Chương', N'Ninh Bình', N'1667234220')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12099', N'Nguyễn Duy Cương', N'Ninh Bình', N'1667234221')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12100', N'Trần Văn Cương', N'Ninh Bình', N'1667234222')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12101', N'Bùi Mạnh Cường', N'Ninh Bình', N'1667234223')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12102', N'Lê Trọng Cường', N'Ninh Bình', N'1667234224')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12103', N'Nguyễn Mạnh Cường', N'Ninh Bình', N'1667234225')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12104', N'Nguyễn Ngọc Cường', N'Ninh Bình', N'1667234226')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12105', N'Nguyễn Viết Cường', N'Ninh Bình', N'1667234227')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12106', N'Vũ Cao Cường', N'Hưng Yên', N'1667234228')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12107', N'Cao Văn Dũng', N'Hưng Yên', N'1667234229')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12108', N'Hoàng Lâm Anh', N'Hưng Yên', N'1667234230')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12109', N'Dương Quốc Dũng', N'Hưng Yên', N'1667234231')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12110', N'Nguyễn Quang Dũng', N'Hưng Yên', N'1667234232')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12111', N'Nguyễn Thế Dũng', N'Hưng Yên', N'1667234233')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12112', N'Nguyễn Trung Dũng', N'Hưng Yên', N'1667234234')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12113', N'Nguyễn Văn Dũng', N'Hưng Yên', N'1667234235')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12114', N'Trần Quang Dũng', N'Hưng Yên', N'1667234236')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12115', N'Trần Quang Dũng', N'Hưng Yên', N'1667234237')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12116', N'Hà Đại Dương', N'Hưng Yên', N'1667234238')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'12117', N'Lê Xuân Dương', N'Hưng Yên', N'1667234239')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [DiaChi], [Sdt]) VALUES (N'KHDEL', N'Đã bị xóa', N'Không có', NULL)
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'LGDEL', N'Không có loại', N'Loại đã bị xóa')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M1', N'Giày Sneakers', N'giày thể thao')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M2', N'Giày Búp Bê', N'hài')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M3', N'Giày Cao Gót', N'cao gót')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M4', N'Giày Đế Bằng', N'giay thấp')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M6', N'Dép Thời Trang', N'dép')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M7', N'Giày Công Sở', N'giày')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M8', N'Giày Lười', N'giày')
INSERT [dbo].[LoaiGiay] ([MaLoai], [TenLoai], [GhiChu]) VALUES (N'M9', N'Giày Bốt', N'bốt')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC1', N'Công ty TTHH Giày Nam Việt', N'Số D17/4A Đinh Đức Thiện, ấp 4, Tp. Hồ Chí Minh (TPHCM), Việt Nam', N'(08) 62684179')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC10', N'Công ty TNHH Giày Phúc Trang', N'Tổ 18 Phố Kiều Mai Cầu Diễn Q. Nam Từ Liêm, Hà Nội , Việt Nam', N'(84) 968102244')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC2', N'Công ty CP Quốc Tế Vip', N'Số 80, Đường Nguyễn Phong Sắc, P. Dịch Vọng, Q. Cầu Giấy, Hà Nội , Việt Nam', N'(04) 37932702')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC3', N'Công ty TNHH - MTV Giày Da An Ba', N'23A Đường số 1, KP 22, P. Bình Hưng Hòa A, Q.Bình Tân, Tp. Hồ Chí Minh (TPHCM) , Việt Nam', N'(84) 938499723')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC4', N'Công ty TNHH Giày Thái Dương', N'3/334 ấp Nhị Tân 1, X. Tân Thới Nhì, Hóc Môn, Tp. Hồ Chí Minh (TPHCM), Việt Nam', N'(08) 37132159')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC6', N'Công ty TNHH Lavieshoes', N'Số 31, D6 Khu Biệt Thự Saigon Pearl, 92 Nguyễn Hữu Cảnh, P. 22, Quận Bình Thạnh,', N'(84) 938479007')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC8', N'Công ty sản xuất giày dép Thành Luân', N'Thượng Yên, Phú Yên, Phú Xuyên, Hà Nội , Việt Nam', N'(84) 947263738')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCC9', N'Công ty Cổ Phần Cao Su Hà Nội', N'Tổ 13, P. Cầu Diễn, Q. Nam Từ Liêm, Hà Nội , Việt Nam', N' (04) 37640782')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Sdt]) VALUES (N'NCCDEL', N'Không có nhà cung cấp', N'NULL', N'NULL')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV1', N'nguyễn Ngọc Thúy Anh', CAST(N'1997-08-18' AS Date), N'01667234525')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV10', N'Đoàn Thị Phương Lan Hương', CAST(N'1983-05-07' AS Date), N'0964545219')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV11', N'Nguyễn Thị Thanh Nhi', CAST(N'1986-06-22' AS Date), N'0964545220')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV12', N'Nguyễn Thị Mỹ Hoa', CAST(N'1973-12-08' AS Date), N'0964545221')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV13', N'Nguyễn Trường An', CAST(N'1976-11-10' AS Date), N'0964545222')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV14', N'Trần Văn An', CAST(N'1997-02-04' AS Date), N'0964545223')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV15', N'Trịnh Thị Thùy An', CAST(N'1987-09-19' AS Date), N'0964545224')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV16', N'Nguyễn Đức Anh Vinh', CAST(N'1993-03-03' AS Date), N'0964545225')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV18', N'Phạm Việt Anh Anh', CAST(N'1981-06-05' AS Date), N'0964545227')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV19', N'Tạ Ngọc ánh', CAST(N'1987-01-11' AS Date), N'0964545228')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV2', N'Hoàng Ngọc Anh', CAST(N'1998-08-13' AS Date), N'973642633')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV20', N'Lưu Xuân Bách', CAST(N'1987-02-20' AS Date), N'964545229')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV22', N'Hoàng Hữu Huyên', CAST(N'2018-06-03' AS Date), N'01698934212')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV3', N'Nguyễn Tài Duyên', CAST(N'1997-02-04' AS Date), N'964545212')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV4', N'Lâm Mỹ Lệ', CAST(N'1997-02-04' AS Date), N'964545213')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV5', N'Chu Thị Phương', CAST(N'1982-09-05' AS Date), N'964545214')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV6', N'Bùi Minh Tuệ', CAST(N'1997-02-04' AS Date), N'964545215')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV7', N'Nguyễn Thị Thúy Hằng', CAST(N'1978-06-11' AS Date), N'964545216')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV8', N'Trần Lê Khánh Lộc', CAST(N'1979-05-06' AS Date), N'964545217')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NV9', N'Ngô Lê Bảo Ngọc', CAST(N'1997-02-04' AS Date), N'964545218')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [Sdt]) VALUES (N'NVDEL', N'Đã bị xóa', NULL, NULL)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSX1', N'Nike', N'Mỹ')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSX2', N'Adidas', N'Đức')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSX3', N'Jordan', N'Mỹ')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSX4', N'Converse  ', N'Mỹ')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSX6', N'Vans  ', N'Mỹ')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSX7', N'Under Armour', N'Mỹ')
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [QuocGia]) VALUES (N'NSXDEL', N'Không có nhà sản xuất', N'NULL')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10001', CAST(N'2023-12-13' AS Date), N'NV1', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10002', CAST(N'2024-01-01' AS Date), N'NV10', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10003', CAST(N'2024-02-01' AS Date), N'NV11', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10004', CAST(N'2024-03-01' AS Date), N'NVDEL', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10005', CAST(N'2024-04-01' AS Date), N'NV13', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10008', CAST(N'2024-07-01' AS Date), N'NV16', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10010', CAST(N'2024-09-01' AS Date), N'NV18', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10011', CAST(N'2023-01-10' AS Date), N'NV19', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10012', CAST(N'2023-02-10' AS Date), N'NV2', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10013', CAST(N'2023-03-10' AS Date), N'NV20', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10014', CAST(N'2023-04-10' AS Date), N'NV3', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10015', CAST(N'2023-05-10' AS Date), N'NV4', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10017', CAST(N'2023-07-10' AS Date), N'NV6', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10018', CAST(N'2023-08-10' AS Date), N'NV7', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10019', CAST(N'2023-09-10' AS Date), N'NV8', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10020', CAST(N'2023-10-10' AS Date), N'NV9', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10021', CAST(N'2023-11-11' AS Date), N'NV1', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10022', CAST(N'2023-11-12' AS Date), N'NV10', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10023', CAST(N'2023-11-13' AS Date), N'NV11', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10024', CAST(N'2023-08-21' AS Date), N'NV12', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10026', CAST(N'2023-08-22' AS Date), N'NV14', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10027', CAST(N'2023-08-23' AS Date), N'NV15', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10028', CAST(N'2023-08-24' AS Date), N'NV16', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10029', CAST(N'2023-08-25' AS Date), N'NVDEL', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10030', CAST(N'2023-09-15' AS Date), N'NV18', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10031', CAST(N'2023-09-16' AS Date), N'NV19', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10032', CAST(N'2023-09-17' AS Date), N'NV2', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10033', CAST(N'2023-09-15' AS Date), N'NV20', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10035', CAST(N'2023-09-17' AS Date), N'NV4', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10036', CAST(N'2023-10-10' AS Date), N'NV5', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10037', CAST(N'2023-10-11' AS Date), N'NV6', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10038', CAST(N'2023-10-12' AS Date), N'NV7', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10039', CAST(N'2023-10-13' AS Date), N'NV8', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10040', CAST(N'2023-10-10' AS Date), N'NV9', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10041', CAST(N'2023-10-11' AS Date), N'NV1', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10042', CAST(N'2023-10-12' AS Date), N'NV10', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10044', CAST(N'2023-12-20' AS Date), N'NV12', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10045', CAST(N'2023-12-21' AS Date), N'NV13', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10046', CAST(N'2023-12-22' AS Date), N'NV14', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10047', CAST(N'2023-12-23' AS Date), N'NV15', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10048', CAST(N'2023-12-24' AS Date), N'NV16', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10049', CAST(N'2023-12-20' AS Date), N'NVDEL', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10050', CAST(N'2023-12-21' AS Date), N'NV18', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10051', CAST(N'2023-12-22' AS Date), N'NV19', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10053', CAST(N'2023-12-24' AS Date), N'NV20', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10054', CAST(N'2024-01-05' AS Date), N'NV3', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10055', CAST(N'2024-01-06' AS Date), N'NV4', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10056', CAST(N'2024-01-07' AS Date), N'NV5', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10057', CAST(N'2024-01-08' AS Date), N'NV6', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10058', CAST(N'2024-01-09' AS Date), N'NV7', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10059', CAST(N'2024-01-05' AS Date), N'NV3', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10060', CAST(N'2024-01-06' AS Date), N'NV4', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10062', CAST(N'2024-01-08' AS Date), N'NV6', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10063', CAST(N'2024-01-09' AS Date), N'NV7', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10064', CAST(N'2024-01-05' AS Date), N'NV3', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10065', CAST(N'2024-01-06' AS Date), N'NV4', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10066', CAST(N'2024-01-07' AS Date), N'NV5', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10067', CAST(N'2024-01-08' AS Date), N'NV6', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10068', CAST(N'2024-01-09' AS Date), N'NV7', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10069', CAST(N'2024-02-25' AS Date), N'NVDEL', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10071', CAST(N'2024-02-27' AS Date), N'NV19', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10072', CAST(N'2024-02-28' AS Date), N'NV2', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10073', CAST(N'2024-02-25' AS Date), N'NVDEL', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10074', CAST(N'2024-02-26' AS Date), N'NV18', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10075', CAST(N'2024-02-27' AS Date), N'NV19', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10076', CAST(N'2024-02-28' AS Date), N'NV2', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10077', CAST(N'2024-02-25' AS Date), N'NVDEL', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10078', CAST(N'2024-02-26' AS Date), N'NV18', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10080', CAST(N'2024-02-07' AS Date), N'NV2', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10081', CAST(N'2024-03-10' AS Date), N'NV1', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10082', CAST(N'2024-03-11' AS Date), N'NV10', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10083', CAST(N'2024-03-12' AS Date), N'NV11', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10084', CAST(N'2024-03-13' AS Date), N'NV12', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10085', CAST(N'2024-03-10' AS Date), N'NV13', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10086', CAST(N'2024-03-11' AS Date), N'NV14', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10087', CAST(N'2024-03-12' AS Date), N'NV15', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10089', CAST(N'2024-03-10' AS Date), N'NVDEL', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10090', CAST(N'2024-03-11' AS Date), N'NV18', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10091', CAST(N'2024-03-12' AS Date), N'NV19', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10092', CAST(N'2024-03-13' AS Date), N'NV2', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10093', CAST(N'2024-03-28' AS Date), N'NV20', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10094', CAST(N'2024-03-29' AS Date), N'NV3', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10095', CAST(N'2024-03-30' AS Date), N'NV4', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10096', CAST(N'2024-03-31' AS Date), N'NV5', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10098', CAST(N'2024-04-02' AS Date), N'NV7', N'NCC8')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10099', CAST(N'2024-04-03' AS Date), N'NV8', N'NCC9')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10100', CAST(N'2024-03-28' AS Date), N'NV9', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10101', CAST(N'2024-03-29' AS Date), N'NV16', N'NCC10')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10102', CAST(N'2024-03-30' AS Date), N'NVDEL', N'NCC2')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10103', CAST(N'2024-03-31' AS Date), N'NV18', N'NCC3')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10104', CAST(N'2024-04-01' AS Date), N'NV19', N'NCC4')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'10105', CAST(N'2024-04-02' AS Date), N'NV2', N'NCC6')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'11111', CAST(N'2024-04-25' AS Date), N'NV11', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'111111', CAST(N'2024-04-21' AS Date), N'NV1', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'1212121', CAST(N'2024-04-25' AS Date), N'NV1', N'NCC1')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNV], [MaNCC]) VALUES (N'PNDEL', CAST(N'2024-04-25' AS Date), N'NVDEL', N'NCCDEL')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX1', CAST(N'2023-12-13' AS Date), N'NV1', N'12001')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX10', CAST(N'2024-09-01' AS Date), N'NV18', N'12010')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX100', CAST(N'2024-03-28' AS Date), N'NV9', N'12061')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX101', CAST(N'2024-03-29' AS Date), N'NV16', N'12062')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX102', CAST(N'2024-03-30' AS Date), N'NVDEL', N'12063')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX103', CAST(N'2024-05-16' AS Date), N'NV20', N'12064')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX104', CAST(N'2024-05-17' AS Date), N'NV19', N'12065')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX105', CAST(N'2024-04-02' AS Date), N'NV2', N'12066')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX106', CAST(N'2024-05-17' AS Date), N'NV12', N'12061')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX107', CAST(N'2023-12-22' AS Date), N'NV1', N'12062')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX108', CAST(N'2024-05-18' AS Date), N'NV10', N'12061')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX109', CAST(N'2023-12-24' AS Date), N'NV11', N'12062')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX11', CAST(N'2023-01-10' AS Date), N'NV19', N'12011')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX110', CAST(N'2023-12-20' AS Date), N'NV12', N'12061')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX111', CAST(N'2023-12-21' AS Date), N'NV13', N'12062')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX112', CAST(N'2023-12-22' AS Date), N'NV14', N'12061')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX113', CAST(N'2023-12-23' AS Date), N'NV15', N'12062')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX114', CAST(N'2023-12-24' AS Date), N'NV16', N'12067')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX115', CAST(N'2024-01-05' AS Date), N'NVDEL', N'12068')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX116', CAST(N'2024-01-06' AS Date), N'NV18', N'12069')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX117', CAST(N'2024-01-07' AS Date), N'NV19', N'12070')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX118', CAST(N'2024-01-08' AS Date), N'NV2', N'12071')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX119', CAST(N'2024-01-09' AS Date), N'NV20', N'12072')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX12', CAST(N'2023-02-10' AS Date), N'NV2', N'12001')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX120', CAST(N'2024-01-05' AS Date), N'NV3', N'12073')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX121', CAST(N'2024-01-06' AS Date), N'NV4', N'12074')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX122', CAST(N'2024-01-07' AS Date), N'NV5', N'12075')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX123', CAST(N'2024-01-08' AS Date), N'NV6', N'12076')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX124', CAST(N'2024-01-09' AS Date), N'NV7', N'12077')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX125', CAST(N'2024-01-05' AS Date), N'NV8', N'12078')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX126', CAST(N'2024-01-06' AS Date), N'NV9', N'12079')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX127', CAST(N'2024-01-07' AS Date), N'NV1', N'12080')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX128', CAST(N'2024-01-08' AS Date), N'NV10', N'12081')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX129', CAST(N'2024-01-09' AS Date), N'NV11', N'12082')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX13', CAST(N'2023-03-10' AS Date), N'NV20', N'12002')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX130', CAST(N'2024-02-25' AS Date), N'NV12', N'12083')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX131', CAST(N'2024-02-26' AS Date), N'NV13', N'12084')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX132', CAST(N'2024-02-27' AS Date), N'NV14', N'12085')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX133', CAST(N'2024-02-28' AS Date), N'NV15', N'12086')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX134', CAST(N'2024-02-25' AS Date), N'NV16', N'12087')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX135', CAST(N'2024-02-26' AS Date), N'NVDEL', N'12088')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX136', CAST(N'2024-02-27' AS Date), N'NV18', N'12089')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX137', CAST(N'2024-02-28' AS Date), N'NV19', N'12090')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX138', CAST(N'2024-02-25' AS Date), N'NV2', N'12087')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX139', CAST(N'2024-02-26' AS Date), N'NV20', N'12088')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX14', CAST(N'2023-04-10' AS Date), N'NV3', N'12003')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX140', CAST(N'2024-02-27' AS Date), N'NV3', N'12089')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX141', CAST(N'2024-02-28' AS Date), N'NV4', N'12090')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX142', CAST(N'2024-03-10' AS Date), N'NV5', N'12087')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX143', CAST(N'2024-03-11' AS Date), N'NV6', N'12088')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX144', CAST(N'2024-03-12' AS Date), N'NV7', N'12089')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX145', CAST(N'2024-03-13' AS Date), N'NV8', N'12090')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX146', CAST(N'2024-03-10' AS Date), N'NV9', N'12091')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX147', CAST(N'2024-03-11' AS Date), N'NV1', N'12092')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX148', CAST(N'2024-03-12' AS Date), N'NV10', N'12093')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX149', CAST(N'2024-03-13' AS Date), N'NV11', N'12094')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX15', CAST(N'2023-05-10' AS Date), N'NV4', N'12004')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX150', CAST(N'2024-03-10' AS Date), N'NV12', N'12095')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX151', CAST(N'2024-03-11' AS Date), N'NV13', N'12096')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX152', CAST(N'2024-03-12' AS Date), N'NV14', N'12097')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX153', CAST(N'2024-03-13' AS Date), N'NV15', N'12098')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX154', CAST(N'2024-03-28' AS Date), N'NV16', N'12099')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX155', CAST(N'2024-03-29' AS Date), N'NVDEL', N'12100')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX156', CAST(N'2024-03-30' AS Date), N'NV18', N'12091')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX157', CAST(N'2024-03-31' AS Date), N'NV19', N'12092')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX158', CAST(N'2024-04-01' AS Date), N'NV2', N'12093')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX159', CAST(N'2024-04-02' AS Date), N'NV20', N'12094')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX16', CAST(N'2023-06-10' AS Date), N'NV5', N'12005')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX160', CAST(N'2024-04-03' AS Date), N'NV3', N'12095')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX161', CAST(N'2024-03-28' AS Date), N'NV4', N'12096')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX162', CAST(N'2024-03-29' AS Date), N'NV5', N'12097')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX163', CAST(N'2024-03-30' AS Date), N'NV6', N'12098')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX164', CAST(N'2024-03-31' AS Date), N'NV7', N'12099')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX165', CAST(N'2024-04-01' AS Date), N'NV3', N'12100')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX166', CAST(N'2024-04-02' AS Date), N'NV4', N'12101')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX167', CAST(N'2024-03-12' AS Date), N'NV5', N'12102')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX168', CAST(N'2024-03-13' AS Date), N'NV6', N'12103')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX169', CAST(N'2024-03-14' AS Date), N'NV7', N'12104')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX17', CAST(N'2023-07-10' AS Date), N'NV6', N'12006')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX170', CAST(N'2024-03-15' AS Date), N'NV3', N'12105')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX171', CAST(N'2024-03-16' AS Date), N'NV4', N'12106')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX172', CAST(N'2024-03-17' AS Date), N'NV5', N'12107')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX173', CAST(N'2024-03-18' AS Date), N'NV6', N'12108')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX174', CAST(N'2024-03-19' AS Date), N'NV7', N'12109')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX175', CAST(N'2024-03-20' AS Date), N'NVDEL', N'12110')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX176', CAST(N'2024-03-21' AS Date), N'NV18', N'12111')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX177', CAST(N'2024-03-22' AS Date), N'NV19', N'12112')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX178', CAST(N'2024-03-23' AS Date), N'NV2', N'12113')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX179', CAST(N'2024-03-24' AS Date), N'NVDEL', N'12114')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX18', CAST(N'2023-08-10' AS Date), N'NV7', N'12007')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX180', CAST(N'2024-03-25' AS Date), N'NV18', N'12115')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX181', CAST(N'2024-03-26' AS Date), N'NV19', N'12116')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX182', CAST(N'2024-03-27' AS Date), N'NV2', N'12117')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX184', CAST(N'2024-03-29' AS Date), N'NV18', N'12109')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX185', CAST(N'2024-03-30' AS Date), N'NV19', N'12110')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX186', CAST(N'2024-03-31' AS Date), N'NV2', N'12111')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX187', CAST(N'2024-04-01' AS Date), N'NV1', N'12112')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX188', CAST(N'2024-04-02' AS Date), N'NV10', N'12113')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX189', CAST(N'2024-04-03' AS Date), N'NV11', N'12114')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX19', CAST(N'2023-09-10' AS Date), N'NV8', N'12008')
GO
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX190', CAST(N'2024-04-04' AS Date), N'NV12', N'12115')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX191', CAST(N'2024-04-05' AS Date), N'NV13', N'12116')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX192', CAST(N'2024-04-06' AS Date), N'NV14', N'12117')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX194', CAST(N'2024-04-08' AS Date), N'NV16', N'12109')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX195', CAST(N'2024-04-09' AS Date), N'NVDEL', N'12110')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX196', CAST(N'2024-04-10' AS Date), N'NV18', N'12111')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX197', CAST(N'2024-02-01' AS Date), N'NV19', N'12112')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX198', CAST(N'2024-02-02' AS Date), N'NV2', N'12113')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX199', CAST(N'2024-02-03' AS Date), N'NV20', N'12114')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX2', CAST(N'2024-01-01' AS Date), N'NV10', N'12002')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX20', CAST(N'2023-10-10' AS Date), N'NV9', N'12009')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX200', CAST(N'2024-02-04' AS Date), N'NV3', N'12115')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX201', CAST(N'2024-02-05' AS Date), N'NV4', N'12116')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX202', CAST(N'2024-02-06' AS Date), N'NV5', N'12117')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX204', CAST(N'2024-02-08' AS Date), N'NV7', N'12114')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX205', CAST(N'2024-02-09' AS Date), N'NV8', N'12115')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX206', CAST(N'2024-02-10' AS Date), N'NV9', N'12116')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX207', CAST(N'2024-02-11' AS Date), N'NV16', N'12117')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX209', CAST(N'2024-02-13' AS Date), N'NV18', N'12114')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX21', CAST(N'2023-11-11' AS Date), N'NV1', N'12010')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX210', CAST(N'2024-02-14' AS Date), N'NV19', N'12115')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX211', CAST(N'2024-02-15' AS Date), N'NV2', N'12116')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX212', CAST(N'2024-02-16' AS Date), N'NV20', N'12117')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX214', CAST(N'2024-02-18' AS Date), N'NV10', N'12114')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX215', CAST(N'2024-02-19' AS Date), N'NV11', N'12115')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX216', CAST(N'2024-02-20' AS Date), N'NV12', N'12116')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX217', CAST(N'2024-02-21' AS Date), N'NV13', N'12117')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX219', CAST(N'2024-02-23' AS Date), N'NV15', N'12100')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX22', CAST(N'2023-11-12' AS Date), N'NV10', N'12011')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX220', CAST(N'2024-02-24' AS Date), N'NV16', N'12101')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX221', CAST(N'2024-02-25' AS Date), N'NVDEL', N'12102')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX222', CAST(N'2024-02-26' AS Date), N'NV18', N'12103')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX223', CAST(N'2024-02-27' AS Date), N'NV3', N'12104')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX224', CAST(N'2024-02-28' AS Date), N'NV2', N'12105')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX225', CAST(N'2024-03-01' AS Date), N'NV4', N'12106')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX226', CAST(N'2024-03-02' AS Date), N'NV3', N'12107')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX227', CAST(N'2024-03-03' AS Date), N'NV4', N'12108')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX23', CAST(N'2023-11-13' AS Date), N'NV11', N'12012')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX24', CAST(N'2023-08-21' AS Date), N'NV12', N'12013')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX25', CAST(N'2023-08-21' AS Date), N'NV13', N'12014')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX26', CAST(N'2023-08-22' AS Date), N'NV14', N'12015')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX27', CAST(N'2023-08-23' AS Date), N'NV15', N'12016')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX28', CAST(N'2023-08-24' AS Date), N'NV16', N'12017')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX29', CAST(N'2023-08-25' AS Date), N'NVDEL', N'12018')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX3', CAST(N'2024-02-01' AS Date), N'NV11', N'12003')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX30', CAST(N'2023-09-15' AS Date), N'NV18', N'12019')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX31', CAST(N'2023-09-16' AS Date), N'NV19', N'12020')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX32', CAST(N'2023-09-17' AS Date), N'NV2', N'12012')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX33', CAST(N'2023-09-15' AS Date), N'NV20', N'12013')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX34', CAST(N'2023-09-16' AS Date), N'NV3', N'12014')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX35', CAST(N'2023-09-17' AS Date), N'NV4', N'12015')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX36', CAST(N'2023-10-10' AS Date), N'NV5', N'12016')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX37', CAST(N'2023-10-11' AS Date), N'NV6', N'12017')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX38', CAST(N'2023-10-12' AS Date), N'NV7', N'12012')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX39', CAST(N'2023-10-13' AS Date), N'NV8', N'12013')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX4', CAST(N'2024-03-01' AS Date), N'NV12', N'12004')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX40', CAST(N'2023-10-10' AS Date), N'NV9', N'12014')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX41', CAST(N'2023-10-11' AS Date), N'NV1', N'12015')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX42', CAST(N'2023-10-12' AS Date), N'NV10', N'12016')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX43', CAST(N'2023-10-13' AS Date), N'NV11', N'12017')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX44', CAST(N'2023-12-20' AS Date), N'NV12', N'12012')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX45', CAST(N'2023-12-21' AS Date), N'NV13', N'12013')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX46', CAST(N'2023-12-22' AS Date), N'NV14', N'12014')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX47', CAST(N'2023-12-23' AS Date), N'NV15', N'12015')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX48', CAST(N'2023-12-24' AS Date), N'NV16', N'12016')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX49', CAST(N'2023-12-20' AS Date), N'NVDEL', N'12017')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX5', CAST(N'2024-04-01' AS Date), N'NV13', N'12005')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX50', CAST(N'2023-12-21' AS Date), N'NV18', N'12021')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX51', CAST(N'2023-12-22' AS Date), N'NV19', N'12022')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX52', CAST(N'2023-12-23' AS Date), N'NV2', N'12023')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX53', CAST(N'2023-12-24' AS Date), N'NV20', N'12024')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX54', CAST(N'2024-01-05' AS Date), N'NV3', N'12025')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX55', CAST(N'2024-01-06' AS Date), N'NV4', N'12026')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX56', CAST(N'2024-01-07' AS Date), N'NV5', N'12027')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX57', CAST(N'2024-01-08' AS Date), N'NV6', N'12028')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX58', CAST(N'2024-01-09' AS Date), N'NV7', N'12029')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX59', CAST(N'2024-01-05' AS Date), N'NV3', N'12030')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX6', CAST(N'2024-05-01' AS Date), N'NV14', N'12006')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX60', CAST(N'2018-01-06' AS Date), N'NV4', N'12031')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX61', CAST(N'2018-01-07' AS Date), N'NV5', N'12032')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX62', CAST(N'2018-01-08' AS Date), N'NV6', N'12033')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX63', CAST(N'2018-01-09' AS Date), N'NV7', N'12034')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX64', CAST(N'2018-01-05' AS Date), N'NV3', N'12035')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX65', CAST(N'2018-01-06' AS Date), N'NV4', N'12036')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX66', CAST(N'2018-01-07' AS Date), N'NV5', N'12037')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX67', CAST(N'2018-01-08' AS Date), N'NV6', N'12038')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX68', CAST(N'2018-01-09' AS Date), N'NV7', N'12039')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX69', CAST(N'2018-02-25' AS Date), N'NVDEL', N'12040')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX7', CAST(N'2018-06-01' AS Date), N'NV15', N'12007')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX70', CAST(N'2024-02-26' AS Date), N'NV18', N'12041')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX71', CAST(N'2024-02-27' AS Date), N'NV19', N'12042')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX72', CAST(N'2024-02-28' AS Date), N'NV2', N'12043')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX73', CAST(N'2024-02-25' AS Date), N'NVDEL', N'12044')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX74', CAST(N'2024-02-26' AS Date), N'NV18', N'12045')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX75', CAST(N'2024-02-27' AS Date), N'NV19', N'12046')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX76', CAST(N'2024-02-28' AS Date), N'NV2', N'12047')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX77', CAST(N'2024-02-25' AS Date), N'NVDEL', N'12048')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX78', CAST(N'2024-02-26' AS Date), N'NV18', N'12049')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX79', CAST(N'2024-02-27' AS Date), N'NV19', N'12050')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX8', CAST(N'2024-07-01' AS Date), N'NV16', N'12008')
GO
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX80', CAST(N'2024-02-28' AS Date), N'NV2', N'12051')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX81', CAST(N'2024-03-10' AS Date), N'NV1', N'12052')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX82', CAST(N'2024-03-11' AS Date), N'NV10', N'12053')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX83', CAST(N'2024-03-12' AS Date), N'NV11', N'12054')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX84', CAST(N'2024-03-13' AS Date), N'NV12', N'12055')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX85', CAST(N'2024-03-10' AS Date), N'NV13', N'12056')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX86', CAST(N'2024-03-11' AS Date), N'NV14', N'12057')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX87', CAST(N'2024-03-12' AS Date), N'NV15', N'12058')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX88', CAST(N'2024-03-13' AS Date), N'NV16', N'12059')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX89', CAST(N'2024-03-10' AS Date), N'NVDEL', N'12060')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX9', CAST(N'2024-08-01' AS Date), N'NVDEL', N'12009')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX90', CAST(N'2024-03-11' AS Date), N'NV18', N'12041')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX91', CAST(N'2024-03-12' AS Date), N'NV19', N'12042')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX92', CAST(N'2024-03-13' AS Date), N'NV2', N'12043')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX93', CAST(N'2024-03-28' AS Date), N'NV20', N'12044')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX94', CAST(N'2024-03-29' AS Date), N'NV3', N'12045')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX95', CAST(N'2024-03-30' AS Date), N'NV4', N'12046')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX96', CAST(N'2024-03-31' AS Date), N'NV5', N'12047')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX97', CAST(N'2024-04-01' AS Date), N'NV6', N'12041')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX98', CAST(N'2024-04-02' AS Date), N'NV7', N'12042')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PX99', CAST(N'2024-04-03' AS Date), N'NV8', N'12043')
INSERT [dbo].[PhieuXuat] ([MaPX], [NgayXuat], [MaNV], [MaKhachHang]) VALUES (N'PXDEL', CAST(N'2024-07-02' AS Date), N'NVDEL', N'KHDEL')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'35', N'cỡ 35')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'36', N'cỡ 36')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'37', N'cỡ 37')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'38', N'cỡ 38')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'39', N'cỡ 39')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'40', N'cỡ 40')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'41', N'cỡ 41')
INSERT [dbo].[Size] ([MaSize], [TenSize]) VALUES (N'42', N'cỡ 42')

INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau]) VALUES (N'admin', N'1')
ALTER TABLE [dbo].[CTGiay]  WITH CHECK ADD FOREIGN KEY([MaGiay])
REFERENCES [dbo].[Giay] ([MaGiay])
GO
ALTER TABLE [dbo].[CTGiay]  WITH CHECK ADD FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaGiay])
REFERENCES [dbo].[Giay] ([MaGiay])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[CTPhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaGiay])
REFERENCES [dbo].[Giay] ([MaGiay])
GO
ALTER TABLE [dbo].[CTPhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[Giay]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiGiay] ([MaLoai])
GO
ALTER TABLE [dbo].[Giay]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[Giay]  WITH CHECK ADD FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNSX])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataCTPhieuNhap]
AS
 BEGIN 
	SELECT MaPN,CTPhieuNhap.MaGiay,TenGiay,SoLuong,DonGia,ChiPhiPhatSinh
	FROM dbo.CTPhieuNhap
	JOIN dbo.Giay ON Giay.MaGiay = CTPhieuNhap.MaGiay
 END 

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataCTPhieuXuat]
AS
 BEGIN 
	SELECT * 
	FROM dbo.CTPhieuXuat INNER JOIN dbo.Giay ON Giay.MaGiay = CTPhieuXuat.MaGiay
 END 

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataLoaiGiay]
AS
	SELECT * FROM dbo.LoaiGiay
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataNhaCC]
AS
    SELECT *
    FROM   dbo.NhaCungCap

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataNhaSanXuat]
AS
    SELECT *
    FROM   dbo.NhaSanXuat

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataPhieuNhap]
AS
BEGIN
	SELECT MaPN,NgayNhap,TenNCC,HoTen
	FROM dbo.PhieuNhap
	INNER JOIN dbo.NhanVien ON NhanVien.MaNV = PhieuNhap.MaNV
	INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = PhieuNhap.MaNCC
END 

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataPhieuXuat]
AS
BEGIN
	SELECT MaPX,NgayXuat,HoTen,TenKhachHang
	FROM dbo.PhieuXuat
	INNER JOIN dbo.NhanVien ON NhanVien.MaNV = dbo.PhieuXuat.MaNV
	INNER JOIN dbo.KhachHang ON KhachHang.MaKH = PhieuXuat.MaKhachHang
END 

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataSanPham]
AS
    SELECT  CTGiay.MaGiay,TenGiay,GiaThanh,Giay.MaLoai,TenLoai,ThongSoKT,GhiChu,Giay.MaNCC,TenNCC,Giay.MaNSX,TenNSX,CTGiay.MaSize,TenSize
    FROM    dbo.Giay
            INNER JOIN dbo.LoaiGiay ON LoaiGiay.MaLoai = Giay.MaLoai
            INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = Giay.MaNCC
            INNER JOIN dbo.NhaSanXuat ON NhaSanXuat.MaNSX = Giay.MaNSX
            INNER JOIN (CTGiay  INNER JOIN dbo.Size ON Size.MaSize = dbo.CTGiay.MaSize ) ON CTGiay.MaGiay = Giay.MaGiay

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDataSanPhamView]
AS
    SELECT  CTGiay.MaGiay,TenGiay,GiaThanh,TenLoai,LoaiGiay.MaLoai,ThongSoKT,TenNCC,TenNSX,TenSize
    FROM    dbo.Giay
            INNER JOIN dbo.LoaiGiay ON LoaiGiay.MaLoai = Giay.MaLoai
            INNER JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = Giay.MaNCC
            INNER JOIN dbo.NhaSanXuat ON NhaSanXuat.MaNSX = Giay.MaNSX
            INNER JOIN (CTGiay  INNER JOIN dbo.Size ON Size.MaSize = dbo.CTGiay.MaSize ) ON CTGiay.MaGiay = Giay.MaGiay

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[Insert_TaiKhoan]
    (
      @TenTaiKhoan VARCHAR(50) ,
      @MatKhau VARCHAR(50) 
      
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.TaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
	IF(@CheckID=0)
    INSERT  INTO dbo.TaiKhoan
            ( TenTaiKhoan, MatKhau )
    VALUES  ( @TenTaiKhoan, -- MaNV - varchar(8)
              @MatKhau -- HoTen - nvarchar(100)
              
              )

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LocPhieuNhap](
	@StartDate DATE ,
	@EndDate DATE )
	AS
     SELECT * FROM PhieuNhapView WHERE NgayNhap BETWEEN  @StartDate AND @EndDate


GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchProduct](
	@MaGiay VARCHAR(8) ,
	@TenGiay NVARCHAR(150) ,
	@ThongSoKT NVARCHAR(500) ,
	@GiaThanh BIGINT ,
	@TenSize VARCHAR(8) ,
	@TenLoai VARCHAR(8) ,
	@TenNSX VARCHAR(8) ,
	@TenNCC VARCHAR(8) ,
	@case INT 
)
AS
	BEGIN
     IF(@case=0)  
	   SELECT * FROM SanPhamView WHERE MaGiay LIKE '%' + @MaGiay + '%' 
	 IF(@case=1)  
	   SELECT * FROM SanPhamView WHERE TenGiay LIKE '%' + @TenGiay + '%' 
	 IF(@case=2)  
	   SELECT * FROM SanPhamView WHERE ThongSoKT LIKE '%' + @ThongSoKT + '%' 
	 IF(@case=3)  
	   SELECT * FROM SanPhamView WHERE GiaThanh = @GiaThanh
	 IF(@case=4)  
	   SELECT * FROM SanPhamView WHERE TenSize LIKE '%' + @TenSize + '%' 
	 IF(@case=5)  
	   SELECT * FROM SanPhamView WHERE TenLoai LIKE '%' + @TenLoai + '%' 
	 IF(@case=6)  
	   SELECT * FROM SanPhamView WHERE TenNSX LIKE '%' + @TenNSX + '%' 
	 IF(@case=7)  
	   SELECT * FROM SanPhamView WHERE TenNCC LIKE '%' + @TenNCC + '%' 
	END 

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelCTPhieuNhap](@MaPN VARCHAR(10),@MaGiay VARCHAR(10))
AS
BEGIN 
		DELETE dbo.CTPhieuNhap WHERE MaPN=@MaPN AND MaGiay=@MaGiay
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelCTPhieuXuat](@MaPX VARCHAR(10),@MaGiay VARCHAR(10))
AS
BEGIN 
		DELETE dbo.CTPhieuXuat WHERE MaPX=@MaPX AND MaGiay=@MaGiay
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelGiay](@MaGay VARCHAR(10))
AS
BEGIN
DELETE dbo.CTPhieuXuat WHERE MaGiay=@MaGay
DELETE dbo.CTPhieuNhap WHERE MaGiay=@MaGay
DELETE dbo.CTGiay WHERE MaGiay=@MaGay
DELETE dbo.Giay WHERE MaGiay=@MaGay
End
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelKhachHang](
	@MaKH VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.KhachHang WHERE MaKH = @MaKH
	IF(@CheckID=1)
	UPDATE dbo.PhieuXuat SET MaKhachHang ='KHDEL' WHERE MaKhachHang = @MaKH
	DELETE dbo.KhachHang WHERE MaKH=@MaKH
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelLoaiGiay](@MaLoai VARCHAR(10))
AS
IF(@MaLoai<>'LGDEL')
BEGIN
	UPDATE dbo.Giay SET MaLoai='LGDEL' WHERE MaGiay=@MaLoai
	DELETE dbo.LoaiGiay WHERE MaLoai=@MaLoai
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelNhaCungCap](@MaNhaCC VARCHAR(10))
AS
IF(@MaNhaCC<>'NCCDEL')
BEGIN
	UPDATE dbo.Giay SET MaNCC='NCCDEL' WHERE MaNCC=@MaNhaCC
	DELETE dbo.CTPhieuNhap WHERE MaPN IN (SELECT MaPN FROM dbo.PhieuNhap WHERE  MaNCC=@MaNhaCC)
	DELETE  dbo.PhieuNhap  WHERE MaNCC=@MaNhaCC
	DELETE dbo.NhaCungCap WHERE MaNCC=@MaNhaCC
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelNhanVien](
	@MaNV VARCHAR(8)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhanVien WHERE MaNV = @MaNV
	IF(@CheckID=1)
	BEGIN
	UPDATE dbo.PhieuXuat SET MaNV = 'NVDEL' WHERE MaNV=@MaNV
	UPDATE dbo.PhieuNhap SET MaNV = 'NVDEL' WHERE MaNV=@MaNV
	DELETE dbo.NhanVien WHERE MaNV =@MaNV
	END
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelNhaSanXuat](@MaNSX VARCHAR(10))
AS
BEGIN 
	DECLARE @checkid INT 
		SELECT @checkid=COUNT (*) FROM dbo.NhaSanXuat WHERE MaNSX=@MaNSX
		IF (@checkid=1)
		BEGIN 
		UPDATE dbo.Giay SET MaNSX='NSXDEL' WHERE MaNSX=@MaNSX
		DELETE dbo.NhaSanXuat WHERE MaNSX=@MaNSX
        END 
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelPhieuNhap](@MaPN VARCHAR(10))
AS
BEGIN
	DECLARE @checkid INT 
		SELECT @checkid=COUNT (*) FROM dbo.PhieuNhap WHERE MaPN=@MaPN
		IF (@checkid=1)
		BEGIN 
		UPDATE dbo.CTPhieuNhap SET MaPN='NVDEL'
		WHERE MaPN=@MaPN
		DELETE dbo.PhieuNhap WHERE MaPN=@MaPN
        END 
	
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelPhieuXuat](@MaPX VARCHAR(10))
AS
BEGIN
		DECLARE @checkid INT 
		SELECT @checkid=COUNT (*) FROM dbo.PhieuXuat WHERE MaPX=@MaPX
		IF (@checkid=1)
		BEGIN 
		UPDATE dbo.CTPhieuXuat SET MaPX='PXDEL'
		WHERE MaPX=@MaPX
		DELETE dbo.PhieuXuat WHERE MaPX=@MaPX
        END 
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelTaiKhoan](
	@TenTaiKhoan VARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.TaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
	IF(@CheckID=1)
	DELETE dbo.TaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--1.INSERT table CTgiay
CREATE PROC [dbo].[sp_InsCTgiay](
	@MaGiay VARCHAR(9),
	@MaSize VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckMaGiay INT
	DECLARE @CheckMaSize INT
	SELECT  @CheckMaGiay = COUNT(*) FROM dbo.Giay WHERE MaGiay = @MaGiay
	SELECT  @CheckMaSize = COUNT(*) FROM dbo.Size WHERE MaSize = @MaSize
	IF(@CheckMaGiay=1 AND @CheckMaSize=1 )
	INSERT dbo.CTGiay
	        ( MaGiay, MaSize )
	VALUES  ( @CheckMaGiay, -- MaGiay - varchar(8)
	          @CheckMaSize  -- MaSize - varchar(8)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsCTPhieuNhap](
	@MaPN VARCHAR(9),
	@MaGiay VARCHAR(9),
	@SoLuong int,
	@DonGia BIGINT,
	@ChiPhiPhatSinh BIGINT
	)
AS
BEGIN
	DECLARE @CheckMaGiay INT
	DECLARE @CheckMaPN INT
	SELECT  @CheckMaPN = COUNT(*) FROM dbo.PhieuNhap WHERE MaPN =@MaPN
	SELECT  @CheckMaGiay = COUNT(*) FROM dbo.Giay WHERE MaGiay=@MaGiay
	IF(@CheckMaGiay=1 and @CheckMaPN=1)
	BEGIN 
		INSERT INTO dbo.CTPhieuNhap
		        ( MaPN ,
		          MaGiay ,
		          SoLuong ,
		          DonGia ,
		          ChiPhiPhatSinh
		        )
		VALUES  ( @MaPN , -- MaPN - varchar(8)
		          @MaGiay , -- MaGiay - varchar(8)
		          @SoLuong , -- SoLuong - int
		          @DonGia , -- DonGia - bigint
		          @ChiPhiPhatSinh  -- ChiPhiPhatSinh - bigint
		        )
				END 
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsCTPhieuXuat](
	@MaPX VARCHAR(9),
	@MaGiay VARCHAR(9),
	@SoLuong int,
	@DonGia BIGINT,
	@ChiPhiPhatSinh BIGINT
	)
AS
BEGIN
	DECLARE @CheckMaGiay INT
	DECLARE @CheckMaPN INT
	SELECT  @CheckMaPN = COUNT(*) FROM dbo.PhieuXuat WHERE MaPX =@MaPX
	SELECT  @CheckMaGiay = COUNT(*) FROM dbo.Giay WHERE MaGiay=@MaGiay
	IF(@CheckMaGiay=1 and @CheckMaPN=1)
	INSERT INTO dbo.CTPhieuXuat
	        ( MaPX ,
	          MaGiay ,
	          SoLuong ,
	          DonGia ,
	          ChiPhiPhatSinh
	        )
	VALUES
	  ( @MaPX, -- MaPX - varchar(8)
	          @MaGiay, -- MaGiay - varchar(8)
	          @SoLuong, -- SoLuong - int
	          @DonGia,  -- DonGia - bigint
			  @ChiPhiPhatSinh
	          )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===================

-- =====================
--1.INSERT table Giay
CREATE PROC [dbo].[sp_InsGiay](
	@MaGiay VARCHAR(9),
	@TenGiay NVARCHAR(50),
	@GiaThanh BIGINT,
	@MaLoai VARCHAR(9),
	@MaNSX VARCHAR(9),
	@MaNCC VARCHAR(9),
	@ThongSoKT NVARCHAR(500)
	)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @CheckMaLoai INT
	DECLARE @CheckNSX INT
	DECLARE @CheckNCC INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Giay WHERE MaGiay = @MaGiay
	SELECT  @CheckMaLoai = COUNT(*) FROM dbo.LoaiGiay WHERE MaLoai = @MaLoai
	SELECT  @CheckNSX = COUNT(*) FROM dbo.NhaSanXuat WHERE MaNSX = @MaNSX
	SELECT  @CheckNCC = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC
	IF(@CheckID=0 AND @CheckMaLoai=1 AND @CheckNSX=1 AND @CheckNCC=1)
	INSERT INTO dbo.Giay
	        ( MaGiay ,
	          TenGiay ,
	          GiaThanh ,
	          MaLoai ,
	          MaNSX ,
	          MaNCC ,
	          ThongSoKT
	        )
	VALUES  ( @MaGiay , -- MaGiay - varchar(8)
	          @TenGiay , -- TenGiay - nvarchar(150)
	          @GiaThanh , -- GiaThanh - bigint
	          @MaLoai , -- MaLoai - varchar(8)
	          @MaNSX , -- MaNSX - varchar(8)
	          @MaNCC , -- MaNCC - varchar(8)
	          @ThongSoKT -- ThongSoKT - nvarchar(200)
	        )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =====================

--1.INSERT table KhacHang
CREATE PROC [dbo].[sp_InsKhacHang](
	@MaKH VARCHAR(9),
	@TenKhachHang NVARCHAR(100),
	@DiaChi nVARCHAR(150),
	@Sdt VARCHAR(15)
	)

AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.KhachHang WHERE MaKH = @MaKH
	IF(@CheckID=0)
		INSERT INTO dbo.KhachHang
		        ( MaKH ,
		          TenKhachHang ,
		          DiaChi ,
		          Sdt
		        )
		VALUES  ( @MaKH , -- MaKhachHang - varchar(8)
		          @TenKhachHang , -- TenKhachHang - nvarchar(100)
		          @DiaChi , -- DiaChi - nvarchar(150)
		          @Sdt  -- Sdt - varchar(15)
		        )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =====================


--1.INSERT table LoaiGiay
CREATE PROC [dbo].[sp_InsLoaiGiay](
	@MaLoai VARCHAR(9),
	@TenLoai nVARCHAR(50),
	@GhiChu VARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.LoaiGiay WHERE MaLoai = @MaLoai
	IF(@CheckID=0)
	INSERT INTO dbo.LoaiGiay
	        ( MaLoai, TenLoai, GhiChu )
	VALUES  ( @MaLoai, -- MaLoai - varchar(8)
	          @TenLoai, -- TenLoai - nvarchar(50)
	          @GhiChu  -- GhiChu - nvarchar(50)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =====================

--1.INSERT table NhaCungCap
CREATE PROC [dbo].[sp_InsNhaCungCap](
	@MaNCC VARCHAR(9),
	@TenNCC NVARCHAR(50),
	@DiaChi NVARCHAR(150),
	@Sdt VARCHAR(15)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC
	IF(@CheckID=0)
	INSERT INTO dbo.NhaCungCap
	        ( MaNCC, TenNCC, DiaChi, Sdt )
	VALUES  ( @MaNCC, -- MaNCC - varchar(8)
	          @TenNCC, -- TenNCC - nvarchar(50)
	          @DiaChi, -- DiaChi - nvarchar(150)
	          @Sdt  -- Sdt - varchar(15)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =====================

--1.INSERT table NhanVien
CREATE PROC [dbo].[sp_InsNhanVien](
	@MaNV VARCHAR(9),
	@HoTen NVARCHAR(100),
	@NgaySinh DATE,
	@Sdt VARCHAR(15)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhanVien WHERE MaNV = @MaNV
	IF(@CheckID=0)
	INSERT INTO dbo.NhanVien
	        ( MaNV, HoTen, NgaySinh, Sdt )
	VALUES  ( @MaNV, -- MaNV - varchar(8)
	          @HoTen, -- HoTen - nvarchar(100)
	          @NgaySinh, -- NgaySinh - date
	          @Sdt  -- Sdt - varchar(15)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--1.INSERT table NhaSanXuat
CREATE PROC [dbo].[sp_InsNhaSanXuat](
	@MaNSX VARCHAR(9),
	@TenNSX NVARCHAR(50),
	@QuocGia NVARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaSanXuat WHERE MaNSX = @MaNSX
	IF(@CheckID=0)
	INSERT INTO dbo.NhaSanXuat
	        ( MaNSX, TenNSX, QuocGia )
	VALUES  ( @MaNSX, -- MaNSX - varchar(8)
	          @TenNSX, -- TenNSX - nvarchar(50)
	          @QuocGia  -- QuocGia - nvarchar(50)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsPhieuNhap](
	@MaPN VARCHAR(9),
	@NgayNhap DATE,
	@MaNV VARCHAR(9),
	@MaNCC VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @CheckMaNV INT
	DECLARE @CheckNCC INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhieuNhap WHERE MaPN =@MaPN
	SELECT  @CheckMaNV = COUNT(*) FROM dbo.NhanVien WHERE MaNV=@MaNV
	SELECT  @CheckNCC = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC
	IF(@CheckID=0 AND @CheckMaNV=1 AND @CheckNCC=1)
	INSERT INTO dbo.PhieuNhap
	        ( MaPN, NgayNhap, MaNV, MaNCC )
	VALUES  ( @MaPN, -- MaPN - varchar(8)
	          @NgayNhap, -- NgayNhap - date
	          @MaNV, -- MaNV - varchar(8)
	          @MaNCC  -- MaNCC - varchar(8)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsPhieuXuat](
	@MaPX VARCHAR(9),
	@NgayXuat DATE,
	@MaNV VARCHAR(9),
	@MaKH VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @CheckMaNV INT
	DECLARE @CheckMaKH INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhieuXuat WHERE MaPX =@MaPX
	SELECT  @CheckMaNV = COUNT(*) FROM dbo.NhanVien WHERE MaNV=@MaNV
	SELECT  @CheckMaKH = COUNT(*) FROM dbo.KhachHang WHERE MaKH=@MaKH
	IF(@CheckID=0 AND @CheckMaNV=1 AND @CheckMaKH=1)
	INSERT INTO dbo.PhieuXuat
	        ( MaPX, NgayXuat, MaNV, MaKhachHang )
	VALUES  ( @MaPX, -- MaPX - varchar(8)
	          @NgayXuat, -- NgayXuat - date
	          @MaNV, -- MaNV - varchar(8)
	          @MaKH  -- MaKhachHang - varchar(8)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =====================
--1.INSERT table Size
CREATE PROC [dbo].[sp_InsSize](
	@MaSize VARCHAR(9),
	@TenSize NVARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Size WHERE MaSize = @MaSize
	IF(@CheckID=0)
	INSERT INTO dbo.Size
	        ( MaSize, TenSize )
	VALUES  ( @MaSize, -- MaSize - varchar(8)
	          @TenSize  -- TenSize - nvarchar(50)
	          )
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.UPDATE table CTgiay
CREATE PROC [dbo].[sp_UpdateCTgiay](
	@MaGiay VARCHAR(9),
	@MaSize VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckMaGiay INT
	DECLARE @CheckMaSize INT
	SELECT  @CheckMaGiay = COUNT(*) FROM dbo.Giay WHERE MaGiay = @MaGiay
	SELECT  @CheckMaSize = COUNT(*) FROM dbo.Size WHERE MaSize = @MaSize
	IF(@CheckMaGiay=1 AND @CheckMaSize=1 )
	UPDATE dbo.CTGiay SET MaGiay=@MaGiay,MaSize=@MaSize WHERE MaGiay=@MaGiay AND MaSize=@MaSize
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateCTPhieuXuat](
	@MaPX VARCHAR(9),
	@MaGiay VARCHAR(9),
	@SoLuong int,
	@DonGia BIGINT,
	@ChiPhiPhatSinh BIGINT
	)
AS
BEGIN
	DECLARE @CheckMaGiay INT
	DECLARE @CheckMaPN INT
	SELECT  @CheckMaPN = COUNT(*) FROM dbo.PhieuXuat WHERE MaPX =@MaPX
	SELECT  @CheckMaGiay = COUNT(*) FROM dbo.Giay WHERE MaGiay=@MaGiay
	IF(@CheckMaGiay=1 and @CheckMaPN=1)
	UPDATE  dbo.CTPhieuXuat
	       SET MaPX =@MaPX,
	          MaGiay =@MaGiay,
	          SoLuong =@SoLuong,
	          DonGia =@DonGia,
	          ChiPhiPhatSinh=@ChiPhiPhatSinh
	       WHERE MaPX=@MaPX AND MaGiay=@MaGiay
           
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.UPDATE table NhaSanXuat
CREATE PROC [dbo].[sp_UpdateGiay](
	@MaGiay VARCHAR(9),
	@TenGiay NVARCHAR(50),
	@GiaThanh BIGINT,
	@MaLoai VARCHAR(9),
	@MaNSX VARCHAR(9),
	@MaNCC VARCHAR(9),
	@ThongSoKT NVARCHAR(500)
	)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @CheckMaLoai INT
	DECLARE @CheckNSX INT
	DECLARE @CheckNCC INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Giay WHERE MaGiay = @MaGiay
	SELECT  @CheckMaLoai = COUNT(*) FROM dbo.LoaiGiay WHERE MaLoai = @MaLoai
	SELECT  @CheckNSX = COUNT(*) FROM dbo.NhaSanXuat WHERE MaNSX = @MaNSX
	SELECT  @CheckNCC = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC
	IF(@CheckID=1 AND @CheckMaLoai=1 AND @CheckNSX=1 AND @CheckNCC=1)
	UPDATE dbo.Giay
	        SET MaGiay=@MaGiay ,
	          TenGiay=@TenGiay ,
	          GiaThanh =@GiaThanh,
	          MaLoai =@MaLoai,
	          MaNSX=@MaNSX ,
	          MaNCC =@MaNCC,
	          ThongSoKT=@ThongSoKT WHERE MaGiay=@MaGiay
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateKhachHang](
	@MaKH VARCHAR(9),
	@TenKhachHang NVARCHAR(100),
	@DiaChi nVARCHAR(150),
	@Sdt VARCHAR(15)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.KhachHang WHERE MaKH = @MaKH
	IF(@CheckID=1)
	UPDATE dbo.KhachHang SET MaKH= @MaKH,TenKhachHang=@TenKhachHang,DiaChi= @DiaChi,Sdt=@Sdt  WHERE MaKH=@MaKH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.INSERT table LoaiGiay
CREATE PROC [dbo].[sp_UpdateLoaiGiay](
	@MaLoai VARCHAR(9),
	@TenLoai nVARCHAR(50),
	@GhiChu VARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.LoaiGiay WHERE MaLoai = @MaLoai
	IF(@CheckID=1)
	UPDATE dbo.LoaiGiay SET MaLoai= @MaLoai,TenLoai=@TenLoai,GhiChu= @GhiChu  WHERE MaLoai=@MaLoai
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.INSERT table NhaNhaCungCap
CREATE PROC [dbo].[sp_UpdateNhaCungCap](
	@MaNCC VARCHAR(9),
	@TenNCC NVARCHAR(50),
	@DiaChi NVARCHAR(150),
	@Sdt VARCHAR(15)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC
	IF(@CheckID=1)
	UPDATE dbo.NhaCungCap SET MaNCC= @MaNCC,TenNCC=@TenNCC,DiaChi= @DiaChi,Sdt=@Sdt WHERE MaNCC=@MaNCC
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.UPDATE table NhanVien
CREATE PROC [dbo].[sp_UpdateNhanVien](
	@MaNV VARCHAR(9),
	@HoTen NVARCHAR(100),
	@NgaySinh DATE,
	@Sdt VARCHAR(15)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhanVien WHERE MaNV = @MaNV
	IF(@CheckID=1)
	UPDATE dbo.NhanVien SET  MaNV=@MaNV, HoTen=@HoTen, NgaySinh=@NgaySinh, Sdt=@Sdt WHERE MaNV=@MaNV
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.UPDATE table NhaSanXuat
CREATE PROC [dbo].[sp_UpdateNhaSanXuat](
	@MaNSX VARCHAR(9),
	@TenNSX NVARCHAR(50),
	@QuocGia NVARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.NhaSanXuat WHERE MaNSX = @MaNSX
	IF(@CheckID=1)
	UPDATE dbo.NhaSanXuat SET MaNSX=@MaNSX, TenNSX=@TenNSX, QuocGia=@QuocGia WHERE MaNSX=@MaNSX
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdatePhieuNhap](
	@MaPN VARCHAR(9),
	@NgayNhap DATE,
	@MaNV VARCHAR(9),
	@MaNCC VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @CheckMaNV INT
	DECLARE @CheckNCC INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhieuNhap WHERE MaPN =@MaPN
	SELECT  @CheckMaNV = COUNT(*) FROM dbo.NhanVien WHERE MaNV=@MaNV
	SELECT  @CheckNCC = COUNT(*) FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC
	IF(@CheckID=1 AND @CheckMaNV=1 AND @CheckNCC=1)
	UPDATE dbo.PhieuNhap
	SET MaPN=@MaPN,NgayNhap=@NgayNhap,MaNV=@MaNV,MaNCC=@MaNCC
	WHERE MaPN=@MaPN
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdatePhieuXuat](
	@MaPX VARCHAR(9),
	@NgayXuat DATE,
	@MaNV VARCHAR(9),
	@MaKH VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @CheckMaNV INT
	DECLARE @CheckMaKH INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhieuXuat WHERE MaPX =@MaPX
	SELECT  @CheckMaNV = COUNT(*) FROM dbo.NhanVien WHERE MaNV=@MaNV
	SELECT  @CheckMaKH = COUNT(*) FROM dbo.KhachHang WHERE MaKH=@MaKH
	IF(@CheckID=1 AND @CheckMaNV=1 AND @CheckMaKH=1)
	UPDATE dbo.PhieuXuat
	SET MaPX=@MaPX,NgayXuat=@NgayXuat,MaNV=@MaNV,MaKhachHang=@MaKH
	WHERE MaPX=@MaPX
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--2.UPDATE table NhanVien
CREATE PROC [dbo].[sp_UpdateSize](
	@MaSize VARCHAR(9),
	@TenSize NVARCHAR(50)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Size WHERE MaSize = @MaSize
	IF(@CheckID=1)
	UPDATE dbo.Size SET  MaSize=@MaSize, TenSize=@TenSize WHERE MaSize=@MaSize
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[sp_UpdateTaiKhoan]
    (
      @TenTaiKhoan VARCHAR(50) ,
      @MatKhau VARCHAR(50) 
    )
AS
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.TaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
	IF(@CheckID=1)
	 UPDATE dbo.TaiKhoan SET TenTaiKhoan=@TenTaiKhoan,MatKhau=@MatKhau WHERE TenTaiKhoan=@TenTaiKhoan

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimKiemPhieuNhap](
	@MaPN VARCHAR(8) ,
	@NgayNhap DATE ,
	@HoTen NVARCHAR(500) ,
	@TenNCC NVARCHAR(500) ,
	@case INT 
)
AS
	BEGIN
     IF(@case=0)  
	   SELECT * FROM PhieuNhapView WHERE MaPN LIKE '%' + @MaPN + '%' 
	 IF(@case=1)  
	   SELECT * FROM PhieuNhapView WHERE NgayNhap =@NgayNhap
	 IF(@case=2)  
	   SELECT * FROM PhieuNhapView WHERE HoTen LIKE '%' + HoTen + '%' 
	 IF(@case=3)  
	    SELECT * FROM PhieuNhapView WHERE TenNCC LIKE '%' + TenNCC + '%' 
	END 

GO
