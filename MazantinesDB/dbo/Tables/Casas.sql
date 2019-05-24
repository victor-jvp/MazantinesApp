CREATE TABLE [dbo].[Casas] (
    [Id]       INT NOT NULL,
    [NroCasa]  INT NOT NULL,
    [id_finca] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [id_finca] FOREIGN KEY ([id_finca]) REFERENCES [dbo].[Fincas] ([Id])
);

