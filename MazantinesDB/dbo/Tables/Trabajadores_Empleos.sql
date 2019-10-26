CREATE TABLE [dbo].[Trabajadores_Empleos] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [id_trabajador] INT NULL,
    [id_empleo]     INT NULL,
    CONSTRAINT [PK_Trabajadores_Empleos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_id_empleo] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id]),
    CONSTRAINT [fk_id_trabajador] FOREIGN KEY ([id_trabajador]) REFERENCES [dbo].[Trabajadores] ([Id])
);







GO
CREATE NONCLUSTERED INDEX [IX_fk_id_trabajador]
    ON [dbo].[Trabajadores_Empleos]([id_trabajador] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_id_empleo]
    ON [dbo].[Trabajadores_Empleos]([id_empleo] ASC);

