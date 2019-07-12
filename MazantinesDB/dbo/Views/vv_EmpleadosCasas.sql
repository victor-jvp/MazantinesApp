CREATE VIEW [dbo].[vv_EmpleadosCasas] AS SELECT
	Casas.id AS id_casa,
	Finca,
	Casas.NroCasa,
	Trabajadores.Id AS id_trabajador,
	Trabajadores.Nro_empleado,
	Nombre,
	Apellidos,
	Telefono,
	Empresa 
FROM
	Casas
	INNER JOIN Trabajadores ON Trabajadores.id_casa = Casas.Id
	LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa
	LEFT JOIN Fincas ON Fincas.Id = Casas.id_finca
WHERE
	Trabajadores.Activo = 1