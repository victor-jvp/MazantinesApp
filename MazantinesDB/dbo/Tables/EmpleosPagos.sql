CREATE TABLE [dbo].[EmpleosPagos] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_empleo]    INT             NULL,
    [importeDia]   DECIMAL (18, 2) DEFAULT ((0)) NULL,
    [importeHoras] DECIMAL (18, 2) DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EmpleoPago_Empleos] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id])
);

