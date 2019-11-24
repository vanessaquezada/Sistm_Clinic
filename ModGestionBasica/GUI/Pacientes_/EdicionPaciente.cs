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

namespace ModGestionBasica.Pacientes_
{
    public partial class EdicionPaciente : Form
    {

        private bool Modificando = false;
        public string _IDPaciente;
        public string _Nombres;
        public string _Apellidos;
        public string _Sexo;
        public string _FechaNac;
        public string _EstadoCivil;
        public string _DUI;
        public string _NIT;
        public string _ISSS;
        public string _Domicilio;
        public string _Telefono;
        public string _Estado;

        public EdicionPaciente(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            Pacientes pa = new Pacientes();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            pa.IDPaciente = txtidpaciente.Text;
            pa.Nombres = txtnombres.Text;
            pa.Apellidos = txtapellidos.Text;
            pa.Sexo = txtsexo.Text;
            //CONVERSION DE LA FECHA
            pa.FechaNac = Convert.ToDateTime(txtfechanac.Value).ToString("yyyy-MM-dd hh:mm:ss");
            pa.EstadoCivil = txtestadocivil.Text;
            pa.DUI = txtdui.Text;
            pa.NIT = txtnit.Text;
            pa.ISSS = txtiss.Text;
            pa.Domicilio = txtdomicilio.Text;
            pa.Telefono = txttelefono.Text;
            pa.Estado = txtestado.Text;
            


            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (pa.Actualizar())
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
                    if (pa.Guardar())
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
        public EdicionPaciente()
        {
            InitializeComponent();
        }

        private void EdicionPaciente_Load(object sender, EventArgs e)
        {
            this.txtidpaciente.Text = this._IDPaciente;
            this.txtnombres.Text = this._Nombres;
            this.txtapellidos.Text = this._Apellidos;
            this.txtsexo.Text = this._Sexo;
            this.txtfechanac.Text = this._FechaNac;
            this.txtestadocivil.Text = this._EstadoCivil;
            this.txtdui.Text = this._DUI;
            this.txtnit.Text = this._NIT;
            this.txtiss.Text = this._ISSS;
            this.txtdomicilio.Text = this._Domicilio;
            this.txttelefono.Text = this._Telefono;
            this.txtestado.Text = this._Estado;
            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.Pacientes_MAX_ID()) + 1;
                this.txtidpaciente.Text= Num.ToString();
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

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
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
