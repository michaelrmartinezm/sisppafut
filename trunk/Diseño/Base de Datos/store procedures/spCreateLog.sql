USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spCreateLog]    Script Date: 10/14/2012 16:52:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCreateLog]
(
			@CodOperacion int
           ,@Tabla varchar(50)
           ,@Usuario varchar(50)          
           ,@IP varchar(23)
           ,@Razon varchar(500)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    INSERT INTO [SISPPAFUT].[dbo].[Log]
           ([CodOperacion]
           ,[Tabla]
           ,[Usuario]
           ,[Fecha]
           ,[IP]
           ,[Razon])
     VALUES
           (
			@CodOperacion,
			@Tabla,
			@Usuario,
			GETDATE(),
			@IP,
			@Razon
           )
      RETURN @@IDENTITY
END
