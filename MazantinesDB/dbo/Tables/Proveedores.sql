CREATE TABLE [dbo].[Proveedores] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Cif]         NVARCHAR (35)  NULL,
    [RazonSocial] NVARCHAR (MAX) NULL,
    [NroCuenta]   NVARCHAR (55)  NULL,
    [Telefono]    NVARCHAR (35)  NULL,
    [Email]       NVARCHAR (55)  NULL,
    [Banco]       NVARCHAR (55)  NULL,
    CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED ([Id] ASC)
);





