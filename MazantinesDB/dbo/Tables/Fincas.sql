CREATE TABLE [dbo].[Fincas] (
    [Id]           INT            NOT NULL,
    [Finca]        NVARCHAR (MAX) NULL,
    [id_encargado] INT            DEFAULT (NULL) NULL,
    CONSTRAINT [PK__Fincas__3214EC077F500ED2] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [id_encargado] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);



