﻿namespace UPC.Proyecto.SISPPAFUT
{
    partial class frmAsignarJugadoresaEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            frmAsignarJugador = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarJugadoresaEquipo));
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.lbl_jugador = new System.Windows.Forms.Label();
            this.cmb_paises = new System.Windows.Forms.ComboBox();
            this.cmb_equipos = new System.Windows.Forms.ComboBox();
            this.cmb_jugadores = new System.Windows.Forms.ComboBox();
            this.btn_agregar_jugadores = new System.Windows.Forms.Button();
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.h_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(7, 19);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(35, 13);
            this.lbl_pais.TabIndex = 0;
            this.lbl_pais.Text = "País :";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(250, 19);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(46, 13);
            this.lbl_equipo.TabIndex = 1;
            this.lbl_equipo.Text = "Equipo :";
            // 
            // lbl_jugador
            // 
            this.lbl_jugador.AutoSize = true;
            this.lbl_jugador.Location = new System.Drawing.Point(7, 22);
            this.lbl_jugador.Name = "lbl_jugador";
            this.lbl_jugador.Size = new System.Drawing.Size(47, 13);
            this.lbl_jugador.TabIndex = 2;
            this.lbl_jugador.Text = "Nombre:";
            // 
            // cmb_paises
            // 
            this.cmb_paises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paises.FormattingEnabled = true;
            this.cmb_paises.Location = new System.Drawing.Point(54, 16);
            this.cmb_paises.Name = "cmb_paises";
            this.cmb_paises.Size = new System.Drawing.Size(178, 21);
            this.cmb_paises.TabIndex = 3;
            this.cmb_paises.SelectedIndexChanged += new System.EventHandler(this.inSeleccionarPais);
            // 
            // cmb_equipos
            // 
            this.cmb_equipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_equipos.FormattingEnabled = true;
            this.cmb_equipos.Location = new System.Drawing.Point(311, 16);
            this.cmb_equipos.Name = "cmb_equipos";
            this.cmb_equipos.Size = new System.Drawing.Size(178, 21);
            this.cmb_equipos.TabIndex = 4;
            this.cmb_equipos.SelectedIndexChanged += new System.EventHandler(this.inSeleccionarEquipo);
            // 
            // cmb_jugadores
            // 
            this.cmb_jugadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_jugadores.FormattingEnabled = true;
            this.cmb_jugadores.Location = new System.Drawing.Point(72, 19);
            this.cmb_jugadores.Name = "cmb_jugadores";
            this.cmb_jugadores.Size = new System.Drawing.Size(178, 21);
            this.cmb_jugadores.TabIndex = 5;
            // 
            // btn_agregar_jugadores
            // 
            this.btn_agregar_jugadores.Location = new System.Drawing.Point(311, 19);
            this.btn_agregar_jugadores.Name = "btn_agregar_jugadores";
            this.btn_agregar_jugadores.Size = new System.Drawing.Size(105, 21);
            this.btn_agregar_jugadores.TabIndex = 6;
            this.btn_agregar_jugadores.Text = "Agregar a equipo";
            this.btn_agregar_jugadores.UseVisualStyleBackColor = true;
            this.btn_agregar_jugadores.Click += new System.EventHandler(this.btn_agregar_jugadores_Click);
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h_nombre,
            this.h_apellido,
            this.h_nacionalidad,
            this.h_posicion,
            this.h_fecha,
            this.h_codigo,
            this.h_peso,
            this.h_altura,
            this.Eliminar});
            this.dgv_jugadores.Location = new System.Drawing.Point(40, 125);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.Size = new System.Drawing.Size(497, 150);
            this.dgv_jugadores.TabIndex = 7;
            this.dgv_jugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_jugadores_CellContentClick);
            // 
            // h_nombre
            // 
            this.h_nombre.DataPropertyName = "Nombres";
            this.h_nombre.HeaderText = "Nombre";
            this.h_nombre.Name = "h_nombre";
            // 
            // h_apellido
            // 
            this.h_apellido.DataPropertyName = "Apellidos";
            this.h_apellido.HeaderText = "Apellido";
            this.h_apellido.Name = "h_apellido";
            // 
            // h_nacionalidad
            // 
            this.h_nacionalidad.DataPropertyName = "Nacionalidad";
            this.h_nacionalidad.HeaderText = "Nacionalidad";
            this.h_nacionalidad.Name = "h_nacionalidad";
            // 
            // h_posicion
            // 
            this.h_posicion.DataPropertyName = "Posicion";
            this.h_posicion.HeaderText = "Posición";
            this.h_posicion.Name = "h_posicion";
            // 
            // h_fecha
            // 
            this.h_fecha.DataPropertyName = "FechaNacimiento";
            this.h_fecha.HeaderText = "Nacimiento";
            this.h_fecha.Name = "h_fecha";
            this.h_fecha.Visible = false;
            // 
            // h_codigo
            // 
            this.h_codigo.DataPropertyName = "CodigoJugador";
            this.h_codigo.HeaderText = "Codigo";
            this.h_codigo.Name = "h_codigo";
            this.h_codigo.Visible = false;
            // 
            // h_peso
            // 
            this.h_peso.DataPropertyName = "Peso";
            this.h_peso.HeaderText = "Peso";
            this.h_peso.Name = "h_peso";
            this.h_peso.Visible = false;
            // 
            // h_altura
            // 
            this.h_altura.DataPropertyName = "Altura";
            this.h_altura.HeaderText = "Altura";
            this.h_altura.Name = "h_altura";
            this.h_altura.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 49;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(462, 293);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_paises);
            this.groupBox1.Controls.Add(this.lbl_pais);
            this.groupBox1.Controls.Add(this.lbl_equipo);
            this.groupBox1.Controls.Add(this.cmb_equipos);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 45);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_jugadores);
            this.groupBox2.Controls.Add(this.lbl_jugador);
            this.groupBox2.Controls.Add(this.btn_agregar_jugadores);
            this.groupBox2.Location = new System.Drawing.Point(40, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 52);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugadores";
            // 
            // frmAsignarJugadoresaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_jugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignarJugadoresaEquipo";
            this.Text = "Asignar Jugadores a un Equipo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inCerrar);
            this.Load += new System.EventHandler(this.frmAsignarJugadoresaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.Label lbl_jugador;
        private System.Windows.Forms.ComboBox cmb_paises;
        private System.Windows.Forms.ComboBox cmb_equipos;
        private System.Windows.Forms.ComboBox cmb_jugadores;
        private System.Windows.Forms.Button btn_agregar_jugadores;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_altura;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}