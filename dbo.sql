/*
 Navicat Premium Data Transfer

 Source Server         : MSSQL Localhost
 Source Server Type    : SQL Server
 Source Server Version : 14002014
 Source Host           : .:1433
 Source Catalog        : Mazantines
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14002014
 File Encoding         : 65001

 Date: 10/06/2019 06:31:14
*/


-- ----------------------------
-- Table structure for __RefactorLog
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__RefactorLog]') AND type IN ('U'))
	DROP TABLE [dbo].[__RefactorLog]
GO

CREATE TABLE [dbo].[__RefactorLog] (
  [OperationKey] uniqueidentifier  NOT NULL
)
GO

ALTER TABLE [dbo].[__RefactorLog] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __RefactorLog
-- ----------------------------
INSERT INTO [dbo].[__RefactorLog]  VALUES (N'9E5DD7A9-60D7-468E-8782-29B7251BCC95')
GO

INSERT INTO [dbo].[__RefactorLog]  VALUES (N'B8751729-DF74-4528-860F-3D0942809050')
GO

INSERT INTO [dbo].[__RefactorLog]  VALUES (N'AA520BBD-B14D-4148-B3EA-575333F1E7A4')
GO

INSERT INTO [dbo].[__RefactorLog]  VALUES (N'5E428AE5-6863-4DCA-8E68-6D01289ADFE2')
GO

INSERT INTO [dbo].[__RefactorLog]  VALUES (N'E5419B92-3E38-484D-817B-CC475AF9F1EA')
GO

INSERT INTO [dbo].[__RefactorLog]  VALUES (N'D60BCF9C-2703-4DF1-BD70-D1089B292BCB')
GO

INSERT INTO [dbo].[__RefactorLog]  VALUES (N'2A7F0CA3-9454-4782-BF55-EE756EB0BB37')
GO


-- ----------------------------
-- Table structure for Asientos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Asientos]') AND type IN ('U'))
	DROP TABLE [dbo].[Asientos]
GO

CREATE TABLE [dbo].[Asientos] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [id_proveedor] int  NULL,
  [id_empresa] int  NULL,
  [FechaFactura] date  NULL,
  [Importe] decimal(18,2)  NULL,
  [FechaPago] date  NULL,
  [FormaPago] nvarchar(35) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [Pagado] bit DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[Asientos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Asientos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Asientos] ON
GO

INSERT INTO [dbo].[Asientos] ([Id], [id_proveedor], [id_empresa], [FechaFactura], [Importe], [FechaPago], [FormaPago], [Pagado]) VALUES (N'1', N'1', NULL, N'2019-04-25', N'120000.00', N'2019-04-25', N'Efectivo', N'1')
GO

INSERT INTO [dbo].[Asientos] ([Id], [id_proveedor], [id_empresa], [FechaFactura], [Importe], [FechaPago], [FormaPago], [Pagado]) VALUES (N'2', N'5', NULL, N'2019-04-25', N'1000.20', N'2019-04-25', N'Cheque', N'0')
GO

SET IDENTITY_INSERT [dbo].[Asientos] OFF
GO


-- ----------------------------
-- Table structure for Casas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Casas]') AND type IN ('U'))
	DROP TABLE [dbo].[Casas]
GO

CREATE TABLE [dbo].[Casas] (
  [Id] int  NOT NULL,
  [NroCasa] int  NOT NULL,
  [id_finca] int  NULL
)
GO

ALTER TABLE [dbo].[Casas] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Casas
-- ----------------------------
INSERT INTO [dbo].[Casas]  VALUES (N'1', N'1', N'1')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'2', N'2', N'1')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'3', N'3', N'3')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'4', N'4', N'3')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'5', N'5', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'6', N'6', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'7', N'7', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'8', N'8', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'9', N'9', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'10', N'10', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'11', N'11', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'12', N'12', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'13', N'13', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'14', N'14', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'15', N'15', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'16', N'16', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'17', N'17', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'18', N'18', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'19', N'19', N'4')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'20', N'20', N'4')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'21', N'21', N'4')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'22', N'22', N'5')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'23', N'23', N'5')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'24', N'24', N'5')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'25', N'25', N'6')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'26', N'26', N'6')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'27', N'27', N'6')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'28', N'28', N'8')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'29', N'29', N'8')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'30', N'30', N'8')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'31', N'31', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'32', N'32', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'33', N'33', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'34', N'34', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'35', N'35', N'9')
GO


