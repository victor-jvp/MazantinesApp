CREATE TABLE [dbo].[Fincas] (
    [Id]           INT            NOT NULL,
    [Finca]        NVARCHAR (MAX) NULL,
    [id_encargado] INT            CONSTRAINT [DF__Fincas__id_encar__04E4BC85] DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [id_encargado] FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);

