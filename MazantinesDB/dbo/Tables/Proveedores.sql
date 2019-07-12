CREATE TABLE [dbo].[Proveedores] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Cif]         NVARCHAR (35)  DEFAULT ('') NULL,
    [RazonSocial] NVARCHAR (MAX) DEFAULT ('') NULL,
    [NroCuenta]   NVARCHAR (55)  DEFAULT ('') NULL,
    [Telefono]    NVARCHAR (35)  DEFAULT ('') NULL,
    [Email]       NVARCHAR (55)  DEFAULT ('') NULL,
    [Banco]       NVARCHAR (55)  DEFAULT ('') NULL,
    CONSTRAINT [PK__Proveedo__3214EC07DD29A119] PRIMARY KEY CLUSTERED ([Id] ASC)
);