-- ----------------------------
-- Table structure for DiasSemana
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[DiasSemana]') AND type IN ('U'))
	DROP TABLE [dbo].[DiasSemana]
GO

CREATE TABLE [dbo].[DiasSemana] (
  [Id] int  NOT NULL,
  [Letra] nchar(1) COLLATE Latin1_General_100_CI_AS  NOT NULL,
  [Dia] varchar(10) COLLATE Latin1_General_100_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[DiasSemana] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of DiasSemana
-- ----------------------------
INSERT INTO [dbo].[DiasSemana]  VALUES (N'7', N'D', N'Domingo')
GO

INSERT INTO [dbo].[DiasSemana]  VALUES (N'4', N'J', N'Jueves')
GO

INSERT INTO [dbo].[DiasSemana]  VALUES (N'1', N'L', N'Lunes')
GO

INSERT INTO [dbo].[DiasSemana]  VALUES (N'2', N'M', N'Martes')
GO

INSERT INTO [dbo].[DiasSemana]  VALUES (N'6', N'S', N'Sábado')
GO

INSERT INTO [dbo].[DiasSemana]  VALUES (N'5', N'V', N'Viernes')
GO

INSERT INTO [dbo].[DiasSemana]  VALUES (N'3', N'X', N'Miercoles')
GO


-- ----------------------------
-- Table structure for Empleos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleos]') AND type IN ('U'))
	DROP TABLE [dbo].[Empleos]
GO

CREATE TABLE [dbo].[Empleos] (
  [Id] int  NOT NULL,
  [Empleo] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Empleos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Empleos
-- ----------------------------
INSERT INTO [dbo].[Empleos]  VALUES (N'1', N'Obrero')
GO

INSERT INTO [dbo].[Empleos]  VALUES (N'2', N'Capataz')
GO

INSERT INTO [dbo].[Empleos]  VALUES (N'3', N'Ingeniero')
GO

INSERT INTO [dbo].[Empleos]  VALUES (N'4', N'Llanero')
GO


-- ----------------------------
-- Table structure for EmpleosPagos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpleosPagos]') AND type IN ('U'))
	DROP TABLE [dbo].[EmpleosPagos]
GO

CREATE TABLE [dbo].[EmpleosPagos] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [id_empleo] int  NULL,
  [importeDia] float(53) DEFAULT ((0)) NULL,
  [importeHoras] float(53) DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[EmpleosPagos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Empresas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresas]') AND type IN ('U'))
	DROP TABLE [dbo].[Empresas]
GO

CREATE TABLE [dbo].[Empresas] (
  [Id] int  NOT NULL,
  [Empresa] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Empresas] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Encargados
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Encargados]') AND type IN ('U'))
	DROP TABLE [dbo].[Encargados]
GO

CREATE TABLE [dbo].[Encargados] (
  [Id] int  NOT NULL,
  [Encargado] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Encargados] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Encargados
-- ----------------------------
INSERT INTO [dbo].[Encargados]  VALUES (N'1', N'El encargado nro 01')
GO


-- ----------------------------
-- Table structure for Fincas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Fincas]') AND type IN ('U'))
	DROP TABLE [dbo].[Fincas]
GO

CREATE TABLE [dbo].[Fincas] (
  [Id] int  NOT NULL,
  [Finca] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL,
  [id_encargado] int DEFAULT NULL NULL
)
GO

