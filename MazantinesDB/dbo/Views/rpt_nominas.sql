CREATE VIEW [dbo].[rpt_nominas] AS SELECT
	cab.anio,
	cab.semana,	
	cab.status,
	cab.id_encargado,
	Encargados.Encargado,
	tra.Nro_empleado,
	tra.trabajador,
	Trabajadores.ccc,
	Empresa,
	tra.id_empleo,
	det.* 
FROM
	NominasCab cab
INNER JOIN NominasDet det ON det.id_cab = cab.id_cab
INNER JOIN vv_nomina_trabajadores tra ON tra.id = det.id_empleado
LEFT JOIN Encargados ON Encargados.Id = cab.id_encargado
LEFT JOIN Trabajadores ON Trabajadores.id = tra.id
LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa