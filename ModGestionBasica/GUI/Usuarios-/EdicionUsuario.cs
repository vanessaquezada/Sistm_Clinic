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

namespace ModGestionBasica.Usuarios_
{
    public partial class EdicionUsuario : Form
    {

        private bool Modificando = false;
        public string _IDUsuario;
        public string _IDEmpleado;
        public string _IDGrupo;
        public string _Usuario;
        public string _Credencial;
        public string _Conectado;

        public EdicionUsuario(bool Modo = false) // 0: Insertar,     1: Actualizar
        {
            this.Modificando = Modo;
            InitializeComponent();
        }

        private void Procesar()
        {
            //PRIMER PASO, CREACION DE OBJETO
            usuarios em = new usuarios();
            // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
            em.IDUsuario = txtidusuario.Text;
            em.IDEmpleado = txtidempleado.Text;
            em.IDGrupo = txtidgrupo.Text;
            em.Usuario = txtusuario.Text;
            em.Credencial = txtcredencial.Text;
            em.Conectado = txtconectado.Text;
            


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
        
        public EdicionUsuario()
        {
            InitializeComponent();
        }

        private void EdicionUsuario_Load(object sender, EventArgs e)
        {
            this.txtidusuario.Text = this._IDUsuario;
            this.txtidempleado.Text = this._IDEmpleado;
            this.txtidgrupo.Text = this._IDGrupo;
            this.txtusuario.Text = this._Usuario;
            this.txtcredencial.Text = this._Credencial;
            this.txtconectado.Text = this._Conectado;
            if (!this.Modificando) {

                int Num = Convert.ToInt32(Cache.Usuarios_MAX_ID()) + 1;
                this.txtidusuario.Text = Num.ToString();
            }
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Empleadosss.GestionEMpleados frm = new Empleadosss.GestionEMpleados(this);
            frm.ShowDialog();
            if (frm.Seleccionado)
            {
                txtidempleado.Text = frm.IDEmpleadoSeleccionado;
            }
        }

        private void btngrupo_Click(object sender, EventArgs e)
        {
            ModGestionBasica.GUI.GestionGrupos frm = new GUI.GestionGrupos(this);
            frm.ShowDialog(this);
            if (frm.Seleccionado) {
                txtidgrupo.Text = frm.IDGrupoSeleccionado;
            
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
