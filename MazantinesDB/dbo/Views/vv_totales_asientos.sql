CREATE VIEW [dbo].[vv_totales_asientos] AS SELECT 
	(SELECT COUNT(b.Id) FROM Asientos as b WHERE b.Pagado = 0) AS AsientosPorPagar,
	SUM ( IIF(a.Pagado = 0, a.Importe, 0 )) AS TotalPagar,
	(SELECT COUNT(x.Id) FROM Asientos as x WHERE x.Pagado = 1) as CantidadPagados
FROM
	Asientos AS a