ALTER TABLE [dbo].[Fincas] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Fincas
-- ----------------------------
INSERT INTO [dbo].[Fincas]  VALUES (N'1', N'Carlos', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'2', N'Mochila Antonia', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'3', N'Mochila Los Caballos', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'4', N'Finca Nueva', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'5', N'Finca Vieja', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'6', N'JOTE', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'7', N'Lolo Parcelas Chicas', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'8', N'Joaquín', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'9', N'Lolo Grande', NULL)
GO


-- ----------------------------
-- Table structure for Liquidaciones
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Liquidaciones]') AND type IN ('U'))
	DROP TABLE [dbo].[Liquidaciones]
GO

CREATE TABLE [dbo].[Liquidaciones] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Concepto] nvarchar(max) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [Categoria] int DEFAULT NULL NULL,
  [Totales] decimal(18,2) DEFAULT ((0)) NULL,
  [Pagado] bit DEFAULT ((0)) NULL,
  [Fecha] date  NULL
)
GO

ALTER TABLE [dbo].[Liquidaciones] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Liquidaciones
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Liquidaciones] ON
GO

INSERT INTO [dbo].[Liquidaciones] ([Id], [Concepto], [Categoria], [Totales], [Pagado], [Fecha]) VALUES (N'2', N'LIQ. PENDIENTE NRO 001', N'2', N'1800.00', N'0', N'2019-05-03')
GO

INSERT INTO [dbo].[Liquidaciones] ([Id], [Concepto], [Categoria], [Totales], [Pagado], [Fecha]) VALUES (N'3', N'Prueba', N'1', N'110.00', N'1', N'2019-05-04')
GO

INSERT INTO [dbo].[Liquidaciones] ([Id], [Concepto], [Categoria], [Totales], [Pagado], [Fecha]) VALUES (N'4', N'JUBILACION', N'1', N'25000.00', N'1', N'2019-05-05')
GO

SET IDENTITY_INSERT [dbo].[Liquidaciones] OFF
GO


-- ----------------------------
-- Table structure for NominasCab
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[NominasCab]') AND type IN ('U'))
	DROP TABLE [dbo].[NominasCab]
GO

CREATE TABLE [dbo].[NominasCab] (
  [id_cab] int  IDENTITY(1,1) NOT NULL,
  [anio] numeric(4)  NULL,
  [semana] numeric(2)  NULL,
  [id_encargado] int  NULL,
  [status] nchar(1) COLLATE Latin1_General_100_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[NominasCab] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of NominasCab
-- ----------------------------
SET IDENTITY_INSERT [dbo].[NominasCab] ON
GO

INSERT INTO [dbo].[NominasCab] ([id_cab], [anio], [semana], [id_encargado], [status]) VALUES (N'2', N'2019', N'22', NULL, N'A')
GO

INSERT INTO [dbo].[NominasCab] ([id_cab], [anio], [semana], [id_encargado], [status]) VALUES (N'3', N'2019', N'23', NULL, N'A')
GO

SET IDENTITY_INSERT [dbo].[NominasCab] OFF
GO


-- ----------------------------
-- Table structure for NominasDet
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[NominasDet]') AND type IN ('U'))
	DROP TABLE [dbo].[NominasDet]
GO

CREATE TABLE [dbo].[NominasDet] (
  [id_det] int  IDENTITY(1,1) NOT NULL,
  [id_cab] int  NULL,
  [id_empleado] int  NULL,
  [valorD] float(53)  NULL,
  [valorH] float(53)  NULL,
  [lunD] float(53)  NULL,
  [lunH] float(53)  NULL,
  [marD] float(53)  NULL,
  [marH] float(53)  NULL,
  [mieD] float(53)  NULL,
  [mieH] float(53)  NULL,
  [jueD] float(53)  NULL,
  [jueH] float(53)  NULL,
  [vieD] float(53)  NULL,
  [vieH] float(53)  NULL,
  [sabD] float(53)  NULL,
  [sabH] float(53)  NULL,
  [domD] float(53)  NULL,
  [domH] float(53)  NULL,
  [pagado] bit DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[NominasDet] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of NominasDet
-- ----------------------------
SET IDENTITY_INSERT [dbo].[NominasDet] ON
GO

INSERT INTO [dbo].[NominasDet] ([id_det], [id_cab], [id_empleado], [valorD], [valorH], [lunD], [lunH], [marD], [marH], [mieD], [mieH], [jueD], [jueH], [vieD], [vieH], [sabD], [sabH], [domD], [domH], [pagado]) VALUES (N'1', N'2', N'3', N'30', N'2.5', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'0')
GO

INSERT INTO [dbo].[NominasDet] ([id_det], [id_cab], [id_empleado], [valorD], [valorH], [lunD], [lunH], [marD], [marH], [mieD], [mieH], [jueD], [jueH], [vieD], [vieH], [sabD], [sabH], [domD], [domH], [pagado]) VALUES (N'2', N'3', N'3', N'0', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'0', N'1', N'2', N'1')
GO

SET IDENTITY_INSERT [dbo].[NominasDet] OFF
GO


-- ----------------------------
-- Table structure for Proveedores
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Proveedores]') AND type IN ('U'))
	DROP TABLE [dbo].[Proveedores]
GO

CREATE TABLE [dbo].[Proveedores] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Cif] nvarchar(35) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [RazonSocial] nvarchar(max) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [NroCuenta] nvarchar(55) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [Telefono] nvarchar(35) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [Email] nvarchar(55) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [Banco] nvarchar(55) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL
)
GO

