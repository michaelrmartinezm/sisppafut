USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spCreateEntrenador]    Script Date: 10/22/2012 18:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spCreateEntrenador]
(
			@Nombres varchar(20)
           ,@Apellidos varchar(20)
           ,@Nacionalidad varchar(20)
           ,@FechaNacimiento datetime
)
AS
BEGIN
INSERT INTO [SISPPAFUT].[dbo].[Entrenador]
           ([Nombres]
           ,[Apellidos]
           ,[Nacionalidad]
           ,[FechaNacimiento])
     VALUES
           (@Nombres
           ,@Apellidos
           ,@Nacionalidad
           ,@FechaNacimiento)
           
           RETURN @@IDENTITY
END
