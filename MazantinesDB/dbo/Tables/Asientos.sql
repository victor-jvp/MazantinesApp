CREATE TABLE [dbo].[Asientos] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_proveedor] INT             NULL,
    [id_empresa]   INT             NULL,
    [FechaFactura] DATE            NULL,
    [Importe]      DECIMAL (18, 2) NULL,
    [FechaPago]    DATE            NULL,
    [FormaPago]    NVARCHAR (35)   DEFAULT ('') NULL,
    [Pagado]       BIT             DEFAULT ((0)) NULL,
    CONSTRAINT [PK__tmp_ms_x__3214EC0712B30BA7] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]),
    CONSTRAINT [fk_proveedores] FOREIGN KEY ([id_proveedor]) REFERENCES [dbo].[Proveedores] ([Id])
);