ALTER TABLE [dbo].[Proveedores] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Proveedores
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Proveedores] ON
GO

INSERT INTO [dbo].[Proveedores] ([Id], [Cif], [RazonSocial], [NroCuenta], [Telefono], [Email], [Banco]) VALUES (N'1', N'J1234567890', N'Hato el Oso CA', N'0134', N'02914001600', N'vveliz@bufalinda.com', N'Banesco')
GO

INSERT INTO [dbo].[Proveedores] ([Id], [Cif], [RazonSocial], [NroCuenta], [Telefono], [Email], [Banco]) VALUES (N'5', N'J516516165', N'Agrotecnia Monaguense', N'0134', N'02914001601', N'agrense@agrense.com', N'Banesco')
GO

INSERT INTO [dbo].[Proveedores] ([Id], [Cif], [RazonSocial], [NroCuenta], [Telefono], [Email], [Banco]) VALUES (N'6', N'J3175251616', N'Corporacion Clinica UDO', N'0134', N'02916525252', N'ccudo@ccudo.com', N'Banesco')
GO

SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO


-- ----------------------------
-- Table structure for sysdiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sysdiagrams]') AND type IN ('U'))
	DROP TABLE [dbo].[sysdiagrams]
GO

CREATE TABLE [dbo].[sysdiagrams] (
  [name] sysname  NOT NULL,
  [principal_id] int  NOT NULL,
  [diagram_id] int  IDENTITY(1,1) NOT NULL,
  [version] int  NULL,
  [definition] varbinary(max)  NULL
)
GO

ALTER TABLE [dbo].[sysdiagrams] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Trabajadores
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Trabajadores]') AND type IN ('U'))
	DROP TABLE [dbo].[Trabajadores]
GO

CREATE TABLE [dbo].[Trabajadores] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Nro_empleado] nvarchar(max) COLLATE Latin1_General_100_CI_AS DEFAULT '' NULL,
  [Nombre] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL,
  [Apellidos] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL,
  [Telefono] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL,
  [id_empresa] int  NULL,
  [id_casa] int  NULL,
  [foto] ntext COLLATE Latin1_General_100_CI_AS  NULL,
  [foto2] image  NULL,
  [CCC] nvarchar(max) COLLATE Latin1_General_100_CI_AS  NULL,
  [Caja] int  NULL
)
GO

ALTER TABLE [dbo].[Trabajadores] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Trabajadores
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Trabajadores] ON
GO

INSERT INTO [dbo].[Trabajadores] ([Id], [Nro_empleado], [Nombre], [Apellidos], [Telefono], [id_empresa], [id_casa], [foto], [foto2], [CCC], [Caja]) VALUES (N'3', N'A001', N'VICTOR', N'VELIZ', N'04249021432', NULL, N'4', NULL, NULL, NULL, N'1')
GO

