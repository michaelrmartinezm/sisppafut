USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spReadLog]    Script Date: 04/05/2012 13:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spReadLog]
(
	@CodOperacion int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [CodRegistro]
      ,[CodOperacion]
      ,[Tabla]
      ,[Usuario]
      ,[Fecha]
      ,[IP]
      ,[Razon]
  FROM [SISPPAFUT].[dbo].[Log]
  where CodOperacion = @CodOperacion
END

