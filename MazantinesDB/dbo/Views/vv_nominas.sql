CREATE VIEW [dbo].[vv_nominas] AS SELECT        cab.anio, cab.semana, cab.status, cab.id_encargado, tra.Nro_empleado, tra.caja, tra.trabajador, tra.id_empleo, det.id_det, det.id_cab, det.id_empleado, det.valorD, det.valorH, det.lunD, det.lunH, det.marD, det.marH, det.mieD, 
                         det.mieH, det.jueD, det.jueH, det.vieD, det.vieH, det.sabD, det.sabH, det.domD, det.domH, det.pagado
FROM            dbo.NominasCab AS cab INNER JOIN
                         dbo.NominasDet AS det ON det.id_cab = cab.id_cab INNER JOIN
                         dbo.vv_nomina_trabajadores AS tra ON tra.id = det.id_empleado