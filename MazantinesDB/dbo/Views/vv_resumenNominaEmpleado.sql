CREATE VIEW [dbo].[vv_resumenNominaEmpleado] AS SELECT
	NominasCab.anio,
	NominasCab.semana,
	NominasDet.id_empleado,
	NominasDet.pagado,
	valorD,
	valorH,
	(lunD+marD+mieD+jueD+vieD+sabD+domD) as Dias,
	(lunH+marH+mieH+jueH+vieH+sabH+domH) as Horas,
	((lunD+marD+mieD+jueD+vieD+sabD+domD) * valorD) as TotalDias,
	((lunH+marH+mieH+jueH+vieH+sabH+domH) * valorH) as TotalHoras
FROM
	NominasCab
	INNER JOIN NominasDet ON NominasDet.id_cab = NominasCab.id_cab
WHERE
	NominasCab.status = 'C'