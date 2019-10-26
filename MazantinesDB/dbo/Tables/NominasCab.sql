CREATE TABLE [dbo].[NominasCab] (
    [id_cab]       INT         IDENTITY (1, 1) NOT NULL,
    [anio]         DECIMAL (4) NULL,
    [semana]       DECIMAL (2) NULL,
    [id_encargado] INT         NULL,
    [status]       NCHAR (1)   NULL,
    CONSTRAINT [PK_NominasCab] PRIMARY KEY CLUSTERED ([id_cab] ASC),
    CONSTRAINT [FK_NominasCab_Encargados] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);



GO
CREATE NONCLUSTERED INDEX [IX_FK_NominasCab_Encargados]
    ON [dbo].[NominasCab]([id_encargado] ASC);

