CREATE VIEW [dbo].[vv_nomina_trabajadores] AS SELECT
	tra.id,
	tra.Nro_empleado,
	tra.caja,
	CONCAT ( tra.Nombre, ' ', tra.Apellidos ) AS trabajador,
	fin.id_encargado,
	( SELECT TOP 1 id_empleo FROM Trabajadores_Empleos WHERE Trabajadores_Empleos.id_trabajador = tra.id ) AS id_empleo,
	ISNULL( pag.importeDia, 0 ) AS valorD,
	ISNULL( pag.importeHoras, 0 ) AS valorH 
FROM
	Trabajadores AS tra
	LEFT JOIN Casas AS casa ON casa.Id = tra.id_casa
	LEFT JOIN Fincas AS fin ON fin.Id = casa.id_finca
	LEFT JOIN EmpleosPagos AS pag ON pag.id_empleo = id_empleo --LEFT JOIN Encargados as enc ON enc.Id = fin.id_encargado