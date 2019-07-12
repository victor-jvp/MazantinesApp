CREATE VIEW [dbo].[rpt_nominas] AS SELECT
	cab.anio,
	cab.semana,	
	cab.status,
	cab.id_encargado,
	Encargados.Encargado,
	Trabajadores.Nro_empleado,
	CONCAT(Trabajadores.Nombre, ' ', Trabajadores.apellidos) AS Trabajador,
	Trabajadores.ccc,
	Empresa,
	(	SELECT TOP 1 trabajadores_empleos.id_empleo FROM trabajadores_empleos WHERE trabajadores_empleos.id_trabajador = trabajadores.id) AS id_empleo,
	det.*
FROM
	NominasCab cab
INNER JOIN NominasDet det ON det.id_cab = cab.id_cab
LEFT JOIN Encargados ON Encargados.Id = cab.id_encargado
LEFT JOIN Trabajadores ON Trabajadores.id = det.id_empleado
LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa