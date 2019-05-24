CREATE TABLE [dbo].[Nominas] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [anio]         INT             NULL,
    [semana]       INT             NULL,
    [id_encargado] INT             NULL,
    [id_empleado]  INT             NULL,
    [diaSemana]    NCHAR (1)       NULL,
    [base]         NCHAR (3)       NULL,
    [valor]        FLOAT (53)      NULL,
    [importe]      DECIMAL (18, 2) NULL,
    [status] NCHAR(1) NULL, 
    CONSTRAINT [PK__tmp_ms_x__3214EC07DDEF9985_copy1] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([diaSemana]) REFERENCES [dbo].[DiasSemana] ([Letra]),
    FOREIGN KEY ([id_empleado]) REFERENCES [dbo].[Trabajadores] ([Id]),
    FOREIGN KEY ([id_encargado]) REFERENCES [dbo].[Encargados] ([Id])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'D = DIAS, H = HORAS', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Nominas', @level2type = N'COLUMN', @level2name = N'base';

