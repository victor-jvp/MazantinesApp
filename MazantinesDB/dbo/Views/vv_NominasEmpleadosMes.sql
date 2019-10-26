CREATE VIEW [dbo].[vv_NominasEmpleadosMes] AS SELECT
	cab.anio,
	cab.semana,
	cab.id_encargado,
	enc.Encargado,
	CAST (
	tra.Nro_empleado AS VARCHAR ( MAX )) AS Nro_Empleado,
	tra.Caja,
	tra.Nombre,
	tra.Apellidos,
	DATEADD(
		wk,
		DATEDIFF(
			wk,
			6,
		'1/1/' + CONVERT ( VARCHAR ( 10 ), cab.anio )) + ( cab.semana - 1 ),
		6 
	) AS semanaIni,
	DATEADD(
		wk,
		DATEDIFF(
			wk,
			5,
		'1/1/' + CONVERT ( VARCHAR ( 10 ), cab.anio )) + ( cab.semana - 1 ),
		5 
	) AS semanaFin,
	DATEPART(
		mm,
		DATEADD(
			wk,
			DATEDIFF(
				wk,
				6,
			'1/1/' + CONVERT ( VARCHAR ( 10 ), cab.anio )) + ( cab.semana - 1 ),
			6 
		)) AS mesIni,
	SUM ( det.lunD + det.marD + det.mieD + det.jueD + det.vieD + det.sabD + det.domD ) AS totalD,
	SUM ( det.lunH + det.marH + det.mieH + det.jueH + det.vieH + det.sabH + det.domH ) AS totalH,
	det.valorD,
	det.valorH,
	SUM ((
			det.lunD + det.marD + det.mieD + det.jueD + det.vieD + det.sabD + det.domD 
			) * det.valorD + ( det.lunH + det.marH + det.mieH + det.jueH + det.vieH + det.sabH + det.domH ) * det.valorH + det.importe 
	) AS TotalPago 
FROM
	dbo.Trabajadores AS tra
	INNER JOIN dbo.NominasDet AS det ON det.id_empleado = tra.Id
	INNER JOIN dbo.NominasCab AS cab ON cab.id_cab = det.id_cab
	LEFT OUTER JOIN dbo.Encargados AS enc ON enc.Id = cab.id_encargado 
WHERE
	( tra.Activo = 1 ) 
GROUP BY
	cab.anio,
	cab.semana,
	cab.id_encargado,
	enc.Encargado,
	CAST (
	tra.Nro_empleado AS VARCHAR ( MAX )),
	tra.Caja,
	tra.Nombre,
	tra.Apellidos,
	DATEADD(
		wk,
		DATEDIFF(
			wk,
			6,
		'1/1/' + CONVERT ( VARCHAR ( 10 ), cab.anio )) + ( cab.semana - 1 ),
		6 
	),
	DATEADD(
		wk,
		DATEDIFF(
			wk,
			5,
		'1/1/' + CONVERT ( VARCHAR ( 10 ), cab.anio )) + ( cab.semana - 1 ),
		5 
	),
	DATEPART(
		mm,
		DATEADD(
			wk,
			DATEDIFF(
				wk,
				6,
			'1/1/' + CONVERT ( VARCHAR ( 10 ), cab.anio )) + ( cab.semana - 1 ),
			6 
		)),
	det.valorD,
	det.valorH
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vv_NominasEmpleadosMes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tra"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 262
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "det"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 262
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cab"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 262
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "enc"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 498
               Right = 262
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vv_NominasEmpleadosMes';

