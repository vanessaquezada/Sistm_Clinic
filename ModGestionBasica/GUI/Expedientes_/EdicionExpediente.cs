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

namespace ModGestionBasica.Expedientes_
{
    public partial class EdicionExpediente : Form
    {
        private bool Modificando = false;
        public string _IDExpediente;
        public string _IDDoctor;
        public string  _IDPaciente;
        public string  _FreqCardiaca;
        public string  _FreqRespiratoria;
        public string  _Temperatura;
        public string  _PesoActual;
        public string  _Altura;
        public string  _Sintomas;
        public string  _Diagnostico;
        public string  _Indicaciones;

        public EdicionExpediente(bool Modo= false)
        {
            this.Modificando = Modo;
            InitializeComponent();
        }
        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            expedientes ex = new expedientes();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            ex.IDExpediente = txtidexpediente.Text;
            ex.IDDoctor = txtiddoctor.Text;
            ex.IDPaciente = txtidpaciente.Text;
            ex.FreqCardiaca = txtfreqcardiaca.Text;
            ex.FreqRespiratoria = txtfreqrespiratoria.Text;
            ex.Temperatura = txttemperatura.Text;
            ex.PesoActual = txtpesoactual.Text;
            ex.Altura = txtaltura.Text;
            ex.Sintomas = txtsintomas.Text;
            ex.Diagnostico = txtdiagnostico.Text;
            ex.Indicaciones = txtindicaciones.Text;


            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (ex.Actualizar())
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
                    if (ex.Guardar())
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
        private void EdicionExpediente_Load(object sender, EventArgs e)
        {
            this.txtidexpediente.Text = this._IDExpediente;
            this.txtiddoctor.Text = this._IDDoctor;
            this.txtidpaciente.Text = this._IDPaciente;
            this.txtfreqcardiaca.Text = this._FreqCardiaca;
            this.txtfreqrespiratoria.Text = this._FreqRespiratoria;
            this.txttemperatura.Text = this._Temperatura;
            this.txtpesoactual.Text = this._PesoActual;
            this.txtaltura.Text = this._Altura;
            this.txtsintomas.Text = this._Sintomas;
            this.txtdiagnostico.Text = this._Diagnostico;
            this.txtindicaciones.Text = this._Indicaciones;

            if (!this.Modificando) {
                {
                    int Num = Convert.ToInt32(Cache.Expedientes_MAX_ID()) + 1;
                    this.txtidexpediente.Text = Num.ToString();
                }
            
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

        private void txtpaciente_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Pacientes_.GestionPacientes frm = new Pacientes_.GestionPacientes();
            frm.ShowDialog();
            if (frm.Seleccionado) {
                txtidpaciente.Text = frm.IDPacienteSeleccionado;
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
