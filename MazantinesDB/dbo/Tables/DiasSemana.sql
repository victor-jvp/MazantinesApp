CREATE TABLE [dbo].[DiasSemana] (
    [Id]    INT          NOT NULL,
    [Letra] NCHAR (1)    NOT NULL,
    [Dia]   VARCHAR (10) NULL, 
    CONSTRAINT [PK_DiasSemana] PRIMARY KEY ([Letra])
);

