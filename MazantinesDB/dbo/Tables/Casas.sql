CREATE TABLE [dbo].[Casas] (
    [Id]       INT NOT NULL,
    [NroCasa]  INT NOT NULL,
    [id_finca] INT NULL,
    CONSTRAINT [PK_Casas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_id_finca] FOREIGN KEY ([id_finca]) REFERENCES [dbo].[Fincas] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_FK_id_finca]
    ON [dbo].[Casas]([id_finca] ASC);

