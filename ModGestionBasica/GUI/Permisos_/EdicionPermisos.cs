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
namespace ModGestionBasica.Permisos_
{
    public partial class EdicionPermisos : Form
    {
         private bool Modificando = false;
       public string _IDPermiso;
        public string _IDGrupo;
        public string _IDOpcion;
     

        public EdicionPermisos(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            permisos em = new permisos();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            em.IDPermiso = txtidpermiso.Text;
            em.IDGrupo = txtidgrupo.Text;
            em.IDOpcion = txtidopcion.Text;
            
            


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
        

        public EdicionPermisos()
        {
            InitializeComponent();
        }

        private void EdicionPermisos_Load(object sender, EventArgs e)
        {
            this.txtidpermiso.Text = this._IDPermiso;
            this.txtidgrupo.Text = this._IDGrupo;
            this.txtidopcion.Text = this._IDOpcion;

            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.Permisos_MAX_ID()) + 1;
                this.txtidpermiso.Text = Num.ToString();
            } 
        }

        private void btncargargrupo_Click(object sender, EventArgs e)
        {
            ModGestionBasica.GUI.GestionGrupos frm = new GUI.GestionGrupos(this);
            frm.ShowDialog();

            if (frm.Seleccionado) {
                txtidgrupo.Text = frm.IDGrupoSeleccionado; 
           
            }
        }

        private void btnopciones_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Opciones.GestionOpciones frm = new Opciones.GestionOpciones();
            frm.ShowDialog();
            if (frm.Seleccionada) {
                txtidopcion.Text = frm.IDOpcionSeleccionado;
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
