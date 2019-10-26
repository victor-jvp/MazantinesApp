CREATE TABLE [dbo].[Liquidaciones] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [NroLiquidacion] NVARCHAR (MAX)  NULL,
    [NroFactura]     NVARCHAR (MAX)  NULL,
    [FechaPago]      DATETIME        NULL,
    [Banco]          NVARCHAR (MAX)  NULL,
    [Categoria]      INT             NULL,
    [Totales]        DECIMAL (18, 2) NULL,
    [Pagado]         BIT             NULL,
    [Fecha]          DATETIME        NULL,
    [id_empresa]     INT             NULL,
    [id_fruta]       INT             NULL,
    [DeletedAt]      DATETIME        NULL,
    [id_finca]       INT             NULL,
    [Variedad]       NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Liquidaciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Liquidaci__id_fi__3D2915A8] FOREIGN KEY ([id_finca]) REFERENCES [dbo].[Fincas] ([Id]),
    CONSTRAINT [FK__Liquidaci__id_fr__2FCF1A8A] FOREIGN KEY ([id_fruta]) REFERENCES [dbo].[Frutas] ([Id]),
    CONSTRAINT [fk_id_empresa_liquidaciones] FOREIGN KEY ([id_empresa]) REFERENCES [dbo].[Empresas] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_fk_id_empresa_liquidaciones]
    ON [dbo].[Liquidaciones]([id_empresa] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK__Liquidaci__id_fr__2FCF1A8A]
    ON [dbo].[Liquidaciones]([id_fruta] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK__Liquidaci__id_fi__3D2915A8]
    ON [dbo].[Liquidaciones]([id_finca] ASC);

