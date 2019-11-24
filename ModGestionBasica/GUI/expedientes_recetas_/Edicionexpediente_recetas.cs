using CacheManager;
using ModGestionBasica.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModGestionBasica.expedientes_recetas_
{
    public partial class Edicionexpediente_recetas : Form
    {
        public bool Modificando = false;
        public string _ID;
        public string _IDExpediente;
        public string _IDReceta;
        public Edicionexpediente_recetas(bool Modo = false)
        {

            this.Modificando = Modo;
            InitializeComponent();
        }


        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            Expedientes_recetas con = new Expedientes_recetas();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            con.ID = txtid.Text;
            con.IDExpediente = txtidexpediente.Text;
            con.IDReceta = txtidreceta.Text;

            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (con.Actualizar())
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
                    if (con.Guardar())
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

       
        private void Edicionexpediente_recetas_Load(object sender, EventArgs e)
        {
            this.txtid.Text = this._ID;
            this.txtidexpediente.Text = this._IDExpediente;
            this.txtidreceta.Text = this._IDReceta;

            if(!this.Modificando){
                 int Num = Convert.ToInt32(Cache.EXPEDIENTE_RECETAS_MAX_ID()) + 1;
                 this.txtid.Text = Num.ToString();
            
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnexpediente_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Expedientes_.GestionExpedientes frm = new Expedientes_.GestionExpedientes();
            frm.ShowDialog();
            
            if (frm.Seleccionado) {
                txtidexpediente.Text = frm.IDExpedienteSelecionado;
            
            }
        }

        private void btnrecetas_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Recetas_.GestionRecetas frm = new Recetas_.GestionRecetas();
            frm.ShowDialog();
            if (frm.Seleccionado) {

                txtidreceta.Text = frm.IDRecetaSeleccionada;
            }
        }
    }
}
