﻿using System;
using System.Collections.Generic;
using System.Text;

using UPC.Proyecto.SISPPAFUT.DL.DALC;
using UPC.Proyecto.SISPPAFUT.BL.BE;

namespace UPC.Proyecto.SISPPAFUT.BL.BC
{
    public class JugadorBC
    {
        public int insertar_Jugador(JugadorBE objJugadorBE)
        {
            JugadorDALC objJugadorDALC;
            SuspensionBC objSuspensionBC;
            int resultado = 0;
            try
            {
                objJugadorDALC = new JugadorDALC();
                objSuspensionBC = new SuspensionBC();
                                
                resultado = objJugadorDALC.insertar_Jugador(objJugadorBE);
                objSuspensionBC.crear_Suspension(resultado);
                return resultado;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<JugadorBE> listar_Jugadores()
        {
            JugadorDALC objJugadorDALC;

            try
            {
                objJugadorDALC = new JugadorDALC();
                return objJugadorDALC.listar_Jugadores();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<JugadorBE> listar_Jugadores_xEquipo(int codigo_equipo)
        {
            JugadorDALC objJugadorDALC;

            try
            {
                //-- Se lista solo los jugadores que estén habilitados para jugar (excluir jugadores lesionados y suspendidos)
                objJugadorDALC = new JugadorDALC();
                return objJugadorDALC.listar_Jugadores_xEquipo(codigo_equipo);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void asignar_JugadoraEquipo(List<JugadorEquipoBE> lista_jugadores)
        {
            JugadorDALC objJugadorDALC;

            try
            {
                objJugadorDALC = new JugadorDALC();

                for (int i = 0; i < lista_jugadores.Count; i++)
                {
                    objJugadorDALC.asignarJugador_aEquipo(lista_jugadores[i]);
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void editar_Jugador(int codigoJugador, Decimal nAltura, Decimal nPeso)
        {
            JugadorDALC objJugadorDALC;

            try
            {
                objJugadorDALC = new JugadorDALC();
                objJugadorDALC.editarJugador(codigoJugador, nAltura, nPeso);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