SET IDENTITY_INSERT [dbo].[Trabajadores] OFF
GO


-- ----------------------------
-- Table structure for Trabajadores_Empleos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Trabajadores_Empleos]') AND type IN ('U'))
	DROP TABLE [dbo].[Trabajadores_Empleos]
GO

CREATE TABLE [dbo].[Trabajadores_Empleos] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [id_trabajador] int  NULL,
  [id_empleo] int  NULL
)
GO

ALTER TABLE [dbo].[Trabajadores_Empleos] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Trabajadores_Empleos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Trabajadores_Empleos] ON
GO

INSERT INTO [dbo].[Trabajadores_Empleos] ([Id], [id_trabajador], [id_empleo]) VALUES (N'1', N'3', N'3')
GO

SET IDENTITY_INSERT [dbo].[Trabajadores_Empleos] OFF
GO


-- ----------------------------
-- View structure for rpt_nominas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[rpt_nominas]') AND type IN ('V'))
	DROP VIEW [dbo].[rpt_nominas]
GO

CREATE VIEW [dbo].[rpt_nominas] AS SELECT
	cab.anio,
	cab.semana,	
	cab.status,
	cab.id_encargado,
	Encargados.Encargado,
	tra.Nro_empleado,
	tra.trabajador,
	Trabajadores.ccc,
	Empresa,
	tra.id_empleo,
	det.* 
FROM
	NominasCab cab
INNER JOIN NominasDet det ON det.id_cab = cab.id_cab
INNER JOIN vv_nomina_trabajadores tra ON tra.id = det.id_empleado
LEFT JOIN Encargados ON Encargados.Id = cab.id_encargado
LEFT JOIN Trabajadores ON Trabajadores.id = tra.id
LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa
GO


-- ----------------------------
-- View structure for rpt_recibos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[rpt_recibos]') AND type IN ('V'))
	DROP VIEW [dbo].[rpt_recibos]
GO

CREATE VIEW [dbo].[rpt_recibos] AS SELECT
	emp.Empresa,
	tra.Nro_empleado,
	tra.Nombre,
	tra.Apellidos,
	cab.id_cab,
	cab.anio,
	cab.semana,
	cab.id_encargado,
	DATEADD(wk, DATEDIFF(wk, 6, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 6) as semanaIni,
	DATEADD(wk, DATEDIFF(wk, 5, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 5)  as semanaFin,
	(det.lunD + det.marD + mieD + jueD + vieD + sabD + domD) as totalD,
	(det.lunH + det.marH + mieH + jueH + vieH + sabH + domH) as totalH,
	det.valorD,
	det.valorH
FROM
	Trabajadores as tra
LEFT JOIN Empresas AS emp ON emp.id = tra.id_empresa
INNER JOIN NominasDet as det On det.id_empleado = tra.Id
INNER JOIN NominasCab AS cab on cab.id_cab = det.id_cab
GO


-- ----------------------------
-- View structure for vv_CasasCountEmpleados
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_CasasCountEmpleados]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_CasasCountEmpleados]
GO

CREATE VIEW [dbo].[vv_CasasCountEmpleados] AS SELECT
	Casas.Id,
	NroCasa,
	Fincas.Finca,
	COUNT(Trabajadores.Id) as CantEmpleados
FROM
	dbo.Casas
LEFT JOIN Fincas ON Fincas.Id = Casas.id_finca
LEFT JOIN Trabajadores ON Trabajadores.id_casa = Casas.Id
GROUP BY
	Casas.Id,
	NroCasa,
	Fincas.Finca
GO


-- ----------------------------
-- View structure for vv_empleados
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_empleados]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_empleados]
GO

