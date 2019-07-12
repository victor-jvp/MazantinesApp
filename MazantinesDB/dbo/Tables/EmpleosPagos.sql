CREATE TABLE [dbo].[EmpleosPagos] (
    [Id]           INT        IDENTITY (1, 1) NOT NULL,
    [id_empleo]    INT        NULL,
    [importeDia]   FLOAT (53) DEFAULT ((0)) NULL,
    [importeHoras] FLOAT (53) DEFAULT ((0)) NULL,
    CONSTRAINT [PK__FormasEm__3214EC072147710B] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EmpleoPago_Empleos] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id])
);



