CREATE TABLE [dbo].[EmpleosPagos] (
    [Id]           INT        IDENTITY (1, 1) NOT NULL,
    [id_empleo]    INT        NULL,
    [importeDia]   FLOAT (53) NULL,
    [importeHoras] FLOAT (53) NULL,
    CONSTRAINT [PK_EmpleosPagos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EmpleoPago_Empleos] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_FK_EmpleoPago_Empleos]
    ON [dbo].[EmpleosPagos]([id_empleo] ASC);

