CREATE VIEW [dbo].[vv_nomina_trabajadores] AS SELECT
	tra.id,
	tra.Nro_empleado,
	RTRIM(tra.caja) AS Caja,
	CONCAT ( tra.Nombre, ' ', tra.Apellidos ) AS trabajador,
	tra.id_encargado,
	( SELECT TOP 1 id_empleo FROM Trabajadores_Empleos WHERE Trabajadores_Empleos.id_trabajador = tra.id ) AS id_empleo,
	ISNULL(( SELECT TOP 1 importeDia From EmpleosPagos WHERE EmpleosPagos.id_empleo = (SELECT TOP 1 id_empleo FROM Trabajadores_Empleos WHERE Trabajadores_Empleos.id_trabajador = tra.id) ), 0) AS valorD,
	ISNULL(( SELECT TOP 1 importeHoras From EmpleosPagos WHERE EmpleosPagos.id_empleo = (SELECT TOP 1 id_empleo FROM Trabajadores_Empleos WHERE Trabajadores_Empleos.id_trabajador = tra.id) ),0) AS valorH
	/*ISNULL( pag.importeDia, 0 ) AS valorD,
	ISNULL( pag.importeHoras, 0 ) AS valorH */
FROM
	Trabajadores AS tra
	LEFT JOIN Casas AS casa ON casa.Id = tra.id_casa
WHERE
	tra.Activo = 1