CREATE VIEW [dbo].[vv_empleados] AS SELECT
	Trabajadores.Id,
	CAST ( Trabajadores.Nro_empleado AS VARCHAR ) AS Nro_empleado,
	Trabajadores.Nombre,
	Trabajadores.Apellidos,
	CONCAT ( Trabajadores.Nombre, ' ', Trabajadores.Apellidos ) AS FullName,
	Trabajadores.Telefono,
	CAST ( NroCasa AS VARCHAR ) AS NroCasa,
	Empresa,
	(SELECT DISTINCT SUBSTRING
		(
			(SELECT ',' + Empleos.Empleo AS [text()] FROM Empleos INNER JOIN Trabajadores_Empleos ON Trabajadores_Empleos.id_empleo = Empleos.Id  WHERE Trabajadores_Empleos.id_trabajador = Trabajadores.Id FOR XML PATH ( '' ) ),
			2,
			1000 
		) AS [Empleos] 
	FROM
		Trabajadores_Empleos 
	WHERE
		Trabajadores_Empleos.id_trabajador = Trabajadores.Id 
	) AS Empleos 
FROM
	Trabajadores
	LEFT JOIN Casas ON casas.Id = Trabajadores.id_casa
	LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa
GO


-- ----------------------------
-- View structure for vv_EmpleadosCasas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_EmpleadosCasas]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_EmpleadosCasas]
GO

CREATE VIEW [dbo].[vv_EmpleadosCasas] AS SELECT
	Casas.id AS id_casa,
	Finca,
	Casas.NroCasa,
	Trabajadores.Id AS id_trabajador,
	Trabajadores.Nro_empleado,
	Nombre,
	Apellidos,
	Telefono,
	Empresa 
FROM
	Casas
	INNER JOIN Trabajadores ON Trabajadores.id_casa = Casas.Id
	LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa
	LEFT JOIN Fincas ON Fincas.Id = Casas.id_finca
GO


-- ----------------------------
-- View structure for vv_nomina_trabajadores
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_nomina_trabajadores]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_nomina_trabajadores]
GO

CREATE VIEW [dbo].[vv_nomina_trabajadores] AS SELECT
	tra.id,
	tra.Nro_empleado,
	tra.caja,
	CONCAT ( tra.Nombre, ' ', tra.Apellidos ) AS trabajador,
	fin.id_encargado,
	( SELECT TOP 1 id_empleo FROM Trabajadores_Empleos WHERE Trabajadores_Empleos.id_trabajador = tra.id ) AS id_empleo,
	ISNULL( pag.importeDia, 0 ) AS valorD,
	ISNULL( pag.importeHoras, 0 ) AS valorH 
FROM
	Trabajadores AS tra
	LEFT JOIN Casas AS casa ON casa.Id = tra.id_casa
	LEFT JOIN Fincas AS fin ON fin.Id = casa.id_finca
	LEFT JOIN EmpleosPagos AS pag ON pag.id_empleo = id_empleo --LEFT JOIN Encargados as enc ON enc.Id = fin.id_encargado
GO


-- ----------------------------
-- View structure for vv_nominas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_nominas]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_nominas]
GO

CREATE VIEW [dbo].[vv_nominas] AS SELECT
	cab.anio,
	cab.semana,	
	cab.status,
	cab.id_encargado,
	tra.Nro_empleado,
	tra.caja,
	tra.trabajador,
	tra.id_empleo,
	det.* 
FROM
	NominasCab cab
INNER JOIN NominasDet det ON det.id_cab = cab.id_cab
INNER JOIN vv_nomina_trabajadores tra ON tra.id = det.id_empleado
GO


-- ----------------------------
-- View structure for vv_table_asientos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_table_asientos]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_table_asientos]
GO

CREATE VIEW [dbo].[vv_table_asientos] AS SELECT
	dbo.Asientos.Id,
	dbo.Asientos.id_proveedor,
	dbo.Asientos.id_empresa,
	dbo.Empresas.Empresa,
	dbo.Asientos.FechaFactura,
	dbo.Asientos.Importe,
	dbo.Asientos.FechaPago,
	dbo.Asientos.FormaPago,
	dbo.Asientos.Pagado,
	dbo.Proveedores.RazonSocial,
	dbo.Proveedores.NroCuenta 
