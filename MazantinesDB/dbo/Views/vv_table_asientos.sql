CREATE VIEW [dbo].[vv_table_asientos] AS SELECT
	dbo.Asientos.Id,
	dbo.Asientos.id_proveedor,
	dbo.Asientos.id_empresa,
	dbo.Empresas.Empresa,
	dbo.Asientos.Factura,
	dbo.Asientos.FechaFactura,
	dbo.Asientos.Importe,
	dbo.Asientos.FechaPago,
	dbo.Asientos.FormaPago,
	dbo.Asientos.Pagado,
	dbo.Proveedores.RazonSocial,
	dbo.Proveedores.NroCuenta 
FROM
	dbo.Asientos
	LEFT JOIN dbo.Proveedores ON dbo.Proveedores.Id = dbo.Asientos.id_proveedor
	LEFT JOIN dbo.Empresas ON dbo.Empresas.Id = dbo.Asientos.id_empresa
GO



GO


