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

namespace ModGestionBasica.GUI
{
    public partial class EdicionGrupo : Form
    {
        private bool Modificando = false;
        public string _IDGrupo;
        public string _Grupo;

        public EdicionGrupo(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        { 
            //PRIMER PASO, CREACION DE OBJETO
            Grupos Modelo = new Grupos();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            Modelo.IDGrupo = txtIDgrupo.Text;
            Modelo.Grupo = txtgrupo.Text;
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();        
        }


        private void EdicionGrupo_Load(object sender, EventArgs e)
        {
            this.txtIDgrupo.Text = this._IDGrupo;
            this.txtgrupo.Text = this._Grupo;
            

            if(!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.GRUPO_MAX_ID()) + 1;
                this.txtIDgrupo.Text = Num.ToString();
            }  
        }

        private void txtIDgrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrupo_KeyPress(object sender, KeyPressEventArgs e)
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
