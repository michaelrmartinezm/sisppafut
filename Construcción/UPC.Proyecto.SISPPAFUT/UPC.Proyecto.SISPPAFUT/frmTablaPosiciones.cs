﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using UPC.Proyecto.SISPPAFUT.BL.BC;
using UPC.Proyecto.SISPPAFUT.BL.BE;

namespace UPC.Proyecto.SISPPAFUT
{
    public partial class frmTablaPosiciones : Form
    {
        List<TablaPosicionesBE> lst_TablaPosiciones;
        List<PaisBE> lst_Paises;
        List<CompeticionBE> lst_Competiciones;
        List<LigaBE> lst_Ligas;

        public frmTablaPosiciones()
        {
            InitializeComponent();
            IniciarPaises();
        }

        private static frmTablaPosiciones frmMostrarTablaPosiciones = null;

        public static frmTablaPosiciones Instance()
        {
            if (frmMostrarTablaPosiciones == null)
            {
                frmMostrarTablaPosiciones = new frmTablaPosiciones();
            }

            return frmMostrarTablaPosiciones;
        }

        private void IniciarPaises()
        {
            PaisBC objPaisBC;

            try
            {
                objPaisBC = new PaisBC();
                lst_Paises = objPaisBC.listarPaises();

                cmbPais.Items.Clear();
                cmbPais.Items.Add("Seleccione un país...");
                cmbPais.SelectedIndex = 0;

                if (lst_Paises.Count > 0)
                {
                    for (int i = 0; i < lst_Paises.Count; i++)
                    {
                        cmbPais.Items.Add(lst_Paises[i].NombrePais);
                    }
                }
                else
                {
                    MessageBox.Show("No hay países para mostrar.", "Sistema Inteligente para Pronóstico de Partidos de Fútbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void IniciarCompeticiones()
        {
            CompeticionBC objCompeticionBC;

            try
            {
                objCompeticionBC = new CompeticionBC();
                lst_Competiciones = objCompeticionBC.ListarCompeticion(cmbPais.Text);

                cmbCompeticion.Items.Clear();
                cmbCompeticion.Items.Add("Seleccione una competición...");
                cmbCompeticion.SelectedIndex = 0;

                if (lst_Competiciones.Count > 0)
                {
                    for (int i = 0; i < lst_Competiciones.Count; i++)
                    {
                        cmbCompeticion.Items.Add(lst_Competiciones[i].Nombre_competicion);
                    }
                }
                else
                {
                    MessageBox.Show("No hay competiciones para mostrar.", "Sistema Inteligente para Pronóstico de Partidos de Fútbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void IniciarLigas()
        {
            LigaBC objLigaBC;
            
            try
            {
                objLigaBC = new LigaBC();
                lst_Ligas = objLigaBC.listaLigasPorCompeticion(lst_Competiciones[cmbCompeticion.SelectedIndex - 1].Codigo_competicion);

                cmbLiga.Items.Clear();
                cmbLiga.Items.Add("Seleccione una liga...");
                cmbLiga.SelectedIndex = 0;

                if (lst_Ligas.Count > 0)
                {
                    for (int i = 0; i < lst_Ligas.Count; i++)
                    {
                        cmbLiga.Items.Add(lst_Ligas[i].NombreLiga);
                    }
                }
                else
                {
                    MessageBox.Show("No hay ligas para mostrar.", "Sistema Inteligente para Pronóstico de Partidos de Fútbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void inSeleccionarCompeticion(object sender, EventArgs e)
        {
            if (cmbCompeticion.SelectedIndex > 0)
            {
                IniciarLigas();
            }
            else
            {
                cmbLiga.Items.Clear();
            }
            dgvTablaPosiciones.Rows.Clear();
        }

        private void inSeleccionarPais(object sender, EventArgs e)
        {
            if (cmbPais.SelectedIndex > 0)
            {
                IniciarCompeticiones();
            }
            else
            {
                cmbCompeticion.Items.Clear();
                cmbLiga.Items.Clear();
            }
            dgvTablaPosiciones.Rows.Clear();
        }

        private bool ValidarControles()
        {
            if (cmbPais.SelectedIndex <= 0 || cmbLiga.SelectedIndex <= 0 || cmbCompeticion.SelectedIndex <= 0)
                return false;
            return true;
        }

        private void MostrarTablaPosiciones()
        {
            TablaPosicionesBC objTabla;

            try
            {
                if (ValidarControles())
                {
                    objTabla = new TablaPosicionesBC();
                    lst_TablaPosiciones = objTabla.ObtenerTablaPosicionLiga(lst_Ligas[cmbLiga.SelectedIndex - 1].CodigoLiga);

                    dgvTablaPosiciones.Rows.Clear();

                    if (lst_TablaPosiciones.Count > 0)
                    {
                        foreach (TablaPosicionesBE registro in lst_TablaPosiciones)
                        {
                            dgvTablaPosiciones.Rows.Add(registro.posicion, registro.NombreEquipo, registro.PuntosGeneral, registro.PartidosJugadosTotal, registro.VictoriasTotal, registro.EmpatesTotal, registro.DerrotasTotal, registro.GolesAnotadosTotal, registro.GolesEncajadosTotal, registro.partidosJugadosLocal, registro.victoriasLocal, registro.empatesLocal, registro.derrotasLocal, registro.golesAnotadosLocal, registro.golesEncajadosLocal, registro.partidosJugadosVisita, registro.victoriasVisita, registro.empatesVisita, registro.derrotasVisita, registro.golesAnotadosVisita, registro.golesEncajadosVisita);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar todos los datos.", "Sistema Inteligente para Pronóstico de Partidos de Fútbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvTablaPosiciones.Rows.Clear();
            MostrarTablaPosiciones();
        }

        private void InCerrar(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Sistema Inteligente para Pronóstico de Partidos de Fútbol", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        private void inSeleccionarLiga(object sender, EventArgs e)
        {
            dgvTablaPosiciones.Rows.Clear();
        }

        private void dgvTablaPosicionesConfigurar()
        {
            dgvTablaPosiciones.AllowUserToAddRows = false;
            dgvTablaPosiciones.AllowUserToDeleteRows = false;

            dgvTablaPosiciones.AllowUserToResizeColumns = false;
            dgvTablaPosiciones.AllowUserToResizeRows = false;
            dgvTablaPosiciones.AllowDrop = false;

            dgvTablaPosiciones.MultiSelect = false;
            dgvTablaPosiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTablaPosiciones.ReadOnly = true;
        }

        private void inCargarFrm(object sender, EventArgs e)
        {
            dgvTablaPosicionesConfigurar();
        }
    }
}
