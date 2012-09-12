USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spListarTablaPosiciones]    Script Date: 09/12/2012 16:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		Cruz Donayre, Milagros
-- Create date: 10/09/2012
-- Description:	Este SP muestra la tabla de posiciones para una competicion en una temporada determinada
-- =============================================
CREATE PROCEDURE [dbo].[spListarTablaPosiciones]
		@CodLiga int
AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT T.CodEquipo, E.Nombre, T.CodLiga, T.CodTabla ,ROW_NUMBER() OVER(ORDER BY T.PuntosLocal+T.PuntosVisita DESC, T.GolesAnotadosLocal DESC, T.GolesEncajadosLocal ASC) AS 'Posición',(T.PuntosLocal+T.PuntosVisita)AS 'Puntos', (T.PartidosJugadosLocal+T.PartidosJugadosVisita) AS 'PJ', (T.VictoriasLocal + T.VictoriasVisita) AS 'G', (T.EmpatesLocal + T.EmpatesVisita) AS 'E', (T.DerrotasLocal + T.DerrotasVisita) AS 'P', (T.GolesAnotadosLocal + T.GolesAnotadosVisita) AS 'GA', (T.GolesEncajadosLocal + T.GolesEncajadosVisita) AS 'GE', T.PartidosJugadosLocal, T.VictoriasLocal, T.EmpatesLocal, T.DerrotasLocal, T.GolesAnotadosLocal, T.GolesEncajadosLocal, T.PartidosJugadosVisita, T.VictoriasVisita, T.EmpatesVisita, T.DerrotasVisita, T.GolesAnotadosVisita, T.GolesEncajadosVisita
	FROM Tabla T JOIN Liga L ON (T.CodLiga = L.CodLiga) JOIN Equipo E ON (E.CodEquipo = T.CodEquipo)
	WHERE T.CodLiga = @CodLiga

END
