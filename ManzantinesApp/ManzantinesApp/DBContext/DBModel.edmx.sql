
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/26/2019 17:05:38
-- Generated from EDMX file: D:\Repos\MazantinesApp\ManzantinesApp\ManzantinesApp\DBContext\DBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Mazantines];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Liquidaci__id_fi__3D2915A8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidaciones] DROP CONSTRAINT [FK__Liquidaci__id_fi__3D2915A8];
GO
IF OBJECT_ID(N'[dbo].[FK__Liquidaci__id_fr__3C34F16F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidaciones] DROP CONSTRAINT [FK__Liquidaci__id_fr__3C34F16F];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleoPago_Empleos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpleosPagos] DROP CONSTRAINT [FK_EmpleoPago_Empleos];
GO
IF OBJECT_ID(N'[dbo].[fk_empresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Asientos] DROP CONSTRAINT [fk_empresa];
GO
IF OBJECT_ID(N'[dbo].[fk_id_empresa_liquidaciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidaciones] DROP CONSTRAINT [fk_id_empresa_liquidaciones];
GO
IF OBJECT_ID(N'[dbo].[fk_id_trabajador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trabajadores_Empleos] DROP CONSTRAINT [fk_id_trabajador];
GO
IF OBJECT_ID(N'[dbo].[FK_NominasCab_Encargados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NominasCab] DROP CONSTRAINT [FK_NominasCab_Encargados];
GO
IF OBJECT_ID(N'[dbo].[fk_NominasDet_NominasCab_pk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NominasDet] DROP CONSTRAINT [fk_NominasDet_NominasCab_pk];
GO
IF OBJECT_ID(N'[dbo].[FK_NominasDet_Trabajadores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NominasDet] DROP CONSTRAINT [FK_NominasDet_Trabajadores];
GO
IF OBJECT_ID(N'[dbo].[fk_proveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Asientos] DROP CONSTRAINT [fk_proveedores];
GO
IF OBJECT_ID(N'[dbo].[FK_id_casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trabajadores] DROP CONSTRAINT [FK_id_casa];
GO
IF OBJECT_ID(N'[dbo].[FK_id_empleo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trabajadores_Empleos] DROP CONSTRAINT [FK_id_empleo];
GO
IF OBJECT_ID(N'[dbo].[FK_id_empresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trabajadores] DROP CONSTRAINT [FK_id_empresa];
GO
IF OBJECT_ID(N'[dbo].[FK_id_encargado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fincas] DROP CONSTRAINT [FK_id_encargado];
GO
IF OBJECT_ID(N'[dbo].[FK_id_encargado_trabajador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trabajadores] DROP CONSTRAINT [FK_id_encargado_trabajador];
GO
IF OBJECT_ID(N'[dbo].[FK_id_finca]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casas] DROP CONSTRAINT [FK_id_finca];
GO
IF OBJECT_ID(N'[dbo].[FK_if_fruta_variedad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Frutas_variedades] DROP CONSTRAINT [FK_if_fruta_variedad];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Asientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Asientos];
GO
IF OBJECT_ID(N'[dbo].[Casas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casas];
GO
IF OBJECT_ID(N'[dbo].[Empleos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleos];
GO
IF OBJECT_ID(N'[dbo].[EmpleosPagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpleosPagos];
GO
IF OBJECT_ID(N'[dbo].[Empresas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresas];
GO
IF OBJECT_ID(N'[dbo].[Encargados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Encargados];
GO
IF OBJECT_ID(N'[dbo].[Fincas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fincas];
GO
IF OBJECT_ID(N'[dbo].[Frutas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Frutas];
GO
IF OBJECT_ID(N'[dbo].[Frutas_variedades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Frutas_variedades];
GO
IF OBJECT_ID(N'[dbo].[Liquidaciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Liquidaciones];
GO
IF OBJECT_ID(N'[dbo].[NominasCab]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NominasCab];
GO
IF OBJECT_ID(N'[dbo].[NominasDet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NominasDet];
GO
IF OBJECT_ID(N'[dbo].[Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedores];
GO
IF OBJECT_ID(N'[dbo].[Trabajadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trabajadores];
GO
IF OBJECT_ID(N'[dbo].[Trabajadores_Empleos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trabajadores_Empleos];
GO
IF OBJECT_ID(N'[MazantinesModelStoreContainer].[rpt_nominas]', 'U') IS NOT NULL
    DROP TABLE [MazantinesModelStoreContainer].[rpt_nominas];
GO
IF OBJECT_ID(N'[MazantinesModelStoreContainer].[rpt_recibos]', 'U') IS NOT NULL
    DROP TABLE [MazantinesModelStoreContainer].[rpt_recibos];
GO
IF OBJECT_ID(N'[MazantinesModelStoreContainer].[vv_EmpleadosCasas]', 'U') IS NOT NULL
    DROP TABLE [MazantinesModelStoreContainer].[vv_EmpleadosCasas];
GO
IF OBJECT_ID(N'[MazantinesModelStoreContainer].[vv_nomina_trabajadores]', 'U') IS NOT NULL
    DROP TABLE [MazantinesModelStoreContainer].[vv_nomina_trabajadores];
GO
IF OBJECT_ID(N'[MazantinesModelStoreContainer].[vv_nominas]', 'U') IS NOT NULL
    DROP TABLE [MazantinesModelStoreContainer].[vv_nominas];
GO
IF OBJECT_ID(N'[MazantinesModelStoreContainer].[vv_NominasEmpleadosMes]', 'U') IS NOT NULL
    DROP TABLE [MazantinesModelStoreContainer].[vv_NominasEmpleadosMes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Asientos'
CREATE TABLE [dbo].[Asientos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_proveedor] int  NULL,
    [FechaFactura] datetime  NULL,
    [Importe] decimal(18,2)  NULL,
    [FechaPago] datetime  NULL,
    [FormaPago] nvarchar(35)  NULL,
    [Pagado] bit  NULL,
    [id_empresa] int  NULL
);
GO

-- Creating table 'Casas'
CREATE TABLE [dbo].[Casas] (
    [Id] int  NOT NULL,
    [NroCasa] int  NOT NULL,
    [id_finca] int  NULL
);
GO

-- Creating table 'Empleos'
CREATE TABLE [dbo].[Empleos] (
    [Id] int  NOT NULL,
    [Empleo] nvarchar(max)  NULL
);
GO

-- Creating table 'EmpleosPagos'
CREATE TABLE [dbo].[EmpleosPagos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_empleo] int  NULL,
    [importeDia] float  NULL,
    [importeHoras] float  NULL
);
GO

-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [Id] int  NOT NULL,
    [Empresa] nvarchar(max)  NULL
);
GO

-- Creating table 'Encargados'
CREATE TABLE [dbo].[Encargados] (
    [Id] int  NOT NULL,
    [Encargado] nvarchar(max)  NULL
);
GO

-- Creating table 'Fincas'
CREATE TABLE [dbo].[Fincas] (
    [Id] int  NOT NULL,
    [Finca] nvarchar(max)  NULL,
    [id_encargado] int  NULL
);
GO

-- Creating table 'Frutas'
CREATE TABLE [dbo].[Frutas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fruta] varchar(55)  NULL,
    [Status] bit  NULL,
    [DeletedAt] datetime  NULL
);
GO

-- Creating table 'Liquidaciones'
CREATE TABLE [dbo].[Liquidaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NroLiquidacion] nvarchar(max)  NULL,
    [NroFactura] nvarchar(max)  NULL,
    [FechaPago] datetime  NULL,
    [Banco] nvarchar(max)  NULL,
    [Categoria] int  NULL,
    [Totales] decimal(18,2)  NULL,
    [Pagado] bit  NULL,
    [Fecha] datetime  NULL,
    [id_empresa] int  NULL,
    [id_fruta] int  NULL,
    [DeletedAt] datetime  NULL,
    [id_finca] int  NULL,
    [Variedad] nvarchar(max)  NULL
);
GO

-- Creating table 'NominasCab'
CREATE TABLE [dbo].[NominasCab] (
    [id_cab] int IDENTITY(1,1) NOT NULL,
    [anio] decimal(4,0)  NULL,
    [semana] decimal(2,0)  NULL,
    [id_encargado] int  NULL,
    [status] nchar(1)  NULL
);
GO

-- Creating table 'NominasDet'
CREATE TABLE [dbo].[NominasDet] (
    [id_det] int IDENTITY(1,1) NOT NULL,
    [id_cab] int  NULL,
    [id_empleado] int  NULL,
    [valorD] float  NULL,
    [valorH] float  NULL,
    [lunD] float  NULL,
    [lunH] float  NULL,
    [marD] float  NULL,
    [marH] float  NULL,
    [mieD] float  NULL,
    [mieH] float  NULL,
    [jueD] float  NULL,
    [jueH] float  NULL,
    [vieD] float  NULL,
    [vieH] float  NULL,
    [sabD] float  NULL,
    [sabH] float  NULL,
    [domD] float  NULL,
    [domH] float  NULL,
    [pagado] bit  NULL,
    [importe] float  NULL
);
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cif] nvarchar(35)  NULL,
    [RazonSocial] nvarchar(max)  NULL,
    [NroCuenta] nvarchar(55)  NULL,
    [Telefono] nvarchar(35)  NULL,
    [Email] nvarchar(55)  NULL,
    [Banco] nvarchar(55)  NULL
);
GO

-- Creating table 'Trabajadores'
CREATE TABLE [dbo].[Trabajadores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nro_empleado] nvarchar(max)  NULL,
    [Nombre] nvarchar(max)  NULL,
    [Apellidos] nvarchar(max)  NULL,
    [Telefono] nvarchar(max)  NULL,
    [id_empresa] int  NULL,
    [id_casa] int  NULL,
    [foto] nvarchar(max)  NULL,
    [foto2] varbinary(max)  NULL,
    [id_encargado] int  NULL,
    [CCC] nvarchar(max)  NULL,
    [Caja] nvarchar(max)  NULL,
    [Activo] bit  NULL,
    [DeletedAt] datetime  NULL
);
GO

-- Creating table 'Trabajadores_Empleos'
CREATE TABLE [dbo].[Trabajadores_Empleos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_trabajador] int  NULL,
    [id_empleo] int  NULL
);
GO

-- Creating table 'rpt_nominas'
CREATE TABLE [dbo].[rpt_nominas] (
    [anio] decimal(4,0)  NULL,
    [semana] decimal(2,0)  NULL,
    [status] nchar(1)  NULL,
    [id_encargado] int  NULL,
    [Encargado] nvarchar(max)  NULL,
    [Nro_empleado] varchar(max)  NULL,
    [Trabajador] nvarchar(max)  NOT NULL,
    [ccc] nvarchar(max)  NULL,
    [Empresa] nvarchar(max)  NULL,
    [id_empleo] int  NULL,
    [id_det] int  NOT NULL,
    [id_cab] int  NULL,
    [id_empleado] int  NULL,
    [valorD] float  NULL,
    [valorH] float  NULL,
    [lunD] float  NULL,
    [lunH] float  NULL,
    [marD] float  NULL,
    [marH] float  NULL,
    [mieD] float  NULL,
    [mieH] float  NULL,
    [jueD] float  NULL,
    [jueH] float  NULL,
    [vieD] float  NULL,
    [vieH] float  NULL,
    [sabD] float  NULL,
    [sabH] float  NULL,
    [domD] float  NULL,
    [domH] float  NULL,
    [pagado] bit  NULL,
    [caja] nvarchar(max)  NULL,
    [importe] float  NULL
);
GO

-- Creating table 'rpt_recibos'
CREATE TABLE [dbo].[rpt_recibos] (
    [Empresa] nvarchar(max)  NULL,
    [Nro_empleado] varchar(max)  NULL,
    [Nombre] nvarchar(max)  NULL,
    [Apellidos] nvarchar(max)  NULL,
    [id_cab] int  NOT NULL,
    [anio] decimal(4,0)  NULL,
    [semana] decimal(2,0)  NULL,
    [id_encargado] int  NULL,
    [semanaIni] datetime  NULL,
    [semanaFin] datetime  NULL,
    [totalD] float  NULL,
    [totalH] float  NULL,
    [valorD] float  NULL,
    [valorH] float  NULL,
    [caja] nvarchar(max)  NULL,
    [importe] float  NULL
);
GO

-- Creating table 'vv_EmpleadosCasas'
CREATE TABLE [dbo].[vv_EmpleadosCasas] (
    [id_casa] int  NOT NULL,
    [Finca] nvarchar(max)  NULL,
    [NroCasa] int  NOT NULL,
    [id_trabajador] int  NOT NULL,
    [Nro_empleado] varchar(max)  NULL,
    [Nombre] nvarchar(max)  NULL,
    [Apellidos] nvarchar(max)  NULL,
    [Telefono] nvarchar(max)  NULL,
    [Empresa] nvarchar(max)  NULL
);
GO

-- Creating table 'vv_nomina_trabajadores'
CREATE TABLE [dbo].[vv_nomina_trabajadores] (
    [id] int  NOT NULL,
    [Caja] nvarchar(max)  NULL,
    [trabajador] nvarchar(max)  NOT NULL,
    [id_encargado] int  NULL,
    [id_empleo] int  NULL,
    [valorD] float  NOT NULL,
    [valorH] float  NOT NULL,
    [Nro_empleado] varchar(max)  NULL
);
GO

-- Creating table 'vv_nominas'
CREATE TABLE [dbo].[vv_nominas] (
    [anio] decimal(4,0)  NULL,
    [semana] decimal(2,0)  NULL,
    [status] nchar(1)  NULL,
    [id_encargado] int  NULL,
    [Nro_empleado] varchar(max)  NULL,
    [caja] nvarchar(max)  NULL,
    [trabajador] nvarchar(max)  NOT NULL,
    [id_empleo] int  NULL,
    [id_det] int  NOT NULL,
    [id_cab] int  NULL,
    [id_empleado] int  NULL,
    [valorD] float  NULL,
    [valorH] float  NULL,
    [lunD] float  NULL,
    [lunH] float  NULL,
    [marD] float  NULL,
    [marH] float  NULL,
    [mieD] float  NULL,
    [mieH] float  NULL,
    [jueD] float  NULL,
    [jueH] float  NULL,
    [vieD] float  NULL,
    [vieH] float  NULL,
    [sabD] float  NULL,
    [sabH] float  NULL,
    [domD] float  NULL,
    [domH] float  NULL,
    [pagado] bit  NULL,
    [importe] float  NULL
);
GO

-- Creating table 'vv_NominasEmpleadosMes'
CREATE TABLE [dbo].[vv_NominasEmpleadosMes] (
    [id_det] int  NOT NULL,
    [Anio] decimal(4,0)  NULL,
    [Semana] decimal(2,0)  NULL,
    [id_encargado] int  NULL,
    [Encargado] nvarchar(max)  NULL,
    [Nro_Empleado] varchar(max)  NULL,
    [Caja] nvarchar(max)  NULL,
    [Nombre] nvarchar(max)  NULL,
    [Apellidos] nvarchar(max)  NULL,
    [semanaIni] datetime  NULL,
    [semanaFin] datetime  NULL,
    [mesIni] int  NULL,
    [totalD] float  NULL,
    [totalH] float  NULL,
    [valorD] float  NULL,
    [valorH] float  NULL,
    [TotalPago] float  NULL
);
GO

-- Creating table 'Frutas_variedades'
CREATE TABLE [dbo].[Frutas_variedades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_fruta] int  NULL,
    [Variedad] nvarchar(max)  NULL,
    [DeletedAt] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Asientos'
ALTER TABLE [dbo].[Asientos]
ADD CONSTRAINT [PK_Asientos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [PK_Casas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empleos'
ALTER TABLE [dbo].[Empleos]
ADD CONSTRAINT [PK_Empleos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpleosPagos'
ALTER TABLE [dbo].[EmpleosPagos]
ADD CONSTRAINT [PK_EmpleosPagos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Encargados'
ALTER TABLE [dbo].[Encargados]
ADD CONSTRAINT [PK_Encargados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fincas'
ALTER TABLE [dbo].[Fincas]
ADD CONSTRAINT [PK_Fincas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Frutas'
ALTER TABLE [dbo].[Frutas]
ADD CONSTRAINT [PK_Frutas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Liquidaciones'
ALTER TABLE [dbo].[Liquidaciones]
ADD CONSTRAINT [PK_Liquidaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id_cab] in table 'NominasCab'
ALTER TABLE [dbo].[NominasCab]
ADD CONSTRAINT [PK_NominasCab]
    PRIMARY KEY CLUSTERED ([id_cab] ASC);
GO

-- Creating primary key on [id_det] in table 'NominasDet'
ALTER TABLE [dbo].[NominasDet]
ADD CONSTRAINT [PK_NominasDet]
    PRIMARY KEY CLUSTERED ([id_det] ASC);
GO

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trabajadores'
ALTER TABLE [dbo].[Trabajadores]
ADD CONSTRAINT [PK_Trabajadores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trabajadores_Empleos'
ALTER TABLE [dbo].[Trabajadores_Empleos]
ADD CONSTRAINT [PK_Trabajadores_Empleos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Trabajador], [id_det] in table 'rpt_nominas'
ALTER TABLE [dbo].[rpt_nominas]
ADD CONSTRAINT [PK_rpt_nominas]
    PRIMARY KEY CLUSTERED ([Trabajador], [id_det] ASC);
GO

-- Creating primary key on [id_cab] in table 'rpt_recibos'
ALTER TABLE [dbo].[rpt_recibos]
ADD CONSTRAINT [PK_rpt_recibos]
    PRIMARY KEY CLUSTERED ([id_cab] ASC);
GO

-- Creating primary key on [id_casa], [NroCasa], [id_trabajador] in table 'vv_EmpleadosCasas'
ALTER TABLE [dbo].[vv_EmpleadosCasas]
ADD CONSTRAINT [PK_vv_EmpleadosCasas]
    PRIMARY KEY CLUSTERED ([id_casa], [NroCasa], [id_trabajador] ASC);
GO

-- Creating primary key on [id], [trabajador], [valorD], [valorH] in table 'vv_nomina_trabajadores'
ALTER TABLE [dbo].[vv_nomina_trabajadores]
ADD CONSTRAINT [PK_vv_nomina_trabajadores]
    PRIMARY KEY CLUSTERED ([id], [trabajador], [valorD], [valorH] ASC);
GO

-- Creating primary key on [trabajador], [id_det] in table 'vv_nominas'
ALTER TABLE [dbo].[vv_nominas]
ADD CONSTRAINT [PK_vv_nominas]
    PRIMARY KEY CLUSTERED ([trabajador], [id_det] ASC);
GO

-- Creating primary key on [id_det] in table 'vv_NominasEmpleadosMes'
ALTER TABLE [dbo].[vv_NominasEmpleadosMes]
ADD CONSTRAINT [PK_vv_NominasEmpleadosMes]
    PRIMARY KEY CLUSTERED ([id_det] ASC);
GO

-- Creating primary key on [Id] in table 'Frutas_variedades'
ALTER TABLE [dbo].[Frutas_variedades]
ADD CONSTRAINT [PK_Frutas_variedades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_empresa] in table 'Asientos'
ALTER TABLE [dbo].[Asientos]
ADD CONSTRAINT [fk_empresa]
    FOREIGN KEY ([id_empresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_empresa'
CREATE INDEX [IX_fk_empresa]
ON [dbo].[Asientos]
    ([id_empresa]);
GO

-- Creating foreign key on [id_proveedor] in table 'Asientos'
ALTER TABLE [dbo].[Asientos]
ADD CONSTRAINT [fk_proveedores]
    FOREIGN KEY ([id_proveedor])
    REFERENCES [dbo].[Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_proveedores'
CREATE INDEX [IX_fk_proveedores]
ON [dbo].[Asientos]
    ([id_proveedor]);
GO

-- Creating foreign key on [id_casa] in table 'Trabajadores'
ALTER TABLE [dbo].[Trabajadores]
ADD CONSTRAINT [FK_id_casa]
    FOREIGN KEY ([id_casa])
    REFERENCES [dbo].[Casas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_id_casa'
CREATE INDEX [IX_FK_id_casa]
ON [dbo].[Trabajadores]
    ([id_casa]);
GO

-- Creating foreign key on [id_finca] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [FK_id_finca]
    FOREIGN KEY ([id_finca])
    REFERENCES [dbo].[Fincas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_id_finca'
CREATE INDEX [IX_FK_id_finca]
ON [dbo].[Casas]
    ([id_finca]);
GO

-- Creating foreign key on [id_empleo] in table 'EmpleosPagos'
ALTER TABLE [dbo].[EmpleosPagos]
ADD CONSTRAINT [FK_EmpleoPago_Empleos]
    FOREIGN KEY ([id_empleo])
    REFERENCES [dbo].[Empleos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleoPago_Empleos'
CREATE INDEX [IX_FK_EmpleoPago_Empleos]
ON [dbo].[EmpleosPagos]
    ([id_empleo]);
GO

-- Creating foreign key on [id_empleo] in table 'Trabajadores_Empleos'
ALTER TABLE [dbo].[Trabajadores_Empleos]
ADD CONSTRAINT [FK_id_empleo]
    FOREIGN KEY ([id_empleo])
    REFERENCES [dbo].[Empleos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_id_empleo'
CREATE INDEX [IX_FK_id_empleo]
ON [dbo].[Trabajadores_Empleos]
    ([id_empleo]);
GO

-- Creating foreign key on [id_empresa] in table 'Trabajadores'
ALTER TABLE [dbo].[Trabajadores]
ADD CONSTRAINT [FK_id_empresa]
    FOREIGN KEY ([id_empresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_id_empresa'
CREATE INDEX [IX_FK_id_empresa]
ON [dbo].[Trabajadores]
    ([id_empresa]);
GO

-- Creating foreign key on [id_encargado] in table 'NominasCab'
ALTER TABLE [dbo].[NominasCab]
ADD CONSTRAINT [FK_NominasCab_Encargados]
    FOREIGN KEY ([id_encargado])
    REFERENCES [dbo].[Encargados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NominasCab_Encargados'
CREATE INDEX [IX_FK_NominasCab_Encargados]
ON [dbo].[NominasCab]
    ([id_encargado]);
GO

-- Creating foreign key on [id_encargado] in table 'Fincas'
ALTER TABLE [dbo].[Fincas]
ADD CONSTRAINT [FK_id_encargado]
    FOREIGN KEY ([id_encargado])
    REFERENCES [dbo].[Encargados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_id_encargado'
CREATE INDEX [IX_FK_id_encargado]
ON [dbo].[Fincas]
    ([id_encargado]);
GO

-- Creating foreign key on [id_encargado] in table 'Trabajadores'
ALTER TABLE [dbo].[Trabajadores]
ADD CONSTRAINT [FK_id_encargado_trabajador]
    FOREIGN KEY ([id_encargado])
    REFERENCES [dbo].[Encargados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_id_encargado_trabajador'
CREATE INDEX [IX_FK_id_encargado_trabajador]
ON [dbo].[Trabajadores]
    ([id_encargado]);
GO

-- Creating foreign key on [id_cab] in table 'NominasDet'
ALTER TABLE [dbo].[NominasDet]
ADD CONSTRAINT [fk_NominasDet_NominasCab_pk]
    FOREIGN KEY ([id_cab])
    REFERENCES [dbo].[NominasCab]
        ([id_cab])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_NominasDet_NominasCab_pk'
CREATE INDEX [IX_fk_NominasDet_NominasCab_pk]
ON [dbo].[NominasDet]
    ([id_cab]);
GO

-- Creating foreign key on [id_empleado] in table 'NominasDet'
ALTER TABLE [dbo].[NominasDet]
ADD CONSTRAINT [FK_NominasDet_Trabajadores]
    FOREIGN KEY ([id_empleado])
    REFERENCES [dbo].[Trabajadores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NominasDet_Trabajadores'
CREATE INDEX [IX_FK_NominasDet_Trabajadores]
ON [dbo].[NominasDet]
    ([id_empleado]);
GO

-- Creating foreign key on [id_trabajador] in table 'Trabajadores_Empleos'
ALTER TABLE [dbo].[Trabajadores_Empleos]
ADD CONSTRAINT [fk_id_trabajador]
    FOREIGN KEY ([id_trabajador])
    REFERENCES [dbo].[Trabajadores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_id_trabajador'
CREATE INDEX [IX_fk_id_trabajador]
ON [dbo].[Trabajadores_Empleos]
    ([id_trabajador]);
GO

-- Creating foreign key on [id_empresa] in table 'Liquidaciones'
ALTER TABLE [dbo].[Liquidaciones]
ADD CONSTRAINT [fk_id_empresa_liquidaciones]
    FOREIGN KEY ([id_empresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_id_empresa_liquidaciones'
CREATE INDEX [IX_fk_id_empresa_liquidaciones]
ON [dbo].[Liquidaciones]
    ([id_empresa]);
GO

-- Creating foreign key on [id_fruta] in table 'Liquidaciones'
ALTER TABLE [dbo].[Liquidaciones]
ADD CONSTRAINT [FK__Liquidaci__id_fr__2FCF1A8A]
    FOREIGN KEY ([id_fruta])
    REFERENCES [dbo].[Frutas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Liquidaci__id_fr__2FCF1A8A'
CREATE INDEX [IX_FK__Liquidaci__id_fr__2FCF1A8A]
ON [dbo].[Liquidaciones]
    ([id_fruta]);
GO

-- Creating foreign key on [id_fruta] in table 'Frutas_variedades'
ALTER TABLE [dbo].[Frutas_variedades]
ADD CONSTRAINT [FK_if_fruta_variedad]
    FOREIGN KEY ([id_fruta])
    REFERENCES [dbo].[Frutas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_if_fruta_variedad'
CREATE INDEX [IX_FK_if_fruta_variedad]
ON [dbo].[Frutas_variedades]
    ([id_fruta]);
GO

-- Creating foreign key on [id_finca] in table 'Liquidaciones'
ALTER TABLE [dbo].[Liquidaciones]
ADD CONSTRAINT [FK__Liquidaci__id_fi__3D2915A8]
    FOREIGN KEY ([id_finca])
    REFERENCES [dbo].[Fincas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Liquidaci__id_fi__3D2915A8'
CREATE INDEX [IX_FK__Liquidaci__id_fi__3D2915A8]
ON [dbo].[Liquidaciones]
    ([id_finca]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------