USE [SISPPAFUT]
GO
/****** Object:  StoredProcedure [dbo].[spListarPronosticosParaApostar]    Script Date: 09/05/2012 17:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spListarPronosticosParaApostar]
AS
BEGIN
SELECT	p.CodPronostico, p.CodPartido, l.CodLiga,
		e1.Nombre AS 'Equipo Local', e2.Nombre AS 'Equipo Visita', 
		p.Pronostico, pp.fecha AS 'Fecha'
FROM	Equipo e1, Equipo e2, Pronostico p join Partido pp on p.CodPartido = pp.CodPartido join Liga l on pp.CodLiga = l.CodLiga
WHERE	e1.CodEquipo = pp.CodEquipoL and
		e2.CodEquipo = pp.CodEquipoV and pp.GolesLocal is null and pp.GolesVisita is null
END