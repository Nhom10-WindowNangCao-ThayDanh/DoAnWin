USE [nhaTro]
GO
/****** Object:  Table [dbo].[BangGiaTien]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGiaTien](
	[MaGia] [nvarchar](50) NOT NULL,
	[MaKV] [nvarchar](50) NULL,
	[GiaTien] [numeric](18, 0) NULL,
 CONSTRAINT [PK_BangGiaTien] PRIMARY KEY CLUSTERED 
(
	[MaGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[DonGia] [numeric](18, 0) NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHTRO]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHTRO](
	[MaKT] [nvarchar](50) NOT NULL,
	[MaPT] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[CMND] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgeNghiep] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[TrangthaiTro] [bit] NULL,
	[tendangnhap] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHTRO] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKV] [nvarchar](50) NOT NULL,
	[TenKV] [nvarchar](50) NULL,
	[TANG] [nvarchar](50) NULL,
	[DAY] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ManHinh]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManHinh](
	[MaManHinh] [nvarchar](50) NOT NULL,
	[TenManHinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_ManHinh] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[tendangnhap] [nvarchar](50) NOT NULL,
	[matkhau] [nchar](20) NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDungNhomNguoiDung]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDungNhomNguoiDung](
	[tendangnhap] [nvarchar](50) NOT NULL,
	[MaNhom] [nvarchar](50) NOT NULL,
	[GhiChu] [nchar](10) NULL,
 CONSTRAINT [PK_NguoiDungNhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC,
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNguoiDung](
	[MaNhom] [nvarchar](50) NOT NULL,
	[TenNhom] [nchar](10) NULL,
	[GhiChu] [nchar](10) NULL,
 CONSTRAINT [PK_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaNhom] [nvarchar](50) NOT NULL,
	[MaManHinh] [nvarchar](50) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuChi](
	[MaPC] [int] IDENTITY(1,1) NOT NULL,
	[MaPT] [nvarchar](50) NULL,
	[NgayChi] [datetime] NULL,
	[SoTien] [numeric](18, 0) NULL,
	[LyDo] [nvarchar](100) NULL,
 CONSTRAINT [PK_PhieuChi] PRIMARY KEY CLUSTERED 
(
	[MaPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGTRO]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGTRO](
	[MaPT] [nvarchar](50) NOT NULL,
	[MaKV] [nvarchar](50) NULL,
	[MaBangGia] [nvarchar](50) NULL,
	[TenPhong] [nvarchar](50) NULL,
	[SLToiDa] [int] NULL,
	[TrangThai] [bit] NULL,
	[TrangThaiThue] [bit] NULL,
	[SoNguoiHienTai] [int] NULL,
 CONSTRAINT [PK_PHONGTRO] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QLTHUTIEN]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLTHUTIEN](
	[MaThu] [int] IDENTITY(1,1) NOT NULL,
	[MaDV] [int] NULL,
	[MaPT] [nvarchar](50) NULL,
	[MaKT] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[NgayThu] [datetime] NULL,
 CONSTRAINT [PK_QUANLITHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUANLITHUEPHONG]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLITHUEPHONG](
	[MaPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[MaKT] [nvarchar](50) NULL,
	[NgayThue] [nchar](10) NULL,
	[TrangThai] [bit] NULL,
	[TienDatCoc] [numeric](18, 0) NULL,
 CONSTRAINT [PK_QUANLITHUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THIETBI]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THIETBI](
	[MaTB] [int] IDENTITY(1,1) NOT NULL,
	[MaPT] [nvarchar](50) NULL,
	[TenTB] [nvarchar](50) NULL,
	[NhanHieu] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[TinhTrang] [bit] NULL,
	[NgayMua] [datetime] NULL,
	[Gia] [nvarchar](50) NULL,
 CONSTRAINT [PK_THIETBI] PRIMARY KEY CLUSTERED 
(
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRAPHONG]    Script Date: 10/29/2019 12:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRAPHONG](
	[MaTraPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaKT] [nvarchar](50) NULL,
	[TenKT] [nvarchar](50) NULL,
	[NgayTra] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRAPHONG] PRIMARY KEY CLUSTERED 
(
	[MaTraPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BangGiaTien] ([MaGia], [MaKV], [GiaTien]) VALUES (N'MG01', N'KV01', CAST(1000000 AS Numeric(18, 0)))
INSERT [dbo].[BangGiaTien] ([MaGia], [MaKV], [GiaTien]) VALUES (N'MG02', N'KV02', CAST(5000000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (1, N'Internet', CAST(30000 AS Numeric(18, 0)), N'VND')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (2, N'Điện', CAST(50000 AS Numeric(18, 0)), N'VND')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (3, N'Nước', CAST(80000 AS Numeric(18, 0)), N'VND')
SET IDENTITY_INSERT [dbo].[DichVu] OFF
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT001', N'PT001', N'Nguyễn Lan Anh', N'381630174', N'Nam', N'Sinh Viên', N'Châu Thành- Ti?n Giang', N'0939928207', 1, N'user')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT002', N'PT002', N'55353', N'42424', N'Nữ', N'sd', N'fsd', N'35225', 0, N'user')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT003', N'PT002', N'asdasd', N'0123456789', N'Nam', N'asd', N'asdasd', N'0397299292', 1, N'admin')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT004', N'PT001', N'Lý Thiện Thanh', N'291173432', N'Nam', N'sinh viên', N'Tây ninh', N'0397299292', 1, N'user')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT005', N'PT001', N'aaa', N'aaaaa', N'Nam', N'aaaa', N'aaaaa', N'012313123', 1, N'admin')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT006', N'PT001', N'bbbb', N'bbbb', N'Nam', N'bbbb', N'bbbb', N'123123', 1, N'user')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT007', N'PT001', N'bbbb7', N'bbbb7', N'Nam', N'bbbb7', N'bbbb7', N'1231237', 1, N'user')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT008', N'PT002', N'aaaaa', N'aaaaa', N'Nam', N'aaa', N'aaa', N'012313', 1, N'admin')
INSERT [dbo].[KHACHTRO] ([MaKT], [MaPT], [HoTen], [CMND], [GioiTinh], [NgeNghiep], [DiaChi], [SDT], [TrangthaiTro], [tendangnhap]) VALUES (N'KT009', N'PT010', N'cccc', N'aasd', N'Nam', N'asdasd', N'asdasd', N'asdasd', 1, N'admin')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'KV01', N'Khu vực 1', NULL, NULL)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'KV02', N'Khu vực 2', NULL, NULL)
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem1', N'NguoiDung')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem2', N'NhomNguoiDung')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem3', N'PhanQuyen')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem4', N'TrangThaiPhong')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem5', N'TinhTienPhong')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem6', N'TraPhong')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem7', N'DanhSachKhachTro')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'barButtonItem8', N'DangKiThuePhong')
INSERT [dbo].[NguoiDung] ([tendangnhap], [matkhau], [HoatDong]) VALUES (N'admin', N'admin               ', 1)
INSERT [dbo].[NguoiDung] ([tendangnhap], [matkhau], [HoatDong]) VALUES (N'test', N'test                ', 1)
INSERT [dbo].[NguoiDung] ([tendangnhap], [matkhau], [HoatDong]) VALUES (N'user', N'user                ', 1)
INSERT [dbo].[NguoiDung] ([tendangnhap], [matkhau], [HoatDong]) VALUES (N'user1', N'user1               ', 1)
INSERT [dbo].[NguoiDungNhomNguoiDung] ([tendangnhap], [MaNhom], [GhiChu]) VALUES (N'admin', N'N002', N'          ')
INSERT [dbo].[NguoiDungNhomNguoiDung] ([tendangnhap], [MaNhom], [GhiChu]) VALUES (N'user', N'N001', NULL)
INSERT [dbo].[NguoiDungNhomNguoiDung] ([tendangnhap], [MaNhom], [GhiChu]) VALUES (N'user1', N'N001', N'          ')
INSERT [dbo].[NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'N001', N'Nhân Viên ', NULL)
INSERT [dbo].[NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'N002', N'Quản Lý   ', NULL)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N001', N'barButtonItem4', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N001', N'barButtonItem5', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N001', N'barButtonItem6', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N001', N'barButtonItem7', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N001', N'barButtonItem8', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem1', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem2', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem3', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem4', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem5', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem6', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem7', 1)
INSERT [dbo].[PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'N002', N'barButtonItem8', 1)
SET IDENTITY_INSERT [dbo].[PhieuChi] ON 

INSERT [dbo].[PhieuChi] ([MaPC], [MaPT], [NgayChi], [SoTien], [LyDo]) VALUES (1, N'PT001', CAST(0x0000A60E00000000 AS DateTime), CAST(20000 AS Numeric(18, 0)), N'dfvgx')
INSERT [dbo].[PhieuChi] ([MaPC], [MaPT], [NgayChi], [SoTien], [LyDo]) VALUES (2, N'PT002', CAST(0x0000A60E00000000 AS DateTime), CAST(450000 AS Numeric(18, 0)), N'Hu qu?t')
SET IDENTITY_INSERT [dbo].[PhieuChi] OFF
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT001', N'KV01', N'MG01', N'Phòng 1', 5, 1, 1, 5)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT002', N'KV01', N'MG01', N'Phòng 2', 5, 1, 0, 2)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT003', N'KV01', N'MG01', N'Phòng 3', 5, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT004', N'KV01', N'MG01', N'Phòng 4', 5, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT005', N'KV01', N'MG01', N'Phòng 5', 5, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT006', N'KV02', N'MG02', N'Phòng 6', 10, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT007', N'KV02', N'MG02', N'Phòng 7', 10, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT008', N'KV02', N'MG02', N'Phòng 8', 10, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT009', N'KV02', N'MG02', N'Phòng 9', 10, 1, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPT], [MaKV], [MaBangGia], [TenPhong], [SLToiDa], [TrangThai], [TrangThaiThue], [SoNguoiHienTai]) VALUES (N'PT010', N'KV02', N'MG02', N'Phòng 10', 10, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[QLTHUTIEN] ON 

INSERT [dbo].[QLTHUTIEN] ([MaThu], [MaDV], [MaPT], [MaKT], [Soluong], [NgayThu]) VALUES (86, 1, N'PT002', N'KT002', 3, CAST(0x0000A61700000000 AS DateTime))
INSERT [dbo].[QLTHUTIEN] ([MaThu], [MaDV], [MaPT], [MaKT], [Soluong], [NgayThu]) VALUES (87, 2, N'PT002', N'KT002', 3, CAST(0x0000A61700000000 AS DateTime))
INSERT [dbo].[QLTHUTIEN] ([MaThu], [MaDV], [MaPT], [MaKT], [Soluong], [NgayThu]) VALUES (88, 3, N'PT002', N'KT002', 1, CAST(0x0000A61700000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[QLTHUTIEN] OFF
SET IDENTITY_INSERT [dbo].[QUANLITHUEPHONG] ON 

INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (21, N'KT002', N'29-10-2019', 1, CAST(353535 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (22, N'KT001', N'29-10-2019', 1, CAST(500000 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (26, N'KT003', N'29-10-2019', 1, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (27, N'KT004', N'29-10-2019', 1, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (28, N'KT005', N'29-10-2019', 1, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (29, N'KT006', N'29-10-2019', 1, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (30, N'KT007', N'02-10-2019', 1, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (31, N'KT008', N'29-10-2019', 1, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[QUANLITHUEPHONG] ([MaPhieuThue], [MaKT], [NgayThue], [TrangThai], [TienDatCoc]) VALUES (32, N'KT009', N'29-10-2019', 1, CAST(500000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[QUANLITHUEPHONG] OFF
SET IDENTITY_INSERT [dbo].[THIETBI] ON 

INSERT [dbo].[THIETBI] ([MaTB], [MaPT], [TenTB], [NhanHieu], [SoLuong], [TinhTrang], [NgayMua], [Gia]) VALUES (124, N'PT001', N'Máy gi?c', N'', 1, 1, CAST(0x0000A60A00000000 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[THIETBI] OFF
SET IDENTITY_INSERT [dbo].[TRAPHONG] ON 

INSERT [dbo].[TRAPHONG] ([MaTraPhong], [MaKT], [TenKT], [NgayTra], [GhiChu]) VALUES (55, N'KT002', N'55353', CAST(0x0000A61700000000 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[TRAPHONG] OFF
ALTER TABLE [dbo].[BangGiaTien]  WITH CHECK ADD  CONSTRAINT [FK_BangGiaTien_KHUVUC] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KHUVUC] ([MaKV])
GO
ALTER TABLE [dbo].[BangGiaTien] CHECK CONSTRAINT [FK_BangGiaTien_KHUVUC]
GO
ALTER TABLE [dbo].[KHACHTRO]  WITH CHECK ADD  CONSTRAINT [FK_KHACHTRO_NguoiDung] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[NguoiDung] ([tendangnhap])
GO
ALTER TABLE [dbo].[KHACHTRO] CHECK CONSTRAINT [FK_KHACHTRO_NguoiDung]
GO
ALTER TABLE [dbo].[KHACHTRO]  WITH CHECK ADD  CONSTRAINT [FK_KHACHTRO_PHONGTRO] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PHONGTRO] ([MaPT])
GO
ALTER TABLE [dbo].[KHACHTRO] CHECK CONSTRAINT [FK_KHACHTRO_PHONGTRO]
GO
ALTER TABLE [dbo].[NguoiDungNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDungNhomNguoiDung_NguoiDung] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[NguoiDung] ([tendangnhap])
GO
ALTER TABLE [dbo].[NguoiDungNhomNguoiDung] CHECK CONSTRAINT [FK_NguoiDungNhomNguoiDung_NguoiDung]
GO
ALTER TABLE [dbo].[NguoiDungNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDungNhomNguoiDung_NhomNguoiDung] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[NguoiDungNhomNguoiDung] CHECK CONSTRAINT [FK_NguoiDungNhomNguoiDung_NhomNguoiDung]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_ManHinh] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[ManHinh] ([MaManHinh])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_ManHinh]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_NhomNguoiDung] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_NhomNguoiDung]
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_PhieuChi_PHONGTRO] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PHONGTRO] ([MaPT])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK_PhieuChi_PHONGTRO]
GO
ALTER TABLE [dbo].[PHONGTRO]  WITH CHECK ADD  CONSTRAINT [FK_PHONGTRO_KHUVUC1] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KHUVUC] ([MaKV])
GO
ALTER TABLE [dbo].[PHONGTRO] CHECK CONSTRAINT [FK_PHONGTRO_KHUVUC1]
GO
ALTER TABLE [dbo].[QLTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_QLTHUTIEN_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[QLTHUTIEN] CHECK CONSTRAINT [FK_QLTHUTIEN_DichVu]
GO
ALTER TABLE [dbo].[QLTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_QLTHUTIEN_KHACHTRO] FOREIGN KEY([MaKT])
REFERENCES [dbo].[KHACHTRO] ([MaKT])
GO
ALTER TABLE [dbo].[QLTHUTIEN] CHECK CONSTRAINT [FK_QLTHUTIEN_KHACHTRO]
GO
ALTER TABLE [dbo].[QUANLITHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_QUANLITHUEPHONG_KHACHTRO] FOREIGN KEY([MaKT])
REFERENCES [dbo].[KHACHTRO] ([MaKT])
GO
ALTER TABLE [dbo].[QUANLITHUEPHONG] CHECK CONSTRAINT [FK_QUANLITHUEPHONG_KHACHTRO]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_PHONGTRO] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PHONGTRO] ([MaPT])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_PHONGTRO]
GO
ALTER TABLE [dbo].[TRAPHONG]  WITH CHECK ADD  CONSTRAINT [FK_TRAPHONG_KHACHTRO] FOREIGN KEY([MaKT])
REFERENCES [dbo].[KHACHTRO] ([MaKT])
GO
ALTER TABLE [dbo].[TRAPHONG] CHECK CONSTRAINT [FK_TRAPHONG_KHACHTRO]
GO
