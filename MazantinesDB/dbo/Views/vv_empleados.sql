CREATE VIEW [dbo].[vv_empleados] AS SELECT
	Trabajadores.Id,
	Trabajadores.Nro_empleado,
	Trabajadores.Caja,
	Trabajadores.Nombre,
	Trabajadores.Apellidos,
	CONCAT ( Trabajadores.Nombre, ' ', Trabajadores.Apellidos ) AS FullName,
	Encargados.Encargado,
	Trabajadores.Telefono,
	CAST ( NroCasa AS VARCHAR ) AS NroCasa,
	Empresa,
	(SELECT DISTINCT SUBSTRING
		(
			(SELECT ',' + Empleos.Empleo AS [text()] FROM Empleos INNER JOIN Trabajadores_Empleos ON Trabajadores_Empleos.id_empleo = Empleos.Id  WHERE Trabajadores_Empleos.id_trabajador = Trabajadores.Id FOR XML PATH ( '' ) ),
			2,
			1000 
		) AS [Empleos] 
	FROM
		Trabajadores_Empleos 
	WHERE
		Trabajadores_Empleos.id_trabajador = Trabajadores.Id 
	) AS Empleos,
	Trabajadores.Activo
FROM
	Trabajadores
	LEFT JOIN Casas ON casas.Id = Trabajadores.id_casa
	LEFT JOIN Empresas ON Empresas.Id = Trabajadores.id_empresa
	LEFT JOIN Encargados ON Encargados.Id = Trabajadores.id_encargado
WHERE 
	Trabajadores.DeletedAt IS NULL