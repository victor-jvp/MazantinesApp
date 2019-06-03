CREATE TABLE [dbo].[EmpleosPagos] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_empleo]    INT             NULL,
    [importeDia]   FLOAT DEFAULT ((0)) NULL,
    [importeHoras] FLOAT DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EmpleoPago_Empleos] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id])
);

