﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
    public class UsuarioDALC
    {
        public int insertar_Usuario(UsuarioBE objUsuarioBE)
        {
            SqlConnection conexion = null;
            SqlCommand cmd_UsuarioInsertar = null;

            SqlParameter prm_CodigoUsuario;
            SqlParameter prm_NombreUsuario;
            SqlParameter prm_Nombre;
            SqlParameter prm_ApellidoPaterno;
            SqlParameter prm_ApellidoMaterno;
            SqlParameter prm_FechaNac;
            SqlParameter prm_Contrasenia;

            int iCodigoUsuario;
            String sqlUsuarioInsertar;

            try
            {
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BDSEGURIDAD"].ConnectionString);
                //Cambiar "Cadena" por la cadena de conexion a SISPPAFUT_seguridad
                sqlUsuarioInsertar = "spCreateUsuario";

                cmd_UsuarioInsertar = new SqlCommand(sqlUsuarioInsertar, conexion);
                cmd_UsuarioInsertar.CommandType = CommandType.StoredProcedure;

                prm_CodigoUsuario = new SqlParameter();
                prm_CodigoUsuario.Direction = ParameterDirection.ReturnValue;
                prm_CodigoUsuario.SqlDbType = SqlDbType.Int;

                prm_NombreUsuario = new SqlParameter();
                prm_NombreUsuario.ParameterName = "@nombreUsuario";
                prm_NombreUsuario.SqlDbType = SqlDbType.VarChar;
                prm_NombreUsuario.Size = 40;
                prm_NombreUsuario.Value = objUsuarioBE.NombreUsuario;

                prm_Nombre = new SqlParameter();
                prm_Nombre.ParameterName = "@nombre";
                prm_Nombre.SqlDbType = SqlDbType.VarChar;
                prm_Nombre.Size = 50;
                prm_Nombre.Value = objUsuarioBE.Nombre;

                prm_ApellidoPaterno = new SqlParameter();
                prm_ApellidoPaterno.ParameterName = "@apellidoPaterno";
                prm_ApellidoPaterno.SqlDbType = SqlDbType.VarChar;
                prm_ApellidoPaterno.Size = 50;
                prm_ApellidoPaterno.Value = objUsuarioBE.ApellidoPaterno;

                prm_ApellidoMaterno = new SqlParameter();
                prm_ApellidoMaterno.ParameterName = "@apellidoMaterno";
                prm_ApellidoMaterno.SqlDbType = SqlDbType.VarChar;
                prm_ApellidoMaterno.Size = 50;
                prm_ApellidoMaterno.Value = objUsuarioBE.ApellidoMaterno;

                prm_FechaNac = new SqlParameter();
                prm_FechaNac.ParameterName = "@fechaNac";
                prm_FechaNac.SqlDbType = SqlDbType.DateTime;
                prm_FechaNac.Value = objUsuarioBE.FechaNacimiento;

                prm_Contrasenia = new SqlParameter();
                prm_Contrasenia.ParameterName = "@contrasenia";
                prm_Contrasenia.SqlDbType = SqlDbType.VarChar;
                prm_Contrasenia.Size = 15;
                prm_Contrasenia.Value = objUsuarioBE.Contrasenia;

                cmd_UsuarioInsertar.Parameters.Add(prm_CodigoUsuario);
                cmd_UsuarioInsertar.Parameters.Add(prm_NombreUsuario);
                cmd_UsuarioInsertar.Parameters.Add(prm_Nombre);
                cmd_UsuarioInsertar.Parameters.Add(prm_ApellidoPaterno);
                cmd_UsuarioInsertar.Parameters.Add(prm_ApellidoMaterno);
                cmd_UsuarioInsertar.Parameters.Add(prm_FechaNac);
                cmd_UsuarioInsertar.Parameters.Add(prm_Contrasenia);

                cmd_UsuarioInsertar.Connection.Open();
                cmd_UsuarioInsertar.ExecuteNonQuery();

                iCodigoUsuario = Convert.ToInt32(prm_CodigoUsuario.Value);

                return iCodigoUsuario;

            }
            catch (Exception ex)
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Dispose();
                }

                throw;
            }

            finally
            {
                cmd_UsuarioInsertar.Connection.Close();
                conexion.Dispose();
            }

        }

        public List<UsuarioBE> listar_usuarios()
        {
            SqlConnection conexion = null;
            SqlDataReader dr_usuarios;
            SqlCommand cmd_usuarios;
            String sqlUsuariosListar;

            try
            {
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BDSEGURIDAD"].ConnectionString);
                sqlUsuariosListar = "spListarUsuarios";
                cmd_usuarios = new SqlCommand(sqlUsuariosListar, conexion);
                cmd_usuarios.Connection.Open();
                dr_usuarios = cmd_usuarios.ExecuteReader();

                List<UsuarioBE> lista_usuarios;
                UsuarioBE objUsuarioBE;

                lista_usuarios = new List<UsuarioBE>();

                while (dr_usuarios.Read())
                {
                    objUsuarioBE = new UsuarioBE();

                    objUsuarioBE.IdUsuario = dr_usuarios.GetInt32(dr_usuarios.GetOrdinal("idUsuario"));
                    objUsuarioBE.NombreUsuario = dr_usuarios.GetString(dr_usuarios.GetOrdinal("nombreUsuario"));
                    objUsuarioBE.Nombre = dr_usuarios.GetString(dr_usuarios.GetOrdinal("nombre"));
                    objUsuarioBE.ApellidoPaterno = dr_usuarios.GetString(dr_usuarios.GetOrdinal("apellidoPaterno"));
                    objUsuarioBE.ApellidoMaterno = dr_usuarios.GetString(dr_usuarios.GetOrdinal("apellidoMaterno"));
                    objUsuarioBE.FechaNacimiento = dr_usuarios.GetDateTime(dr_usuarios.GetOrdinal("fechaNac"));
                    objUsuarioBE.Contrasenia = dr_usuarios.GetString(dr_usuarios.GetOrdinal("contrasenia"));

                    lista_usuarios.Add(objUsuarioBE);
                }

                cmd_usuarios.Connection.Close();
                conexion.Dispose();

                return lista_usuarios;
            }
            catch (Exception ex)
            {
                conexion.Dispose();
                throw;
            }
        }

        public int Verificar_LoginUsuario(String usuario, String contrasenia)
        {
            SqlConnection conexion = null;
            SqlCommand cmd_usuario = null;
            SqlDataReader dr_usuario = null;
            SqlParameter prm_usuario;
            SqlParameter prm_contrasenia;

            String sql_verificarLogin;

            try
            {
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BDSEGURIDAD"].ConnectionString);

                sql_verificarLogin = "spVerificarLogin";

                cmd_usuario = new SqlCommand(sql_verificarLogin, conexion);
                cmd_usuario.CommandType = CommandType.StoredProcedure;

                prm_usuario = new SqlParameter();
                prm_usuario.ParameterName = "@nombreUsuario";
                prm_usuario.SqlDbType = SqlDbType.VarChar;
                prm_usuario.Size = 40;
                prm_usuario.Value = usuario;

                prm_contrasenia = new SqlParameter();
                prm_contrasenia.ParameterName = "@contrasenia";
                prm_contrasenia.SqlDbType = SqlDbType.VarChar;
                prm_contrasenia.Size = 15;
                prm_contrasenia.Value = contrasenia;

                cmd_usuario.Parameters.Add(prm_usuario);
                cmd_usuario.Parameters.Add(prm_contrasenia);

                cmd_usuario.Connection.Open();
                dr_usuario = cmd_usuario.ExecuteReader();

                int idUsuario = 0;

                while (dr_usuario.Read())
                {
                    idUsuario = dr_usuario.GetInt32(dr_usuario.GetOrdinal("idUsuario"));
                }

                cmd_usuario.Connection.Close();
                cmd_usuario.Connection.Dispose();

                return idUsuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Verificar_LoginExiste(String usuario)
        {
            SqlConnection conexion = null;
            SqlCommand cmd_usuario = null;
            SqlDataReader dr_usuario = null;
            SqlParameter prm_usuario;

            String sql_verificarLogin;

            try
            {
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BDSEGURIDAD"].ConnectionString);

                sql_verificarLogin = "spVerificarLoginExiste";

                cmd_usuario = new SqlCommand(sql_verificarLogin, conexion);
                cmd_usuario.CommandType = CommandType.StoredProcedure;

                prm_usuario = new SqlParameter();
                prm_usuario.ParameterName = "@nombre";
                prm_usuario.SqlDbType = SqlDbType.VarChar;
                prm_usuario.Size = 40;
                prm_usuario.Value = usuario;
                                
                cmd_usuario.Parameters.Add(prm_usuario);

                cmd_usuario.Connection.Open();
                dr_usuario = cmd_usuario.ExecuteReader();

                int Cantidad = 0;

                while (dr_usuario.Read())
                {
                    Cantidad = dr_usuario.GetInt32(dr_usuario.GetOrdinal("Cantidad"));
                }

                cmd_usuario.Connection.Close();
                cmd_usuario.Connection.Dispose();

                return Cantidad;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

