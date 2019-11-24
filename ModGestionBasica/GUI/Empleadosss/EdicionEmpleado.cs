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
namespace ModGestionBasica.Empleadosss
{
    public partial class EdicionEmpleado : Form
    {
        private bool Modificando = false;
        public string _IDempleado;
        public string _Nombres;
        public string _Apellidos;
        public string _Sexo;
        public string _DUI;
        public string _NIT;
        public string _ISSS;
        public string _NUP;
        public string _Telefono;
        public string _Domicilio;
        public string _Departamento;
        public string _Municipio;
        public string _Estado;
        public string _FechaCreacion;

        public EdicionEmpleado(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            Empleado em = new Empleado();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            em.IDEmpleado = txtID.Text;
            em.Nombres = txtnombre.Text;
            em.Apellidos = txtapellido.Text;
            em.Sexo = txtsexo.Text;
            em.DUI = txtdui.Text;
            em.NIT = txtnit.Text;
            em.ISSS = txtisss.Text;
            em.NUP = txtnup.Text;
            em.Telefono = txttelefono.Text;
            em.Domicilio = txtdomicilio.Text;
            em.Departamento = txtdepartamento.Text;
            em.Municipio = txtmunicipio.Text;
            em.Estado = txtestado.Text;


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
        public EdicionEmpleado()
        {
            InitializeComponent();
        }

        private void EdicionEmpleado_Load(object sender, EventArgs e)
        {
            this.txtID.Text = this._IDempleado;
            this.txtnombre.Text = this._Nombres;
            this.txtapellido.Text = this._Apellidos;
            this.txtsexo.Text = this._Sexo;
            this.txtdui.Text = this._DUI;
            this.txtnit.Text = this._NIT;
            this.txtisss.Text = this._ISSS;
            this.txtnup.Text = this._NUP;
            this.txttelefono.Text = this._Telefono;
            this.txtdomicilio.Text = this._Domicilio;
            this.txtdepartamento.Text = this._Departamento;
            this.txtmunicipio.Text = this._Municipio;
            this.txtestado.Text = this._Estado;

            if (!this.Modificando)
            {
                int Num = Convert.ToInt32(Cache.GRUPO_MAX_IDEM()) + 1;
                this.txtID.Text = Num.ToString();
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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
