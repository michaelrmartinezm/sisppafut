USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spListarPartidosPorJugar]    Script Date: 09/10/2012 17:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListarPartidosPorJugar]
	
AS
BEGIN
	SET NOCOUNT ON;

    SELECT DISTINCT P.CodPartido, PA.Nombre, L.Nombre, EA.Nombre, EB.Nombre, P.Fecha
    FROM Partido P JOIN Liga L ON (P.CodLiga = L.CodLiga) JOIN Equipo EA ON (P.CodEquipoL = EA.CodEquipo) JOIN Equipo EB ON (P.CodEquipoV = EB.CodEquipo) JOIN Estadio ES ON (P.CodEstadio = ES.CodEstadio) JOIN Competicion CO ON (CO.CodCompeticion = L.CodCompeticion) JOIN Pais PA ON (PA.CodPais = CO.CodPais)
    WHERE GolesLocal is NULL OR GolesVisita is NULL
END
