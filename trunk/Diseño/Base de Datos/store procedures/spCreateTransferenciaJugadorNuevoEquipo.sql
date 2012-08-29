USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spCreateTransferenciaJugadorNuevoEquipo]    Script Date: 08/29/2012 12:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCreateTransferenciaJugadorNuevoEquipo]
	@CodEquipoNuevo int, @CodJugador int
AS
BEGIN

	SET NOCOUNT ON;
	
	DELETE JugadorEquipo
	WHERE CodJugador = @CodJugador
	
	INSERT INTO JugadorEquipo
	(CodEquipo, CodJugador)
	VALUES
	(@CodEquipoNuevo, @CodJugador)
	
	INSERT INTO HistorialJugadorEquipo
	(CodJugador, CodEquipo)
	VALUES 
	(@CodJugador,@CodEquipoNuevo)

END
