CREATE VIEW [dbo].[vv_nominas] AS SELECT
	cab.anio,
	cab.semana,	
	cab.status,
	cab.id_encargado,
	tra.Nro_empleado,
	tra.caja,
	tra.trabajador,
	tra.id_empleo,
	det.* 
FROM
	NominasCab cab
INNER JOIN NominasDet det ON det.id_cab = cab.id_cab
INNER JOIN vv_nomina_trabajadores tra ON tra.id = det.id_empleado