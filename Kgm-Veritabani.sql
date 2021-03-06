USE [KGM_Personal_List]
GO
/****** Object:  Table [dbo].[Table_Personal_Listesi]    Script Date: 3.09.2021 09:56:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Personal_Listesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](20) NULL,
	[Soyad] [varchar](25) NULL,
	[Departman] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_Uygulamalar]    Script Date: 3.09.2021 09:56:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Uygulamalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Uygulama_ad] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Personal_Listesi] ON 

INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (1, N'Ali', N'ŞENCAN', N'Mimar')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (2, N'Aliye', N'ŞENCAN', N'Mühendis')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (3, N'Fatma', N'KARALI', N'Mimar')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (4, N'Nuray', N'CANSIZ', N'Kat Görevlisi')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (6, N'Suna', N'DEMİR', N'Muhasebe')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (7, N'Yeşim ', N'DİNAY', N'Mimar')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (8, N'Ergül', N'SAKAR', N'Güvenlik Görevlisi')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (9, N'Zeynep', N'ÇAKMAK', N'Satış')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (10, N'Zeynep', N'GÜLSUN', N'Satış')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (11, N'Almina', N'ŞENCAN', N'Muhasebe')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (13, N'Yeşim', N'GÜLSUN', N'Kat Görevlisi')
INSERT [dbo].[Table_Personal_Listesi] ([Id], [Ad], [Soyad], [Departman]) VALUES (14, N'Hilal', N'VAROL', N'Bilgisayar Mühendisi')
SET IDENTITY_INSERT [dbo].[Table_Personal_Listesi] OFF
SET IDENTITY_INSERT [dbo].[Table_Uygulamalar] ON 

INSERT [dbo].[Table_Uygulamalar] ([Id], [Uygulama_ad]) VALUES (1, N'Microsoft Excel')
INSERT [dbo].[Table_Uygulamalar] ([Id], [Uygulama_ad]) VALUES (2, N'Microsoft Sql 2018')
INSERT [dbo].[Table_Uygulamalar] ([Id], [Uygulama_ad]) VALUES (3, N'Microsoft Word 2018')
INSERT [dbo].[Table_Uygulamalar] ([Id], [Uygulama_ad]) VALUES (4, N'Visual Studio 2019')
INSERT [dbo].[Table_Uygulamalar] ([Id], [Uygulama_ad]) VALUES (7, N'SolidWorks')
SET IDENTITY_INSERT [dbo].[Table_Uygulamalar] OFF
