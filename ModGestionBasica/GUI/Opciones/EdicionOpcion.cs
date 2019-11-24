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
namespace ModGestionBasica.Opciones
{
    public partial class EdicionOpcion : Form
    {
        private bool Modificando = false;
        public string _IDOpcion;
        public string _Opcion;
        public string _Categoria;
        public string _FechaCreacion;
     

        public EdicionOpcion(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }
        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            Opcioness Modo = new Opcioness();
            Modo.IDOpcion = txtid.Text;
            Modo.Opcion = txtopcion.Text;
            Modo.Categoria = txtcategoria.Text;
            
            //TERCER PASO DETERMINAR EL TIPO DE OPERACION
            if (this.Modificando)
            {
                try
                {
                    //ACTUALIZANDO
                    if (Modo.Actualizar())
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
                    if (Modo.Guardar())
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


        public EdicionOpcion()
        {
            InitializeComponent();
        }

        private void EdicionOpcion_Load(object sender, EventArgs e)
        {
            this.txtid.Text = this._IDOpcion;
            this.txtopcion.Text = this._Opcion;
            this.txtcategoria.Text = this._Categoria;
            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.OPCIONES_MAX_ID()) + 1;
                this.txtid.Text = Num.ToString();
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

        private void txtopcion_KeyPress(object sender, KeyPressEventArgs e)
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
