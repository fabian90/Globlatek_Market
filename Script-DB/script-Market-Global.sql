USE [Globaltek_Market]
GO
/****** Object:  Table [dbo].[Detalles]    Script Date: 5/10/2023 11:47:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Detalles] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 5/10/2023 11:47:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[NumeroFactura] [nvarchar](255) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[TipoDePago] [nvarchar](50) NOT NULL,
	[DocumentoCliente] [nvarchar](50) NOT NULL,
	[NombreCliente] [nvarchar](255) NOT NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[IVA] [decimal](18, 2) NOT NULL,
	[TotalDescuento] [decimal](18, 2) NOT NULL,
	[TotalImpuesto] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Facturas] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 5/10/2023 11:47:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Detalles] ON 

INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (1, NULL, 1, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (2, NULL, 3, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (3, NULL, 1, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (4, NULL, 1, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (5, NULL, 1, 12, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (6, NULL, 1, 12, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (7, NULL, 5, 1, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (8, NULL, 2, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (9, NULL, 6, 2, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (10, NULL, 6, 2, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (11, NULL, 3, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (12, NULL, 3, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (13, NULL, 3, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (14, NULL, 4, 2, CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (15, NULL, 2, 1, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (16, NULL, 3, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (17, NULL, 3, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (18, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (19, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (20, NULL, 3, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (21, NULL, 3, 12, CAST(1234.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (22, NULL, 3, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (23, NULL, 1, 12, CAST(12333.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (24, NULL, 1, 12, CAST(1232.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (25, NULL, 2, 12, CAST(1234123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (26, NULL, 2, 12, CAST(1213.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (27, NULL, 3, 12, CAST(12321.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (36, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (37, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (38, NULL, 1, 12, CAST(1312.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (39, NULL, 3, 12, CAST(1231.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (40, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (41, NULL, 2, 12, CAST(12312.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (44, NULL, 5, 1123, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (45, NULL, 1, 2, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (46, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (47, NULL, 3, 2, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (48, NULL, 4, 1, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (49, NULL, 1, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (50, NULL, 2, 2, CAST(1212.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (51, NULL, 2, 2, CAST(121.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (52, NULL, 4, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (53, NULL, 2, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (54, NULL, 2, 2, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (55, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (56, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (57, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (58, NULL, 2, 12, CAST(1232.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (59, NULL, 1, 12, CAST(1231.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (60, NULL, 1, 12, CAST(121.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (61, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (62, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (63, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (64, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (65, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (66, NULL, 1, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (67, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (68, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (69, NULL, 2, 12, CAST(122.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (70, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (71, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (72, NULL, 1, 2, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (73, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (74, NULL, 2, 2, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (75, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (76, NULL, 2, 12, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (77, NULL, 2, 12, CAST(1223.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (78, NULL, 2, 2, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (79, NULL, 2, 12, CAST(1232.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (80, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (81, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (82, NULL, 2, 123, CAST(1232.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (83, NULL, 4, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (84, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (85, NULL, 6, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (86, NULL, 3, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (87, NULL, 1, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (88, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (89, NULL, 6, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (90, NULL, 2, 123, CAST(1213.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (91, NULL, 3, 1, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (92, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (93, NULL, 2, 12, CAST(213.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (94, NULL, 2, 12, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (95, NULL, 3, 1, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (96, NULL, 3, 1, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (97, NULL, 1, 1, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (98, NULL, 4, 1, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (99, NULL, 2, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (100, NULL, 3, 123, CAST(1232.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (101, NULL, 2, 2, CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Detalles] ([IdDetalle], [IdFactura], [IdProducto], [Cantidad], [PrecioUnitario]) VALUES (102, NULL, 3, 12, CAST(123.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Detalles] OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (1, N'F001', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(1476.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(148.00 AS Decimal(18, 2)), CAST(148.00 AS Decimal(18, 2)), CAST(1476.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (2, N'F002', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(1722.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(172.00 AS Decimal(18, 2)), CAST(172.00 AS Decimal(18, 2)), CAST(1722.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (3, N'F003', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(29076.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(2908.00 AS Decimal(18, 2)), CAST(2908.00 AS Decimal(18, 2)), CAST(29076.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (4, N'F004', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(246.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(246.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (5, N'F005', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(16260.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(1626.00 AS Decimal(18, 2)), CAST(1626.00 AS Decimal(18, 2)), CAST(16260.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (6, N'F006', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(154488.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(15449.00 AS Decimal(18, 2)), CAST(15449.00 AS Decimal(18, 2)), CAST(154488.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (7, N'F007', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4428.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(443.00 AS Decimal(18, 2)), CAST(443.00 AS Decimal(18, 2)), CAST(4428.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (8, N'F008', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'123', N'Fabian', CAST(4428.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(443.00 AS Decimal(18, 2)), CAST(443.00 AS Decimal(18, 2)), CAST(4428.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (9, N'F009', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(149322.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(14932.00 AS Decimal(18, 2)), CAST(14932.00 AS Decimal(18, 2)), CAST(149322.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (10, N'F010', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4032.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(4032.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (11, N'F011', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4032.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(4032.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (12, N'F012', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4032.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(4032.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (13, N'F013', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4032.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(4032.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (14, N'F014', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4032.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(4032.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (15, N'F015', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(4032.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(403.00 AS Decimal(18, 2)), CAST(4032.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (16, N'F016', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(1611.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(161.00 AS Decimal(18, 2)), CAST(161.00 AS Decimal(18, 2)), CAST(1611.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (17, N'F017', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(1611.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(161.00 AS Decimal(18, 2)), CAST(161.00 AS Decimal(18, 2)), CAST(1611.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (18, N'F018', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(135.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(135.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (19, N'F019', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(153936.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(15394.00 AS Decimal(18, 2)), CAST(15394.00 AS Decimal(18, 2)), CAST(153936.00 AS Decimal(18, 2)))
INSERT [dbo].[Facturas] ([IdFactura], [NumeroFactura], [Fecha], [TipoDePago], [DocumentoCliente], [NombreCliente], [Subtotal], [Descuento], [IVA], [TotalDescuento], [TotalImpuesto], [Total]) VALUES (20, N'F020', CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'Contado', N'12345', N'Fabian', CAST(1722.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(172.00 AS Decimal(18, 2)), CAST(172.00 AS Decimal(18, 2)), CAST(1722.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [Nombre]) VALUES (1, N'Camisa')
INSERT [dbo].[Productos] ([IdProducto], [Nombre]) VALUES (2, N'Pantalon')
INSERT [dbo].[Productos] ([IdProducto], [Nombre]) VALUES (3, N'Zapato')
INSERT [dbo].[Productos] ([IdProducto], [Nombre]) VALUES (4, N'Tenis')
INSERT [dbo].[Productos] ([IdProducto], [Nombre]) VALUES (5, N'Falda')
INSERT [dbo].[Productos] ([IdProducto], [Nombre]) VALUES (6, N'Falda')
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
ALTER TABLE [dbo].[Detalles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Detalles_dbo.Facturas_IdFactura] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Facturas] ([IdFactura])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalles] CHECK CONSTRAINT [FK_dbo.Detalles_dbo.Facturas_IdFactura]
GO
ALTER TABLE [dbo].[Detalles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Detalles_dbo.Productos_IdProducto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalles] CHECK CONSTRAINT [FK_dbo.Detalles_dbo.Productos_IdProducto]
GO
