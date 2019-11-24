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
namespace ModGestionBasica.Medecinas
{
    public partial class EdicionMedecina : Form
    {
        private bool Modificando = false;
        public string _IDMedicina;
        public string _Medicamento;
        public string _Concentrado;
        public string _Forma;
        public string _Via;
        public string _Estado;
        
        public EdicionMedecina(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }
        private void Procesar()
        { 
            //PRIMER PASO, CREACION DE OBJETO
            Medicina Me = new Medicina();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            Me.IDMedicina = txtidmedicina.Text;
            Me.Medicamento = txtmedicamento.Text;
            Me.Concentrado = txtconcentrado.Text;
            Me.Forma=txtforma.Text;
            Me.Via = txtvia.Text;
            Me.Estado = txtestado.Text;
            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (Me.Actualizar())
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
                    if (Me.Guardar())
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


           
        public EdicionMedecina()
        {
            InitializeComponent();
        }

        private void EdicionMedecina_Load(object sender, EventArgs e)
        {
            this.txtidmedicina.Text = this._IDMedicina;
            this.txtmedicamento.Text = this._Medicamento;
            this.txtconcentrado.Text = this._Concentrado;
            this.txtforma.Text = this._Forma;
            this.txtvia.Text = this._Via;
            this.txtestado.Text = this._Estado;

            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.Medecina_MAX_ID()) + 1;
                this.txtidmedicina.Text = Num.ToString();
            }
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void txtmedicamento_KeyPress(object sender, KeyPressEventArgs e)
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
