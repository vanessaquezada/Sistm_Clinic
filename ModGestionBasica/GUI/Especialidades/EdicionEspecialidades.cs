﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ModGestionBasica.CLS;
using CacheManager;
namespace ModGestionBasica.Especialidades
{
    public partial class EdicionEspecialidades : Form
    {

        private bool Modificando = false;
        public string _IDEspecialidad;
        public string _Especialidad;

        public EdicionEspecialidades(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        { 
            //PRIMER PASO, CREACION DE OBJETO
            Especialidad esp = new Especialidad();
           
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            esp.IDEspecialidad = txtIDEspecialiadad.Text;
            esp.Especildad = txtespecialidad.Text;
            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (esp.Actualizar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //INSERTANDO
                try
                {
                    if (esp.Guardar())
                    {
                        MessageBox.Show("registro guardado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 

        public EdicionEspecialidades()
        {
            InitializeComponent();
        }

        private void EdicionEspecialidades_Load(object sender, EventArgs e)
        {
            this.txtIDEspecialiadad.Text = this._IDEspecialidad;
            this.txtespecialidad.Text = this._Especialidad;


            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.Especialiadad_MAX_ID()) + 1;
                this.txtIDEspecialiadad.Text = Num.ToString();
            } 
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtespecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
