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
namespace ModGestionBasica.Permisos_
{
    public partial class GestionPermisos : Form
    {
        BindingSource _permisos = new BindingSource();

        private void CargarPermisos()
        {
            try
            {
                _permisos.DataSource = CacheManager.Cache.TODOS_LOS_PERMISOS();
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
                _permisos.RemoveFilter();
            }
            else
            {
                _permisos.Filter = "IDGrupo LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgpermisos.AutoGenerateColumns = false;
            dtgpermisos.DataSource = _permisos;
            lblNumeroFilas.Text = dtgpermisos.Rows.Count.ToString() + " Registros Encontrados";
        }
        
        
        public GestionPermisos()
        {
            InitializeComponent();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionPermisos frm = new EdicionPermisos();
            frm.ShowDialog();
            CargarPermisos();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionPermisos frm = new EdicionPermisos(true);
            frm._IDPermiso = dtgpermisos.CurrentRow.Cells["IDPermiso"].Value.ToString();
            frm._IDGrupo = dtgpermisos.CurrentRow.Cells["IDGrupo"].Value.ToString();
            frm._IDOpcion = dtgpermisos.CurrentRow.Cells["IDOpcion"].Value.ToString();
            frm.ShowDialog();
            CargarPermisos();
        }

        private void txteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgpermisos.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                   permisos Modelo = new permisos();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDPermiso = this.dtgpermisos.Rows[Index].Cells["IDPermiso"].Value.ToString();

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
            catch(Exception exc)
            {
                MessageBox.Show("Registro Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CargarPermisos();
        
        }

        private void GestionPermisos_Load(object sender, EventArgs e)
        {
            CargarPermisos();
        }
    }
}
