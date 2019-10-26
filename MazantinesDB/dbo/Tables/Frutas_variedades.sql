CREATE TABLE [dbo].[Frutas_variedades] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [id_fruta]  INT            NULL,
    [Variedad]  NVARCHAR (MAX) NULL,
    [DeletedAt] DATETIME       NULL,
    CONSTRAINT [PK_Frutas_variedades] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_if_fruta_variedad] FOREIGN KEY ([id_fruta]) REFERENCES [dbo].[Frutas] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_if_fruta_variedad]
    ON [dbo].[Frutas_variedades]([id_fruta] ASC);

