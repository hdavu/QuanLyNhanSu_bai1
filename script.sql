USE [QuanLiNhanSu_TT]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 3/2/2017 8:59:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[congtac]    Script Date: 3/2/2017 8:59:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[congtac](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[nhanvienma] [int] NOT NULL,
	[chucvuma] [int] NOT NULL,
	[ngaynhanchuc] [date] NULL,
	[ngaythoichuc] [date] NULL,
 CONSTRAINT [PK_congtac] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[luong]    Script Date: 3/2/2017 8:59:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luong](
	[ma] [int] NOT NULL,
	[bacluong] [float] NOT NULL,
	[luongcoban] [int] NOT NULL,
	[hesoluong] [float] NOT NULL,
	[hesophucap] [float] NOT NULL,
 CONSTRAINT [PK_luong] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 3/2/2017 8:59:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
	[anh] [nvarchar](200) NULL,
	[dantoc] [nvarchar](10) NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[tongiao] [nvarchar](20) NOT NULL,
	[quequan] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[trinhdohocvanma] [int] NOT NULL,
	[chucvuma] [int] IDENTITY(1,1) NOT NULL,
	[phongbanma] [int] NOT NULL,
	[bacluongma] [int] NOT NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phongban]    Script Date: 3/2/2017 8:59:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongban](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_phongban] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[trinhdohocvan]    Script Date: 3/2/2017 8:59:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trinhdohocvan](
	[ma] [int] NOT NULL,
	[trinhdo] [nvarchar](50) NOT NULL,
	[chuyenmon] [nvarchar](50) NOT NULL,
	[bangcap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_trinhdohocvan] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[congtac]  WITH CHECK ADD  CONSTRAINT [FK_congtac_chucvu] FOREIGN KEY([chucvuma])
REFERENCES [dbo].[chucvu] ([ma])
GO
ALTER TABLE [dbo].[congtac] CHECK CONSTRAINT [FK_congtac_chucvu]
GO
ALTER TABLE [dbo].[congtac]  WITH CHECK ADD  CONSTRAINT [FK_congtac_nhanvien] FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[congtac] CHECK CONSTRAINT [FK_congtac_nhanvien]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_luong] FOREIGN KEY([bacluongma])
REFERENCES [dbo].[luong] ([ma])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_luong]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_phongban] FOREIGN KEY([phongbanma])
REFERENCES [dbo].[phongban] ([ma])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_phongban]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_trinhdohocvan] FOREIGN KEY([trinhdohocvanma])
REFERENCES [dbo].[trinhdohocvan] ([ma])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_trinhdohocvan]
GO
