USE [master]
GO
/****** Object:  Database [quanlysinhvien]    Script Date: 01/15/2022 11:58:59 ******/
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
/****** Object:  Table [dbo].[MonHoc]    Script Date: 01/15/2022 11:59:00 ******/
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
/****** Object:  Table [dbo].[Lop]    Script Date: 01/15/2022 11:59:00 ******/
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
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (6, N'Lớp CNTT01')
INSERT [dbo].[Lop] ([Malop], [Tenlop]) VALUES (7, N'Lớp CNTT02')
SET IDENTITY_INSERT [dbo].[Lop] OFF
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 01/15/2022 11:59:00 ******/
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
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (1, N'theanh', N'123', N'Thầy Ba', 1)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (2, N'cothao@gmail.com', N'123', N'Cô Thảo', 0)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (3, N'mrbean@email.com', N'123', N'Mr Bean', 1)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (4, N'yuhanato@gmail.com', N'123', N'Cô Yui Hanato', 0)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (5, N'abc@gmail.com', N'123', N'Thầy ABC', 1)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (6, N'ssss', N'123', N'ss', 1)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (7, N'dd@gmail.com', N'123', N'ss', 0)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (8, N'heh@gmailmvom', N'123', N'hehe', 1)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (9, N'123', N'123', N'heheh', 1)
INSERT [dbo].[GiaoVien] ([Magiaovien], [Email], [Password], [Hoten], [Gioitinh]) VALUES (10, N'a', N'123', N'a', 1)
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
/****** Object:  Table [dbo].[Admin]    Script Date: 01/15/2022 11:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([Username], [Password]) VALUES (N'admin', N'admin')
INSERT [dbo].[Admin] ([Username], [Password]) VALUES (N'admin1', N'a')
/****** Object:  Table [dbo].[SinhVien]    Script Date: 01/15/2022 11:59:00 ******/
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
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (2, N'theanh', N'Thế Anh1', N'123', CAST(0xB9330B00 AS Date), 1)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (3, N'theem', N'Thế Em', N'123', CAST(0x01270B00 AS Date), 1)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (4, N'nam@gmail.com                                     ', N'Nam', N'123', CAST(0x7A260B00 AS Date), 1)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (5, N'linh@gmail.com                                    ', N'Linh', N'123', CAST(0xFD220B00 AS Date), 0)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (6, N'nhat@gmail.com', N'Nhat', N'123', CAST(0xD9200B00 AS Date), 1)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (7, N'yumikami@gmail.com', N'Yu Mikami', N'123', CAST(0x0B1D0B00 AS Date), 0)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (8, N'melodymark@gmail.com', N'Melody Mark', N'123', CAST(0x57250B00 AS Date), 0)
INSERT [dbo].[SinhVien] ([Masv], [Email], [Hoten], [Password], [Ngaysinh], [Gioitinh]) VALUES (11, N'33333@gmail.com', N'dđ', N'123', CAST(0x90400B00 AS Date), 2)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
/****** Object:  Table [dbo].[PhanLopSinhVien]    Script Date: 01/15/2022 11:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLopSinhVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Masv] [int] NOT NULL,
	[Malop] [int] NOT NULL,
 CONSTRAINT [PK_PhanLopSinhVien_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhanLopSinhVien] ON
INSERT [dbo].[PhanLopSinhVien] ([ID], [Masv], [Malop]) VALUES (9, 2, 2)
INSERT [dbo].[PhanLopSinhVien] ([ID], [Masv], [Malop]) VALUES (10, 2, 3)
INSERT [dbo].[PhanLopSinhVien] ([ID], [Masv], [Malop]) VALUES (13, 3, 2)
INSERT [dbo].[PhanLopSinhVien] ([ID], [Masv], [Malop]) VALUES (14, 3, 4)
INSERT [dbo].[PhanLopSinhVien] ([ID], [Masv], [Malop]) VALUES (19, 2, 7)
INSERT [dbo].[PhanLopSinhVien] ([ID], [Masv], [Malop]) VALUES (20, 2, 6)
SET IDENTITY_INSERT [dbo].[PhanLopSinhVien] OFF
/****** Object:  Table [dbo].[PhanLopGiaoVien]    Script Date: 01/15/2022 11:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLopGiaoVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Magiaovien] [int] NOT NULL,
	[Malop] [int] NOT NULL,
	[Mamon] [int] NOT NULL,
 CONSTRAINT [PK_PhanLopGiaoVien_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhanLopGiaoVien] ON
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (6, 2, 2, 2)
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (7, 3, 3, 1)
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (8, 4, 4, 4)
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (9, 1, 5, 3)
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (10, 1, 1, 1)
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (12, 1, 6, 7)
INSERT [dbo].[PhanLopGiaoVien] ([ID], [Magiaovien], [Malop], [Mamon]) VALUES (13, 1, 7, 5)
SET IDENTITY_INSERT [dbo].[PhanLopGiaoVien] OFF
/****** Object:  Table [dbo].[Diem]    Script Date: 01/15/2022 11:59:00 ******/
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
INSERT [dbo].[Diem] ([Masv], [Mamon], [Diem]) VALUES (2, 1, 7)
INSERT [dbo].[Diem] ([Masv], [Mamon], [Diem]) VALUES (2, 2, 6)
INSERT [dbo].[Diem] ([Masv], [Mamon], [Diem]) VALUES (2, 3, 9)
INSERT [dbo].[Diem] ([Masv], [Mamon], [Diem]) VALUES (2, 4, 10)
INSERT [dbo].[Diem] ([Masv], [Mamon], [Diem]) VALUES (2, 5, 7)
INSERT [dbo].[Diem] ([Masv], [Mamon], [Diem]) VALUES (2, 6, 5)
/****** Object:  ForeignKey [FK_PhanLopSinhVien_Lop]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[PhanLopSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLopSinhVien_Lop] FOREIGN KEY([Malop])
REFERENCES [dbo].[Lop] ([Malop])
GO
ALTER TABLE [dbo].[PhanLopSinhVien] CHECK CONSTRAINT [FK_PhanLopSinhVien_Lop]
GO
/****** Object:  ForeignKey [FK_PhanLopSinhVien_SinhVien]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[PhanLopSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLopSinhVien_SinhVien] FOREIGN KEY([Masv])
REFERENCES [dbo].[SinhVien] ([Masv])
GO
ALTER TABLE [dbo].[PhanLopSinhVien] CHECK CONSTRAINT [FK_PhanLopSinhVien_SinhVien]
GO
/****** Object:  ForeignKey [FK_PhanLop_GiaoVien]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[PhanLopGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLop_GiaoVien] FOREIGN KEY([Magiaovien])
REFERENCES [dbo].[GiaoVien] ([Magiaovien])
GO
ALTER TABLE [dbo].[PhanLopGiaoVien] CHECK CONSTRAINT [FK_PhanLop_GiaoVien]
GO
/****** Object:  ForeignKey [FK_PhanLop_Lop]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[PhanLopGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLop_Lop] FOREIGN KEY([Malop])
REFERENCES [dbo].[Lop] ([Malop])
GO
ALTER TABLE [dbo].[PhanLopGiaoVien] CHECK CONSTRAINT [FK_PhanLop_Lop]
GO
/****** Object:  ForeignKey [FK_PhanLopGiaoVien_MonHoc]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[PhanLopGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanLopGiaoVien_MonHoc] FOREIGN KEY([Mamon])
REFERENCES [dbo].[MonHoc] ([Mamon])
GO
ALTER TABLE [dbo].[PhanLopGiaoVien] CHECK CONSTRAINT [FK_PhanLopGiaoVien_MonHoc]
GO
/****** Object:  ForeignKey [FK_Diem_MonHoc]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([Mamon])
REFERENCES [dbo].[MonHoc] ([Mamon])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
/****** Object:  ForeignKey [FK_Diem_SinhVien]    Script Date: 01/15/2022 11:59:00 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([Masv])
REFERENCES [dbo].[SinhVien] ([Masv])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
