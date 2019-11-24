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

using CacheManager;
namespace ModGestionBasica.Doctores
{
    public partial class EdicionDoctor : Form
    {

        private bool Modificando = false;
        public string _IDDoctor;
        public string _IDEmpleado;
        public string _IDEspecialiad;
        public string _Turno;
        public EdicionDoctor(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            Doctoress em = new Doctoress();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            em.IDDoctor = txtididoctor.Text;
            em.IDEMpleado = txtidem.Text;
            em.IDEspecialidad = txtidespecialidad.Text;
            em.Turno = txtturno.Text;
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
        
        private void EdicionDoctor_Load(object sender, EventArgs e)
        {
            this.txtididoctor.Text = this._IDDoctor;
            this.txtidem.Text = this._IDEmpleado;
            this.txtidespecialidad.Text = this._IDEspecialiad;
            this.txtturno.Text = this._Turno;

            if (!this.Modificando)
            {

                int Num = Convert.ToInt32(Cache.DOCTORES_MAX_ID()) + 1;
                this.txtididoctor.Text = Num.ToString();
            }
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Empleadosss.GestionEMpleados frm = new Empleadosss.GestionEMpleados(this);
            frm.ShowDialog();
            if (frm.Seleccionado)
            {
                txtidem.Text = frm.IDEmpleadoSeleccionado;
            }
        }

        private void btnespecialidad_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Especialidades.GestionEspecialidades frmE = new Especialidades.GestionEspecialidades(this);
            frmE.ShowDialog();
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
