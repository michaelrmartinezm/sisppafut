﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using UPC.Proyecto.SISPPAFUT.BL.BE;

namespace UPC.Proyecto.SISPPAFUT.DL.DALC
{
    public class LigaDALC
    {
        public int insertar_Liga(LigaBE objLigaBE)
        {
            SqlConnection conexion = null;
            SqlCommand cmd_LigaInsertar;

            SqlParameter prm_Codigo;
            SqlParameter prm_CodigoCompeticion;
            SqlParameter prm_Temporada;
            SqlParameter prm_Nombre;
            SqlParameter prm_QEquipos;

            int iCodigoLiga;

            String sqlLigaInsertar;

            try
            {
                conexion = new SqlConnection(Properties.Settings.Default.Cadena);

                sqlLigaInsertar = "spCreateLiga";

                cmd_LigaInsertar = new SqlCommand(sqlLigaInsertar, conexion);
                cmd_LigaInsertar.CommandType = CommandType.StoredProcedure;

                prm_Codigo = new SqlParameter();
                prm_Codigo.Direction = ParameterDirection.ReturnValue;
                prm_Codigo.SqlDbType = SqlDbType.Int;

                prm_CodigoCompeticion = new SqlParameter();
                prm_CodigoCompeticion.ParameterName = "@codCompeticion";
                prm_CodigoCompeticion.SqlDbType = SqlDbType.Int;
                prm_CodigoCompeticion.Value = objLigaBE.CodigoCompeticion;

                prm_Temporada = new SqlParameter();
                prm_Temporada.ParameterName = "@temporada";
                prm_Temporada.SqlDbType = SqlDbType.VarChar;
                prm_Temporada.Size = 10;
                prm_Temporada.Value = objLigaBE.TemporadaLiga;

                prm_Nombre = new SqlParameter();
                prm_Nombre.ParameterName = "@nombre";
                prm_Nombre.SqlDbType = SqlDbType.VarChar;
                prm_Nombre.Size = 30;
                prm_Nombre.Value = objLigaBE.NombreLiga;

                prm_QEquipos = new SqlParameter();
                prm_QEquipos.ParameterName = "@qEquipos";
                prm_QEquipos.SqlDbType = SqlDbType.Int;
                prm_QEquipos.Value = objLigaBE.CantidadEquipos;

                cmd_LigaInsertar.Parameters.Add(prm_Codigo);
                cmd_LigaInsertar.Parameters.Add(prm_CodigoCompeticion);
                cmd_LigaInsertar.Parameters.Add(prm_Temporada);
                cmd_LigaInsertar.Parameters.Add(prm_Nombre);
                cmd_LigaInsertar.Parameters.Add(prm_QEquipos);

                cmd_LigaInsertar.Connection.Open();
                cmd_LigaInsertar.ExecuteNonQuery();

                iCodigoLiga = Convert.ToInt32(prm_Codigo.Value);

                return iCodigoLiga;
            }
            catch (Exception)
            {
                //cmd_LigaInsertar.Connection.Close();
                conexion.Dispose();
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State==ConnectionState.Open)
                {
                    //cmd_LigaInsertar.Connection.Close();
                    conexion.Dispose();
                    conexion = null;
                }
            }
        }        

        public int existe_Liga(String nombre)
        {
            SqlConnection conexion = null;
            SqlDataReader dr_liga;
            SqlCommand cmd_LigaValidar;
            String sqlLigaValidar;
            SqlParameter prm_Nombre;

            int cantidad = 0;

            try
            {
                conexion = new SqlConnection(Properties.Settings.Default.Cadena);
                sqlLigaValidar = "spLigaVerificarRepetido";

                cmd_LigaValidar = new SqlCommand(sqlLigaValidar, conexion);
                cmd_LigaValidar.CommandType = CommandType.StoredProcedure;

                prm_Nombre = new SqlParameter();
                prm_Nombre.ParameterName = "@Nombre";
                prm_Nombre.SqlDbType = SqlDbType.VarChar;
                prm_Nombre.Size = 30;
                prm_Nombre.Value = nombre;

                cmd_LigaValidar.Parameters.Add(prm_Nombre);

                cmd_LigaValidar.Connection.Open();
                dr_liga = cmd_LigaValidar.ExecuteReader();

                if (dr_liga.Read())
                {
                    cantidad = dr_liga.GetInt32(dr_liga.GetOrdinal("Cantidad"));
                }

                cmd_LigaValidar.Connection.Close();
                conexion.Dispose();

                return cantidad;
            }
            catch (Exception ex)
            {
                conexion.Dispose();
                throw;
            }
        }

        public List<LigaBE> listar_Ligas()
        {
            SqlConnection conexion = null;
            SqlDataReader dr_ligas;
            SqlCommand cmd_ligas;
            String sqlLigasListar;

            try
            {
                conexion = new SqlConnection(Properties.Settings.Default.Cadena);
                sqlLigasListar = "spListarLigas";
                cmd_ligas = new SqlCommand(sqlLigasListar, conexion);
                cmd_ligas.Connection.Open();
                dr_ligas = cmd_ligas.ExecuteReader();

                List<LigaBE> lista_ligas;
                LigaBE objLigaBE;

                lista_ligas = new List<LigaBE>();

                while (dr_ligas.Read())
                {
                    objLigaBE = new LigaBE();

                    objLigaBE.NombreLiga = dr_ligas.GetString(dr_ligas.GetOrdinal("Nombre"));

                    lista_ligas.Add(objLigaBE);
                }

                cmd_ligas.Connection.Close();
                conexion.Dispose();

                return lista_ligas;
            }

            catch (Exception ex)
            {
                conexion.Dispose();
                throw;
            }

        }
    }
}