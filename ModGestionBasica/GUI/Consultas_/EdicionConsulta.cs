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
namespace ModGestionBasica.Consultas_
{
    public partial class EdicionConsulta : Form
    {


        private bool Modificando = false;
        public string _IDConsulta;
        public string _Tipo;
        public string _Detalles;
        public string _Estado;
        public EdicionConsulta(bool Modo = false)
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            Consultas con = new Consultas();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            con.IDConsulta = txtidconsulta.Text;
            con.Tipo = txttipo.Text;
            con.Detalles = txtdetalle.Text;
            con.Estado = txtestado.Text;

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

       
        private void EdicionConsulta_Load(object sender, EventArgs e)
        {
            this.txtidconsulta.Text = this._IDConsulta;
            this.txttipo.Text = this._Tipo;
            this.txtdetalle.Text = this._Detalles;
            this.txtestado.Text = this._Estado;

            if (!this.Modificando) {
                int Num = Convert.ToInt32(Cache.Consultas_MAX_ID()) + 1;
                this.txtidconsulta.Text = Num.ToString();
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

        private void txtdetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space)) {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled= true;
                return;
            }
        }
    }
}
