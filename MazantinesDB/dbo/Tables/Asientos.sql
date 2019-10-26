CREATE TABLE [dbo].[Asientos] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_proveedor] INT             NULL,
    [FechaFactura] DATETIME        NULL,
    [Importe]      DECIMAL (18, 2) NULL,
    [FechaPago]    DATETIME        NULL,
    [FormaPago]    NVARCHAR (35)   NULL,
    [Pagado]       BIT             NULL,
    [id_empresa]   INT             NULL,
    CONSTRAINT [PK_Asientos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_empresa] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id]),
    CONSTRAINT [fk_proveedores] FOREIGN KEY ([id_proveedor]) REFERENCES [dbo].[Proveedores] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_fk_proveedores]
    ON [dbo].[Asientos]([id_proveedor] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_fk_empresa]
    ON [dbo].[Asientos]([id_empresa] ASC);

