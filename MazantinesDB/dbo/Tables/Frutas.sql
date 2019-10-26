CREATE TABLE [dbo].[Frutas] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Fruta]     VARCHAR (55) NULL,
    [Status]    BIT          NULL,
    [DeletedAt] DATETIME     NULL,
    CONSTRAINT [PK_Frutas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

