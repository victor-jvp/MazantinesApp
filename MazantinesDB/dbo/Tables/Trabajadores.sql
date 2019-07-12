CREATE TABLE [dbo].[Trabajadores] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Nro_empleado] NVARCHAR (MAX) DEFAULT ('') NULL,
    [Nombre]       NVARCHAR (MAX) NULL,
    [Apellidos]    NVARCHAR (MAX) NULL,
    [Telefono]     NVARCHAR (MAX) NULL,
    [id_empresa]   INT            DEFAULT (NULL) NULL,
    [id_casa]      INT            DEFAULT (NULL) NULL,
    [id_encargado] INT            DEFAULT (NULL) NULL,
    [foto]         NTEXT          NULL,
    [foto2]        IMAGE          NULL,
    [CCC]          NVARCHAR (MAX) NULL,
    [Caja]         NVARCHAR (MAX) DEFAULT ('') NULL,
    [Activo]       BIT            DEFAULT ((1)) NULL,
    [DeletedAt]    SMALLDATETIME  DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [id_casa] FOREIGN KEY ([id_casa]) REFERENCES [dbo].[Casas] ([Id]),
    CONSTRAINT [id_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]),
    CONSTRAINT [id_encargado_trabajador] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);














GO
ALTER TABLE [dbo].[Trabajadores] SET (LOCK_ESCALATION = AUTO);

