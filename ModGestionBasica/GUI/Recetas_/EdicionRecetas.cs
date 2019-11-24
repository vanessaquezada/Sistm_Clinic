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

namespace ModGestionBasica.Recetas_
{
    public partial class EdicionRecetas : Form
    {

        private bool Modificando= false;
        public string _IDReceta;
        public string _IDDoctor;
        public string _IDPaciente;
        public string _IDMedicina;
        public string _Dosis;
        public string _Cantidad;
        public EdicionRecetas(bool Modo= false)
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            recetas_medicas Modelo = new recetas_medicas();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            Modelo.IDReceta = txtidreceta.Text;
            Modelo.IDDoctor = txtiddoctor.Text;
            Modelo.IDPaciente = txtidpaciente.Text;
            Modelo.IDMedicina = txtidmedicina.Text;
            Modelo.Dosis = txtdocis.Text;
                Modelo.Cantidad=txtcantidad.Text;
            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (Modelo.Actualizar())
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
                    if (Modelo.Guardar())
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

        private void EdicionRecetas_Load(object sender, EventArgs e)
        {
            this.txtidreceta.Text = this._IDReceta;
            this.txtiddoctor.Text = this._IDDoctor;
            this.txtidpaciente.Text = this._IDPaciente;
            this.txtidmedicina.Text = this._IDMedicina;
            this.txtdocis.Text = this._Dosis;
            this.txtcantidad.Text = this._Cantidad;

            if (!this.Modificando) {
                int Num = Convert.ToInt32(Cache.RECETAS_MAX_ID()) + 1;
                this.txtidreceta.Text = Num.ToString();
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

        private void btndoctor_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Doctores.GestionDoctores frm = new Doctores.GestionDoctores();
            frm.ShowDialog();
            if (frm.Selecionado) {

                txtiddoctor.Text = frm.IDDoctorSelecionado;
            }
        }

        private void btnpaciente_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Pacientes_.GestionPacientes frm = new Pacientes_.GestionPacientes();
            frm.ShowDialog();
            if (frm.Seleccionado) {

                txtidpaciente.Text = frm.IDPacienteSeleccionado;
            }
        }

        private void btnmedicina_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Medecinas.GestionMedecinas frm = new Medecinas.GestionMedecinas();
            frm.ShowDialog();
            if (frm.Seleccionado) {

                txtidmedicina.Text = frm.IDEspecialidadselecionada;
            }
        }
    }
}