FROM
	dbo.Asientos
	LEFT JOIN dbo.Proveedores ON dbo.Proveedores.Id = dbo.Asientos.id_proveedor
	LEFT JOIN dbo.Empresas ON dbo.Empresas.Id = dbo.Asientos.id_empresa
GO


-- ----------------------------
-- View structure for vv_totales_asientos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_totales_asientos]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_totales_asientos]
GO

CREATE VIEW [dbo].[vv_totales_asientos] AS SELECT 
	(SELECT COUNT(b.Id) FROM Asientos as b WHERE b.Pagado = 0) AS AsientosPorPagar,
	SUM ( IIF(a.Pagado = 0, a.Importe, 0 )) AS TotalPagar,
	(SELECT COUNT(x.Id) FROM Asientos as x WHERE x.Pagado = 1) as CantidadPagados
FROM
	Asientos AS a
GO


-- ----------------------------
-- View structure for vv_totales_categorias
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vv_totales_categorias]') AND type IN ('V'))
	DROP VIEW [dbo].[vv_totales_categorias]
GO

CREATE VIEW [dbo].[vv_totales_categorias] AS SELECT 
	Liquidaciones.Categoria,
	SUM( Liquidaciones.Totales ) AS Total
FROM
	Liquidaciones
GROUP BY
	Liquidaciones.Categoria
GO


-- ----------------------------
-- Procedure structure for sp_upgraddiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upgraddiagrams]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_upgraddiagrams]
GO

CREATE PROCEDURE [dbo].[sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
GO


-- ----------------------------
-- Procedure structure for sp_helpdiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_helpdiagrams]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_helpdiagrams]
GO

CREATE PROCEDURE [dbo].[sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
GO


-- ----------------------------
-- Procedure structure for sp_helpdiagramdefinition
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_helpdiagramdefinition]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_helpdiagramdefinition]
GO

CREATE PROCEDURE [dbo].[sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_creatediagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_creatediagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_creatediagram]
GO

CREATE PROCEDURE [dbo].[sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
GO


-- ----------------------------
-- Procedure structure for sp_renamediagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_renamediagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_renamediagram]
GO

CREATE PROCEDURE [dbo].[sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_alterdiagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_alterdiagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_alterdiagram]
GO

CREATE PROCEDURE [dbo].[sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_dropdiagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_dropdiagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_dropdiagram]
GO

CREATE PROCEDURE [dbo].[sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
GO


-- ----------------------------
-- Function structure for fn_diagramobjects
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_diagramobjects]') AND type IN ('FN', 'FS', 'FT', 'IF', 'TF'))
	DROP FUNCTION[dbo].[fn_diagramobjects]
GO

CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
GO


