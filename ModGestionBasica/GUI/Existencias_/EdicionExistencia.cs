using System;
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
namespace ModGestionBasica.Existencias_
{
    public partial class EdicionExistencia : Form
    {
        private bool Modificando = false;
       public string _IDExistencia;
        public string _IDMedicina;
        public string _Unidad;
        public string _Cantidad;

        public EdicionExistencia(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            exitencias em = new exitencias();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            em.IDExistencia = txtid.Text;
            em.IDMedicina = txtidmedicina.Text;
            em.Unidad = txtunidad.Text;
            em.Cantidad = txtcantidad.Text;
            


            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (em.Actualizar())
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
                    if (em.Guardar())
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
        

        public EdicionExistencia()
        {
            InitializeComponent();
        }

        private void EdicionExistencia_Load(object sender, EventArgs e)
        {
            this.txtid.Text = this._IDExistencia;
            this.txtidmedicina.Text = this._IDMedicina;
            this.txtunidad.Text = this._Unidad;
            this.txtcantidad.Text = this._Cantidad;

            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.Existencias_MAX_ID()) + 1;
                this.txtid.Text = Num.ToString();
            } 
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Medecinas.GestionMedecinas frm = new Medecinas.GestionMedecinas();
            frm.ShowDialog();
            if (frm.Seleccionado) {

                txtidmedicina.Text = frm.IDEspecialidadselecionada;
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
    }
}
