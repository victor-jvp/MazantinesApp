CREATE TABLE [dbo].[NominasDet] (
    [id_det]      INT             IDENTITY (1, 1) NOT NULL,
    [id_cab]      INT             NULL,
    [id_empleado] INT             NULL,
    [valorD]      NUMERIC (18, 2) NULL,
    [valorH]      NUMERIC (18, 2) NULL,
    [lunD]        FLOAT (53)      NULL,
    [lunH]        FLOAT (53)      NULL,
    [marD]        FLOAT (53)      NULL,
    [marH]        FLOAT (53)      NULL,
    [mieD]        FLOAT (53)      NULL,
    [mieH]        FLOAT (53)      NULL,
    [jueD]        FLOAT (53)      NULL,
    [jueH]        FLOAT (53)      NULL,
    [vieD]        FLOAT (53)      NULL,
    [vieH]        FLOAT (53)      NULL,
    [sabD]        FLOAT (53)      NULL,
    [sabH]        FLOAT (53)      NULL,
    [domD]        FLOAT (53)      NULL,
    [domH]        FLOAT (53)      NULL,
    PRIMARY KEY CLUSTERED ([id_det] ASC),
    CONSTRAINT [fk_NominasDet_NominasCab_pk] FOREIGN KEY ([id_cab]) REFERENCES [dbo].[NominasCab] ([id_cab]),
    CONSTRAINT [FK_NominasDet_Trabajadores] FOREIGN KEY ([id_empleado]) REFERENCES [dbo].[Trabajadores] ([Id])
);


