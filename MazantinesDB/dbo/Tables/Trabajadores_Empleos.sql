CREATE TABLE [dbo].[Trabajadores_Empleos] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [id_trabajador] INT NULL,
    [id_empleo]     INT NULL,
    CONSTRAINT [PK__Trabajad__3214EC07C58D89C4] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_id_trabajador] FOREIGN KEY ([id_trabajador]) REFERENCES [dbo].[Trabajadores] ([Id]),
    CONSTRAINT [id_empleo] FOREIGN KEY ([id_empleo]) REFERENCES [dbo].[Empleos] ([Id])
);





GO
ALTER TABLE [dbo].[Trabajadores_Empleos] SET (LOCK_ESCALATION = AUTO);

