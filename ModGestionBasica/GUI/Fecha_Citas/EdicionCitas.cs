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

namespace ModGestionBasica.Fecha_Citas
{
    public partial class EdicionCitas : Form
    {

        private bool Modificando = false;
        public string _IDCita;
        public string _IDPaciente;
        public string _IDDoctor;
        public string _IDConsulta;
        public string _FechaPrixima;
        public EdicionCitas(bool Modo = false)
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            Ficha_citas Modelo = new Ficha_citas(); 
           // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            Modelo.IDCita = txtidcita.Text;
            Modelo.IDPaciente = txtiddoctor.Text;
            Modelo.IDDoctor = txtiddoctor.Text;
            Modelo.IDConsulta = txtidconsulta.Text;
            Modelo.FechaProxima = txtfecha.Text;
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


        private void EdicionCitas_Load(object sender, EventArgs e)
        {
            this.txtidcita.Text = this._IDCita;
            this.txtidpaciente.Text = this._IDPaciente;
            this.txtiddoctor.Text = this._IDDoctor;
            this.txtidconsulta.Text = this._IDConsulta;
            this.txtfecha.Text = this._FechaPrixima;


            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.FECHA_Citas_MAX_ID()) + 1;
                this.txtidcita.Text = Num.ToString();
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

        private void btndoctor_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Doctores.GestionDoctores frm = new Doctores.GestionDoctores();
            frm.ShowDialog();
            if (frm.Selecionado) {
         
                txtiddoctor.Text = frm.IDDoctorSelecionado;
            }
        }

        private void btnmedicina_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Consultas_.GestionConsultas frm = new Consultas_.GestionConsultas();
            frm.ShowDialog();
            if (frm.Seleccionada) {

                txtidconsulta.Text = frm.IDConsultaSelecionada;
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
