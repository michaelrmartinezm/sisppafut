USE [SEGURIDAD]
GO
/****** Object:  StoredProcedure [dbo].[spVerificarLogin]    Script Date: 09/26/2012 16:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		Milagros Cruz Donayre
-- Create date: 24/09/2012
-- Description:	Este SP permite verificar que el usuario puede loguearse
-- =============================================
ALTER PROCEDURE [dbo].[spVerificarLogin]
	@nombreUsuario varchar(40), @contrasenia varchar(15)
AS
BEGIN
	SET NOCOUNT ON;

   SELECT idUsuario
   FROM Usuario
   WHERE nombreUsuario = @nombreUsuario AND contrasenia = @contrasenia   
   
END
