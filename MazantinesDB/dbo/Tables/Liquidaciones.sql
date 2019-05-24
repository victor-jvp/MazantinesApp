CREATE TABLE [dbo].[Liquidaciones] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Concepto]  NVARCHAR (MAX)  DEFAULT ('') NULL,
    [Categoria] INT             DEFAULT (NULL) NULL,
    [Totales]   DECIMAL (18, 2) DEFAULT ((0)) NULL,
    [Pagado]    BIT             DEFAULT ((0)) NULL,
    [Fecha]     DATE            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

