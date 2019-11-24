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
using CacheManager;

namespace ModGestionBasica.Usuarios_
{
    public partial class GestionUsuarios : Form
    {

        BindingSource _usuario = new BindingSource();

        private void CargarUsuarios()
        {
            try
            {
                _usuario.DataSource = CacheManager.Cache.TODOS_LOS_USUARIOS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            if (txtfiltrar.TextLength == 0)
            {
                _usuario.RemoveFilter();
            }
            else
            {
                _usuario.Filter = "Usuario LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgusuarios.AutoGenerateColumns = false;
            dtgusuarios.DataSource = _usuario;
            lblNumeroFilas.Text = dtgusuarios.Rows.Count.ToString() + " Registros Encontrados";
        }
        
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionUsuario frm = new EdicionUsuario();
            frm.ShowDialog();
            CargarUsuarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionUsuario frm = new EdicionUsuario(true);
            frm._IDUsuario = dtgusuarios.CurrentRow.Cells["IDUsuario"].Value.ToString();
            frm._IDEmpleado = dtgusuarios.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            frm._IDGrupo = dtgusuarios.CurrentRow.Cells["IDGrupo"].Value.ToString();
            frm._Usuario = dtgusuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            frm._Credencial = dtgusuarios.CurrentRow.Cells["Credencial"].Value.ToString();
            frm._Conectado = dtgusuarios.CurrentRow.Cells["Conectado"].Value.ToString();
            frm.ShowDialog();
            CargarUsuarios();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgusuarios.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    usuarios Modelo = new usuarios();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDUsuario = this.dtgusuarios.Rows[Index].Cells["IDUsuario"].Value.ToString();

                    if (Modelo.Eliminar())
                    {
                        MessageBox.Show("Registro Eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro no fue Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Registro Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CargarUsuarios();

        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }     
            
        }
    }

