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


namespace ModGestionBasica.Responsable_pacientes
{
    public partial class EdicionResponsable : Form
    {
        private bool Modificando = false;
        public string _IDResponsable;
        public string _Nombres;
        public string _Apellidos;
        public string _Parentesco;

        public EdicionResponsable(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            responsable_paciente res = new responsable_paciente();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            res.IDResponsable = txtIDResponsable.Text;
            res.Nombres = txtnombres.Text;
            res.Apellidos = txtapellidos.Text;
            res.Parentesco = txtparentesco.Text;
           
            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (res.Actualizar())
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
                    if (res.Guardar())
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
       
        public EdicionResponsable()
        {
            InitializeComponent();
        }

        private void EdicionResponsable_Load(object sender, EventArgs e)
        {
            this.txtIDResponsable.Text = this._IDResponsable;
            this.txtnombres.Text = this._Nombres;
            this.txtapellidos.Text = this._Apellidos;
            this.txtparentesco.Text = this._Parentesco;

            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.Responsable_MAX_IDRes()) + 1;
                this.txtIDResponsable.Text = Num.ToString();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Procesar();
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
