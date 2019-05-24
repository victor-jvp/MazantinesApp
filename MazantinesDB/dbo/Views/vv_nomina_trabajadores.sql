CREATE VIEW [dbo].[vv_nomina_trabajadores] AS SELECT 
	tra.id,
	tra.Nro_empleado,
	CONCAT(tra.Nombre,' ', tra.Apellidos) as trabajador,
	fin.id_encargado
FROM
	Trabajadores as tra
LEFT JOIN Casas as casa ON casa.Id = tra.id_casa
LEFT JOIN Fincas as fin ON fin.Id = casa.id_finca
--LEFT JOIN Encargados as enc ON enc.Id = fin.id_encargado