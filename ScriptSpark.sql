USE [Spark]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 4/30/2021 8:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[Nombre_Producto] [nchar](30) NOT NULL,
	[Nombre_Proveedor] [nchar](30) NULL,
	[Cantidad_Producto] [int] NOT NULL,
	[Capacidad] [int] NULL,
	[Ubicacion] [nchar](20) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[Nombre_Producto] ASC,
	[Cantidad_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlCalidad]    Script Date: 4/30/2021 8:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlCalidad](
	[Nombre_Producto] [nchar](30) NULL,
	[Bajas] [numeric](18, 0) NULL,
	[Nombre_Proveedor] [nchar](30) NULL,
	[Descripcion] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 4/30/2021 8:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Nombre_Proveedor] [nchar](30) NOT NULL,
	[Telefono] [numeric](18, 0) NULL,
	[Correo] [nchar](30) NULL,
	[Direccion] [nchar](50) NULL,
	[Nombre_Producto] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Nombre_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 4/30/2021 8:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[usuario] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 4/30/2021 8:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Nombre_Producto] [nchar](30) NULL,
	[Precio] [float] NULL,
	[Cantidad_Producto] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Almacen] ([Nombre_Producto], [Nombre_Proveedor], [Cantidad_Producto], [Capacidad], [Ubicacion], [Fecha]) VALUES (N'asdsasd                       ', N'sadads                        ', 2, 13, N'dadad               ', CAST(N'2020-12-23' AS Date))
INSERT [dbo].[Almacen] ([Nombre_Producto], [Nombre_Proveedor], [Cantidad_Producto], [Capacidad], [Ubicacion], [Fecha]) VALUES (N'Diego                         ', N'efasda                        ', 20, 30, N'fjfajfa             ', CAST(N'2021-02-12' AS Date))
INSERT [dbo].[Almacen] ([Nombre_Producto], [Nombre_Proveedor], [Cantidad_Producto], [Capacidad], [Ubicacion], [Fecha]) VALUES (N'ejemplo2                      ', N'dasdasd                       ', 12, 231, N'dsaas               ', CAST(N'2021-12-20' AS Date))
GO
INSERT [dbo].[ControlCalidad] ([Nombre_Producto], [Bajas], [Nombre_Proveedor], [Descripcion]) VALUES (N'Diego                         ', CAST(12 AS Numeric(18, 0)), N'dsadada                       ', N'ME LA CHUPAS')
INSERT [dbo].[ControlCalidad] ([Nombre_Producto], [Bajas], [Nombre_Proveedor], [Descripcion]) VALUES (N'aaaaaaaaaaaaaaaaaaaaaaaa      ', CAST(12 AS Numeric(18, 0)), N'asdadsa                       ', N'fasdfdsadsa')
INSERT [dbo].[ControlCalidad] ([Nombre_Producto], [Bajas], [Nombre_Proveedor], [Descripcion]) VALUES (N'asdasd                        ', CAST(1 AS Numeric(18, 0)), N'adsada                        ', N'dasadasasd')
GO
INSERT [dbo].[Proveedores] ([Nombre_Proveedor], [Telefono], [Correo], [Direccion], [Nombre_Producto]) VALUES (N'Diego Emmanuel                ', CAST(1231231 AS Numeric(18, 0)), N'dasdada                       ', N'sadasda                                           ', N'dasdada                       ')
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre], [usuario], [pass]) VALUES (1, N'administrador', N'admin', N'password')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
INSERT [dbo].[Ventas] ([Nombre_Producto], [Precio], [Cantidad_Producto]) VALUES (N'Vino Tinto                    ', 300, CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Ventas] ([Nombre_Producto], [Precio], [Cantidad_Producto]) VALUES (N'Tequila Jose Cuervo           ', 250, CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Ventas] ([Nombre_Producto], [Precio], [Cantidad_Producto]) VALUES (N'Cerveza Corona                ', 150, CAST(6 AS Numeric(18, 0)))
INSERT [dbo].[Ventas] ([Nombre_Producto], [Precio], [Cantidad_Producto]) VALUES (N'Cigarro                       ', 2, CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Ventas] ([Nombre_Producto], [Precio], [Cantidad_Producto]) VALUES (N'Chicle                        ', 2, CAST(1 AS Numeric(18, 0)))
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__usuarios__9AFF8FC6EE8AC086]    Script Date: 4/30/2021 8:53:44 PM ******/
ALTER TABLE [dbo].[usuarios] ADD UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Proveedores] FOREIGN KEY([Nombre_Proveedor])
REFERENCES [dbo].[Proveedores] ([Nombre_Proveedor])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Proveedores]
GO
/****** Object:  StoredProcedure [dbo].[splogin]    Script Date: 4/30/2021 8:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[splogin] 
	@usuario varchar(50),
	@pass varchar(50)
AS
BEGIN

	SELECT top 1 COUNT(*) FROM usuarios
	WHERE usuarios.usuario = @usuario and usuarios.pass = @pass

END
GO
