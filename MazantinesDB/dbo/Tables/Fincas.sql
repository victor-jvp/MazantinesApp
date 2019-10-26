CREATE TABLE [dbo].[Fincas] (
    [Id]           INT            NOT NULL,
    [Finca]        NVARCHAR (MAX) NULL,
    [id_encargado] INT            NULL,
    CONSTRAINT [PK_Fincas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_id_encargado] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_FK_id_encargado]
    ON [dbo].[Fincas]([id_encargado] ASC);

