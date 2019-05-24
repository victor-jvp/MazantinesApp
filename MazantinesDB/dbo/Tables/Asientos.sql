CREATE TABLE [dbo].[Asientos] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_proveedor] INT             NULL,
    [id_empresa]   INT             NULL,
    [FechaFactura] DATE            NULL,
    [Importe]      DECIMAL (18, 2) NULL,
    [FechaPago]    DATE            NULL,
    [FormaPago]    NVARCHAR (35)   DEFAULT ('') NULL,
    [Pagado]       BIT             CONSTRAINT [DF__Asientos__Estado__7D0E9093] DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]),
    CONSTRAINT [fk_proveedores] FOREIGN KEY ([id_proveedor]) REFERENCES [dbo].[Proveedores] ([Id])
);

