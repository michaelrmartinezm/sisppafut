﻿using System;
using System.Collections.Generic;
using System.Text;

using UPC.Proyecto.SISPPAFUT.DL.DALC;
using UPC.Proyecto.SISPPAFUT.BL.BE;

namespace UPC.Proyecto.SISPPAFUT.BL.BC
{
    public class CompeticionBC
    {
        public static class Propiedades
        {
            public static string userLogged { get; set; }
        }

        String Usuario;

        public void RecibirCodigoUsuario(String Usuario)
        {
            this.Usuario = Usuario;
        }

        public int insertar_Competicion(CompeticionBE objCompeticionBE)
        {
            CompeticionDALC objCompeticionDALC = new CompeticionDALC();

            int result = objCompeticionDALC.insertar_Competicion(objCompeticionBE);

            if (result != 0)
            {
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();

                objLogBE.CodOperacion = result;
                objLogBE.Fecha = DateTime.Now;
                String nameHost = System.Net.Dns.GetHostName();
                objLogBE.IP = System.Net.Dns.GetHostAddresses(nameHost).ToString();
                objLogBE.Razon = "Se insertó una nueva competición";
                objLogBE.Tabla = "Competicion";
                objLogBE.Usuario = Propiedades.userLogged;

                objLogBC.RegistrarLog(objLogBE);
            }
            
            return result;
        }

        public List<CompeticionBE> ListarCompeticion(String Pais)
        {
            try
            {
                CompeticionDALC objCompeticionDALC = new CompeticionDALC();
                List<CompeticionBE> lst = objCompeticionDALC.listar_Competicion(Pais);

                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();

                objLogBE.CodOperacion = 0;
                objLogBE.Fecha = DateTime.Now;
                String nameHost = System.Net.Dns.GetHostName();
                objLogBE.IP = System.Net.Dns.GetHostAddresses(nameHost).ToString();
                objLogBE.Razon = "Se listaron las competiciones del pais: "+Pais;
                objLogBE.Tabla = "Competicion";
                objLogBE.Usuario = Propiedades.userLogged;

                objLogBC.RegistrarLog(objLogBE);
                
                return lst;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public CompeticionBE obtenerCompeticion(String _competicion, String pais)
        {
            try
            {
                List<CompeticionBE> lst = new List<CompeticionBE>();
                lst = ListarCompeticion(pais);
                CompeticionBE competicion = new CompeticionBE();
                competicion = null;
                foreach (CompeticionBE cDto in lst)
                {
                    if (cDto.Nombre_competicion == _competicion)
                        return cDto;
                }

                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();

                objLogBE.CodOperacion = competicion.Codigo_competicion;
                objLogBE.Fecha = DateTime.Now;
                String nameHost = System.Net.Dns.GetHostName();
                objLogBE.IP = System.Net.Dns.GetHostAddresses(nameHost).ToString();
                objLogBE.Razon = "Se obtuvo una competición";
                objLogBE.Tabla = "Competicion";
                objLogBE.Usuario = Propiedades.userLogged;

                objLogBC.RegistrarLog(objLogBE);

                return competicion;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
