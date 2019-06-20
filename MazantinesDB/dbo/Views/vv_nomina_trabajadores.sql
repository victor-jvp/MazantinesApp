CREATE VIEW [dbo].[vv_nomina_trabajadores] AS SELECT
	tra.id,
	tra.Nro_empleado,
	tra.caja,
	CONCAT ( tra.Nombre, ' ', tra.Apellidos ) AS trabajador,
	fin.id_encargado,
	( SELECT TOP 1 id_empleo FROM Trabajadores_Empleos WHERE Trabajadores_Empleos.id_trabajador = tra.id ) AS id_empleo,
	( SELECT TOP 1 importeDia FROM Trabajadores_Empleos INNER JOIN EmpleosPagos ON EmpleosPagos.id_empleo = Trabajadores_Empleos.id_empleo WHERE Trabajadores_Empleos.id_trabajador = tra.id ) AS valorD,
	( SELECT TOP 1 importeHoras FROM Trabajadores_Empleos INNER JOIN EmpleosPagos ON EmpleosPagos.id_empleo = Trabajadores_Empleos.id_empleo WHERE Trabajadores_Empleos.id_trabajador = tra.id ) AS valorH
	--ISNULL( pag.importeDia, 0 ) AS valorD,
	--ISNULL( pag.importeHoras, 0 ) AS valorH 
FROM
	Trabajadores AS tra
	INNER JOIN Casas AS casa ON casa.Id = tra.id_casa
	INNER JOIN Fincas AS fin ON fin.Id = casa.id_finca