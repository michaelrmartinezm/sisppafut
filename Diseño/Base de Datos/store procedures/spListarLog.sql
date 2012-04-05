USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spListarLog]    Script Date: 04/05/2012 13:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spListarLog]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;
	SELECT [CodRegistro]
      ,[CodOperacion]
      ,[Tabla]
      ,[Usuario]
      ,[Fecha]
      ,[IP]
      ,[Razon]
  FROM [SISPPAFUT].[dbo].[Log]
END

