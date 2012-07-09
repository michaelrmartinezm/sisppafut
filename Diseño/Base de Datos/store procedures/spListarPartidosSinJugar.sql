USE [SISPPAFUT]
GO

/****** Object:  StoredProcedure [dbo].[spListaPartidosSinJugar]    Script Date: 07/08/2012 19:56:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
Se lista aquellos partidos que ya debiero haberse jugado, 
pero que no se han guardado datos en la tabla de 'JugadorPartido', 
dato m�nimo para verificar que un partido se ha efectuado
*/
CREATE PROCEDURE [dbo].[spListaPartidosSinJugar]
AS
BEGIN
	SELECT	DISTINCT f1.CodPartido, p1.Nombre, l1.Nombre, e1.Nombre, e2.Nombre , f1.Fecha
	FROM	Equipo e1, Equipo e2, Liga l1, Pais p1, Competicion c2,
			Liga l2 join Partido f1 on l2.CodLiga = f1.CodLiga
	WHERE	f1.CodEquipoL = e1.CodEquipo and
			f1.CodEquipoV = e2.CodEquipo and
			f1.CodLiga = l1.CodLiga and
			p1.CodPais = c2.CodPais and
			c2.CodCompeticion = l1.CodCompeticion and
			DATEDIFF(DAY, f1.Fecha, GETDATE())>0 AND
			(	SELECT	COUNT(*)
				FROM	JugadorPartido JP
				WHERE	JP.CodPartido = f1.CodPartido
			)=0
END

GO


