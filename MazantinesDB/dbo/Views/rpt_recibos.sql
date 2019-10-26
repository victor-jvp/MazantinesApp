CREATE VIEW [dbo].[rpt_recibos] AS SELECT
	emp.Empresa,
	CAST(tra.Nro_empleado AS VARCHAR(MAX)) as Nro_empleado,
	tra.Nombre,
	tra.Apellidos,
	cab.id_cab,
	tra.caja,
	cab.anio,
	cab.semana,
	cab.id_encargado,
	DATEADD(wk, DATEDIFF(wk, 6, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 6) as semanaIni,
	DATEADD(wk, DATEDIFF(wk, 5, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 5)  as semanaFin,
	(det.lunD + det.marD + mieD + jueD + vieD + sabD + domD) as totalD,
	(det.lunH + det.marH + mieH + jueH + vieH + sabH + domH) as totalH,
	det.valorD,
	det.valorH,
	det.importe
FROM
	Trabajadores as tra
LEFT JOIN Empresas AS emp ON emp.id = tra.id_empresa
INNER JOIN NominasDet as det On det.id_empleado = tra.Id
INNER JOIN NominasCab AS cab on cab.id_cab = det.id_cab