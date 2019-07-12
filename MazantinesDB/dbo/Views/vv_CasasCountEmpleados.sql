CREATE VIEW [dbo].[vv_CasasCountEmpleados] AS SELECT
	Casas.Id,
	NroCasa,
	Fincas.Finca,
	COUNT(Trabajadores.Id) as CantEmpleados
FROM
	dbo.Casas
LEFT JOIN Fincas ON Fincas.Id = Casas.id_finca
LEFT JOIN Trabajadores ON Trabajadores.id_casa = Casas.Id
GROUP BY
	Casas.Id,
	NroCasa,
	Fincas.Finca