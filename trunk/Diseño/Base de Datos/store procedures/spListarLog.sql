USE [SISPPAFUT]
GO

/****** Object:  StoredProcedure [dbo].[spListarLog]    Script Date: 10/13/2012 14:31:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE PROCEDURE [dbo].[spListarLog]
(
		@fecha datetime
)
AS
BEGIN
SELECT	CodRegistro
		,CodOperacion AS 'Elemento'
		,Tabla
		,Usuario
		,Fecha
		,IP AS 'IP Address'
		,Razon AS 'Descripción'
FROM	[SISPPAFUT].[dbo].[Log]
WHERE	Fecha<@fecha
END
GO