-- ----------------------------
-- Primary Key structure for table __RefactorLog
-- ----------------------------
ALTER TABLE [dbo].[__RefactorLog] ADD CONSTRAINT [PK____Refact__D3AEFFDB696DB36D] PRIMARY KEY CLUSTERED ([OperationKey])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Asientos
-- ----------------------------
ALTER TABLE [dbo].[Asientos] ADD CONSTRAINT [PK__tmp_ms_x__3214EC0712B30BA7] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Casas
-- ----------------------------
ALTER TABLE [dbo].[Casas] ADD CONSTRAINT [PK__Casas__3214EC073F3468B7] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table DiasSemana
-- ----------------------------
ALTER TABLE [dbo].[DiasSemana] ADD CONSTRAINT [PK_DiasSemana] PRIMARY KEY CLUSTERED ([Letra])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Empleos
-- ----------------------------
ALTER TABLE [dbo].[Empleos] ADD CONSTRAINT [PK__Empleos__3214EC07A7318688] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table EmpleosPagos
-- ----------------------------
ALTER TABLE [dbo].[EmpleosPagos] ADD CONSTRAINT [PK__FormasEm__3214EC072147710B] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Empresas
-- ----------------------------
ALTER TABLE [dbo].[Empresas] ADD CONSTRAINT [PK__Empresas__3214EC079C86D4C4] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Encargados
-- ----------------------------
ALTER TABLE [dbo].[Encargados] ADD CONSTRAINT [PK__Encargad__3214EC07CB9071AD] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Fincas
-- ----------------------------
ALTER TABLE [dbo].[Fincas] ADD CONSTRAINT [PK__Fincas__3214EC077F500ED2] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Liquidaciones
-- ----------------------------
ALTER TABLE [dbo].[Liquidaciones] ADD CONSTRAINT [PK__Liquidac__3214EC07AA76C212] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table NominasCab
-- ----------------------------
ALTER TABLE [dbo].[NominasCab] ADD CONSTRAINT [PK__NominasC__D54686CCCCF90994] PRIMARY KEY CLUSTERED ([id_cab])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table NominasDet
-- ----------------------------
ALTER TABLE [dbo].[NominasDet] ADD CONSTRAINT [PK__tmp_ms_x__D5EA63501C1D203D] PRIMARY KEY CLUSTERED ([id_det])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Proveedores
-- ----------------------------
ALTER TABLE [dbo].[Proveedores] ADD CONSTRAINT [PK__Proveedo__3214EC07DD29A119] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table sysdiagrams
-- ----------------------------
ALTER TABLE [dbo].[sysdiagrams] ADD CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED ([principal_id] ASC, [name] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table sysdiagrams
-- ----------------------------
ALTER TABLE [dbo].[sysdiagrams] ADD CONSTRAINT [PK__sysdiagr__C2B05B61EA9FC649] PRIMARY KEY CLUSTERED ([diagram_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Trabajadores
-- ----------------------------
ALTER TABLE [dbo].[Trabajadores] ADD CONSTRAINT [PK__tmp_ms_x__3214EC070049F383] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Trabajadores_Empleos
-- ----------------------------
ALTER TABLE [dbo].[Trabajadores_Empleos] ADD CONSTRAINT [PK__Trabajad__3214EC07C58D89C4] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Asientos
-- ----------------------------
ALTER TABLE [dbo].[Asientos] ADD CONSTRAINT [fk_proveedores] FOREIGN KEY ([id_proveedor]) REFERENCES [dbo].[Proveedores] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Asientos] ADD CONSTRAINT [fk_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Casas
-- ----------------------------
ALTER TABLE [dbo].[Casas] ADD CONSTRAINT [id_finca] FOREIGN KEY ([id_finca]) REFERENCES [dbo].[Fincas] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table EmpleosPagos
-- ----------------------------
ALTER TABLE [dbo].[EmpleosPagos] ADD CONSTRAINT [FK_EmpleoPago_Empleos] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Fincas
-- ----------------------------
ALTER TABLE [dbo].[Fincas] ADD CONSTRAINT [id_encargado] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table NominasCab
-- ----------------------------
ALTER TABLE [dbo].[NominasCab] ADD CONSTRAINT [FK_NominasCab_Encargados] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table NominasDet
-- ----------------------------
ALTER TABLE [dbo].[NominasDet] ADD CONSTRAINT [FK_NominasDet_Trabajadores] FOREIGN KEY ([id_empleado]) REFERENCES [dbo].[Trabajadores] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[NominasDet] ADD CONSTRAINT [fk_NominasDet_NominasCab_pk] FOREIGN KEY ([id_cab]) REFERENCES [dbo].[NominasCab] ([id_cab]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Trabajadores
-- ----------------------------
ALTER TABLE [dbo].[Trabajadores] ADD CONSTRAINT [id_casa] FOREIGN KEY ([id_casa]) REFERENCES [dbo].[Casas] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Trabajadores] ADD CONSTRAINT [id_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Trabajadores_Empleos
-- ----------------------------
ALTER TABLE [dbo].[Trabajadores_Empleos] ADD CONSTRAINT [id_empleo] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Trabajadores_Empleos] ADD CONSTRAINT [fk_id_trabajador] FOREIGN KEY ([id_trabajador]) REFERENCES [dbo].[Trabajadores] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

