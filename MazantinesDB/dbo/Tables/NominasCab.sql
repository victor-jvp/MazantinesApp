CREATE TABLE [dbo].[NominasCab]
(
	[id_cab] INT NOT NULL PRIMARY KEY IDENTITY, 
	[anio] NUMERIC(4) NULL,
    [semana] NUMERIC(2) NULL, 
    [id_encargado] INT NULL, 
    [status] NCHAR(1) NULL, 
    CONSTRAINT [FK_NominasCab_Encargados] FOREIGN KEY ([id_encargado]) REFERENCES [Encargados]([Id]), 
)
