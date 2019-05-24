CREATE VIEW [dbo].[vv_nominas] AS SELECT
	cab.anio,
	cab.semana,
	cab.id_encargado,
	cab.status,
	det.* 
FROM
	NominasCab cab
	INNER JOIN NominasDet det ON det.id_cab = cab.id_cab