CREATE TABLE [dbo].[Trabajadores] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Nro_empleado] NVARCHAR (MAX)  NULL,
    [Nombre]       NVARCHAR (MAX)  NULL,
    [Apellidos]    NVARCHAR (MAX)  NULL,
    [Telefono]     NVARCHAR (MAX)  NULL,
    [id_empresa]   INT             NULL,
    [id_casa]      INT             NULL,
    [foto]         NVARCHAR (MAX)  NULL,
    [foto2]        VARBINARY (MAX) NULL,
    [id_encargado] INT             NULL,
    [CCC]          NVARCHAR (MAX)  NULL,
    [Caja]         NVARCHAR (MAX)  NULL,
    [Activo]       BIT             NULL,
    [DeletedAt]    DATETIME        NULL,
    CONSTRAINT [PK_Trabajadores] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_id_casa] FOREIGN KEY ([id_casa]) REFERENCES [dbo].[Casas] ([Id]),
    CONSTRAINT [FK_id_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]),
    CONSTRAINT [FK_id_encargado_trabajador] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);
















GO
CREATE NONCLUSTERED INDEX [IX_FK_id_encargado_trabajador]
    ON [dbo].[Trabajadores]([id_encargado] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_id_empresa]
    ON [dbo].[Trabajadores]([id_empresa] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_id_casa]
    ON [dbo].[Trabajadores]([id_casa] ASC);

