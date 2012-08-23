USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spLeerHistorialJugador]    Script Date: 08/22/2012 18:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spLeerHistorialJugador]
					@CodJugador int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT E.Nombre, L.Nombre, L.Temporada
	FROM HistorialJugadorEquipo HE JOIN Equipo E ON (HE.CodEquipo = E.CodEquipo) JOIN Liga L ON (L.CodLiga = HE.CodLiga)
	WHERE CodJugador = @CodJugador

END
