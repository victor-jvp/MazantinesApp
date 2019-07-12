CREATE VIEW [dbo].[vv_totales_categorias] AS SELECT 
	Liquidaciones.Categoria,
	SUM( Liquidaciones.Totales ) AS Total
FROM
	Liquidaciones
GROUP BY
	Liquidaciones.Categoria