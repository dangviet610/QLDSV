USE [master]
GO
/****** Object:  Database [quanlysinhvien]    Script Date: 12/29/2021 16:58:47 ******/
CREATE DATABASE [quanlysinhvien] ON  PRIMARY 
( NAME = N'quanlysinhvien', FILENAME = N'e:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\quanlysinhvien.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlysinhvien_log', FILENAME = N'e:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\quanlysinhvien_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlysinhvien] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlysinhvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_NULLS OFF
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_PADDING OFF
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [quanlysinhvien] SET ARITHABORT OFF
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_CLOSE ON
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [quanlysinhvien] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [quanlysinhvien] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [quanlysinhvien] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [quanlysinhvien] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [quanlysinhvien] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [quanlysinhvien] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [quanlysinhvien] SET  ENABLE_BROKER
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [quanlysinhvien] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [quanlysinhvien] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [quanlysinhvien] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [quanlysinhvien] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [quanlysinhvien] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [quanlysinhvien] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [quanlysinhvien] SET  READ_WRITE
GO
ALTER DATABASE [quanlysinhvien] SET RECOVERY SIMPLE
GO
ALTER DATABASE [quanlysinhvien] SET  MULTI_USER
GO
ALTER DATABASE [quanlysinhvien] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [quanlysinhvien] SET DB_CHAINING OFF
GO
USE [quanlysinhvien]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[ID] [int] NOT NULL,
	[Loai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Quyen] ([ID], [Loai]) VALUES (1, N'Giáo viên')
INSERT [dbo].[Quyen] ([ID], [Loai]) VALUES (2, N'Học sinh')
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[Mamon] [int] IDENTITY(1,1) NOT NULL,
	[Tenmon] [nvarchar](50) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[Mamon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MonHoc] ON
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (1, N'Toán')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (2, N'Lý')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (3, N'Hóa')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (4, N'Sinh')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (5, N'Sử')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (6, N'Địa')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (7, N'Triết học')
INSERT [dbo].[MonHoc] ([Mamon], [Tenmon]) VALUES (8, N'Toán rời rạc')
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
/****** Object:  Table [dbo].[Lop]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[Malop] [int] IDENTITY(1,1) NOT NULL,
	[Tenlop] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Lop] ON
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (1, N'Lớp A')
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (2, N'Lớp B')
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (3, N'Lớp C')
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (4, N'Lớp 1E')
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (5, N'Lớp bồi dưỡng')
SET IDENTITY_INSERT [dbo].[Lop] OFF
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[Magiaovien] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Hoten] [nvarchar](50) NULL,
	[Gioitinh] [tinyint] NULL,
	[Role_ID] [int] NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[Magiaovien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Email_GiaoVien] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GiaoVien] ON
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (1, N'thayba@gmail.com', NULL, N'Thầy Ba', 1, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (2, N'cothao@gmail.com', NULL, N'Cô Thảo', 0, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (3, N'mrbean@email.com', NULL, N'Mr Bean', 1, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (4, N'yuhanato@gmail.com', NULL, N'Cô Yui Hanato', 0, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (5, N'abc@gmail.com', NULL, N'Thầy ABC', 1, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (6, N'ssss', NULL, N'ss', 1, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (7, N'dd@gmail.com', NULL, N'ss', 0, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (8, N'heh@gmailmvom', NULL, N'hehe', 1, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (9, N'123', NULL, N'heheh', 1, NULL)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh], [Role_ID]) VALUES (10, N'a', NULL, N'a', 1, NULL)
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[Masv] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [tinyint] NULL,
	[Role_ID] [int] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[Masv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Email_SinhVien] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SinhVien] ON
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (2, N'theanh@email.com                                  ', N'Thế Anh', NULL, CAST(0xB9330B00 AS Date), 1, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (3, N'theem@email.com                                   ', N'Thế Em', NULL, CAST(0x01270B00 AS Date), 1, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (4, N'nam@gmail.com                                     ', N'Nam', NULL, CAST(0x7A260B00 AS Date), 1, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (5, N'linh@gmail.com                                    ', N'Linh', NULL, CAST(0xFD220B00 AS Date), 0, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (6, N'nhat@gmail.com', N'Nhat', NULL, CAST(0xD9200B00 AS Date), 1, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (7, N'yumikami@gmail.com', N'Yu Mikami', NULL, CAST(0x0B1D0B00 AS Date), 0, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (8, N'melodymark@gmail.com', N'Melody Mark', NULL, CAST(0x57250B00 AS Date), 0, NULL)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh], [Role_ID]) VALUES (11, N'33333@gmail.com', N'dđ', NULL, CAST(0x90400B00 AS Date), 2, NULL)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
/****** Object:  Table [dbo].[PhanLopSinhVien]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLopSinhVien](
	[Masv] [int] NOT NULL,
	[Malop] [int] NOT NULL,
	[Mamon] [int] NOT NULL,
 CONSTRAINT [PK_PhanLopSinhVien] PRIMARY KEY CLUSTERED 
(
	[Masv] ASC,
	[Malop] ASC,
	[Mamon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanLopGiaoVien]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLopGiaoVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Magiaovien] [int] NOT NULL,
	[Malop] [int] NOT NULL,
	[Mamon] [int] NULL,
 CONSTRAINT [PK_PhanLop] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 12/29/2021 16:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[Masv] [int] NOT NULL,
	[Mamon] [int] NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_Diem_1] PRIMARY KEY CLUSTERED 
(
	[Masv] ASC,
	[Mamon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_GiaoVien_Quyen]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_Quyen] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Quyen] ([ID])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_Quyen]
GO
/****** Object:  ForeignKey [FK_SinhVien_Quyen]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Quyen] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Quyen] ([ID])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Quyen]
GO
/****** Object:  ForeignKey [FK_PhanLopSinhVien_Lop]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[PhanLopSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLopSinhVien_Lop] FOREIGN KEY([Malop])
REFERENCES [dbo].[Lop] ([Malop])
GO
ALTER TABLE [dbo].[PhanLopSinhVien] CHECK CONSTRAINT [FK_PhanLopSinhVien_Lop]
GO
/****** Object:  ForeignKey [FK_PhanLopSinhVien_MonHoc]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[PhanLopSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLopSinhVien_MonHoc] FOREIGN KEY([Mamon])
REFERENCES [dbo].[MonHoc] ([Mamon])
GO
ALTER TABLE [dbo].[PhanLopSinhVien] CHECK CONSTRAINT [FK_PhanLopSinhVien_MonHoc]
GO
/****** Object:  ForeignKey [FK_PhanLopSinhVien_SinhVien]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[PhanLopSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLopSinhVien_SinhVien] FOREIGN KEY([Masv])
REFERENCES [dbo].[SinhVien] ([Masv])
GO
ALTER TABLE [dbo].[PhanLopSinhVien] CHECK CONSTRAINT [FK_PhanLopSinhVien_SinhVien]
GO
/****** Object:  ForeignKey [FK_PhanLop_GiaoVien]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[PhanLopGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLop_GiaoVien] FOREIGN KEY([Magiaovien])
REFERENCES [dbo].[GiaoVien] ([Magiaovien])
GO
ALTER TABLE [dbo].[PhanLopGiaoVien] CHECK CONSTRAINT [FK_PhanLop_GiaoVien]
GO
/****** Object:  ForeignKey [FK_PhanLop_Lop]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[PhanLopGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLop_Lop] FOREIGN KEY([Malop])
REFERENCES [dbo].[Lop] ([Malop])
GO
ALTER TABLE [dbo].[PhanLopGiaoVien] CHECK CONSTRAINT [FK_PhanLop_Lop]
GO
/****** Object:  ForeignKey [FK_Diem_MonHoc]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([Mamon])
REFERENCES [dbo].[MonHoc] ([Mamon])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
/****** Object:  ForeignKey [FK_Diem_SinhVien]    Script Date: 12/29/2021 16:58:48 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([Masv])
REFERENCES [dbo].[SinhVien] ([Masv])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
