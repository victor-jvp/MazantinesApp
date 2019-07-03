CREATE TABLE [dbo].[Casas] (
    [Id]       INT NOT NULL,
    [NroCasa]  INT NOT NULL,
    [id_finca] INT NULL,
    CONSTRAINT [PK__Casas__3214EC073F3468B7] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [id_finca] FOREIGN KEY ([id_finca]) REFERENCES [dbo].[Fincas] ([Id])
);



