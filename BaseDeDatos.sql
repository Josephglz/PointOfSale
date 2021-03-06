USE [puntodeVenta]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 12/12/2021 11:08:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] NULL,
	[categoria] [nvarchar](30) NULL,
	[id_catparent] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/12/2021 11:08:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_empleado] [int] NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[rol] [int] NULL,
	[usuario] [nvarchar](10) NULL,
	[password] [nvarchar](10) NULL,
	[image] [nvarchar](max) NULL,
	[lastConn] [nvarchar](30) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/12/2021 11:08:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] NULL,
	[nombre] [nvarchar](50) NULL,
	[precio] [float] NULL,
	[categoria] [int] NULL,
	[stock] [int] NULL,
	[modo] [int] NULL,
	[image] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 12/12/2021 11:08:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[idTicket] [int] NULL,
	[productos] [nvarchar](max) NULL,
	[fecha] [nvarchar](15) NULL,
	[hora] [nvarchar](10) NULL,
	[tVenta] [float] NULL,
	[tPago] [float] NULL,
	[idEmpleado] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
