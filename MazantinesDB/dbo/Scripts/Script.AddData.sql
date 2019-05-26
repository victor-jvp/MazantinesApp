/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*ADD DATA TO FINCAS*/

INSERT INTO [dbo].[Fincas]  VALUES (N'1', N'Carlos', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'2', N'Mochila Antonia', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'3', N'Mochila Los Caballos', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'4', N'Finca Nueva', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'5', N'Finca Vieja', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'6', N'JOTE', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'7', N'Lolo Parcelas Chicas', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'8', N'Joaquín', NULL)
GO

INSERT INTO [dbo].[Fincas]  VALUES (N'9', N'Lolo Grande', NULL)
GO

/*ADD DATA TO CASAS*/

INSERT INTO [dbo].[Casas]  VALUES (N'1', N'1', N'1')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'2', N'2', N'1')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'3', N'3', N'3')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'4', N'4', N'3')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'5', N'5', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'6', N'6', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'7', N'7', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'8', N'8', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'9', N'9', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'10', N'10', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'11', N'11', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'12', N'12', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'13', N'13', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'14', N'14', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'15', N'15', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'16', N'16', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'17', N'17', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'18', N'18', N'2')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'19', N'19', N'4')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'20', N'20', N'4')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'21', N'21', N'4')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'22', N'22', N'5')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'23', N'23', N'5')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'24', N'24', N'5')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'25', N'25', N'6')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'26', N'26', N'6')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'27', N'27', N'6')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'28', N'28', N'8')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'29', N'29', N'8')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'30', N'30', N'8')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'31', N'31', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'32', N'32', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'33', N'33', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'34', N'34', N'9')
GO

INSERT INTO [dbo].[Casas]  VALUES (N'35', N'35', N'9')
GO