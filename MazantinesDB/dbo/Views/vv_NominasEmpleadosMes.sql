CREATE VIEW [dbo].[vv_NominasEmpleadosMes] AS SELECT
	det.id_det,
	cab.Anio,
	cab.Semana,
	cab.id_encargado,
	enc.Encargado,
	tra.Nro_Empleado,
	tra.Caja,
	tra.Nombre,
	tra.Apellidos,
	DATEADD(wk, DATEDIFF(wk, 6, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 6) as semanaIni,
	DATEADD(wk, DATEDIFF(wk, 5, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 5)  as semanaFin,
	DATEPART(mm, DATEADD(wk, DATEDIFF(wk, 6, '1/1/' + convert(varchar(10),cab.anio)) + (cab.semana-1), 6)) as mesIni,
	(det.lunD + det.marD + mieD + jueD + vieD + sabD + domD) as totalD,
	(det.lunH + det.marH + mieH + jueH + vieH + sabH + domH) as totalH,
	det.valorD,
	det.valorH,
	(((det.lunD + det.marD + mieD + jueD + vieD + sabD + domD) * det.valorD) + ((det.lunH + det.marH + mieH + jueH + vieH + sabH + domH) * det.valorH)) AS TotalPago
FROM
	Trabajadores AS tra
INNER JOIN NominasDet AS det ON det.id_empleado = tra.Id
INNER JOIN NominasCab AS cab ON cab.id_cab = det.id_cab
LEFT JOIN Encargados AS enc ON enc.id = cab.id_encargado
WHERE
	tra.Activo = 1