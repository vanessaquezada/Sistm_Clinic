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

namespace ModGestionBasica.GUI
{
    public partial class GestionGrupos : Form
    {
        BindingSource _GRUPOS = new BindingSource();

        String _IDGrupoSeleccionado;
        String _GrupoSeleccionado;
        Boolean _Seleccionado = false;

        public Boolean Seleccionado
        {
            get { return _Seleccionado; }
            set { _Seleccionado = value; }
        }

        public String GrupoSeleccionado
        {
            get { return _GrupoSeleccionado; }
            set { _GrupoSeleccionado = value; }
        }

        public String IDGrupoSeleccionado
        {
            get { return _IDGrupoSeleccionado; }
            set { _IDGrupoSeleccionado = value; }
        }
        private void CargarGrupos()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager.Cache.TODO_LOS_GRUPOS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            if(txbFiltro.TextLength==0)
            {
                _GRUPOS.RemoveFilter();
            }
            else
            {
                _GRUPOS.Filter = "Grupo LIKE '%" + txbFiltro.Text + "%'";
            }
            dtgGrupos.AutoGenerateColumns = false;
            dtgGrupos.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgGrupos.Rows.Count.ToString() + " Registros Encontrados";
        }
        //
        Form _frm;
        public GestionGrupos(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void GestionGrupos_Load(object sender, EventArgs e)
        {
            CargarGrupos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionGrupo frm = new EdicionGrupo();
            frm.ShowDialog();
            CargarGrupos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionGrupo frm = new EdicionGrupo(true);
            frm._IDGrupo = dtgGrupos.CurrentRow.Cells["IDGrupo"].Value.ToString();
            frm._Grupo = dtgGrupos.CurrentRow.Cells["Grupo"].Value.ToString();
            frm.ShowDialog();
            CargarGrupos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgGrupos.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    Grupos Modelo = new Grupos();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDGrupo = this.dtgGrupos.Rows[Index].Cells["IDGrupo"].Value.ToString();

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

            CargarGrupos();
        }

        private void txbFiltro_Click(object sender, EventArgs e)
        {

        }

        private void dtgGrupos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            int id = Convert.ToInt32(dtgGrupos.Rows[dtgGrupos.CurrentRow.Index].Cells[0].Value);
            String idd = id.ToString();
            ModGestionBasica.Usuarios_.EdicionUsuario frm = (ModGestionBasica.Usuarios_.EdicionUsuario)_frm;
            frm.txtidgrupo.Text = idd;

            Close();
             * */
        }

        private void dtgGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDGrupoSeleccionado = dtgGrupos.CurrentRow.Cells["IDGrupo"].Value.ToString();
            _GrupoSeleccionado = dtgGrupos.CurrentRow.Cells["Grupo"].Value.ToString();
            Seleccionado = true;

            Close();
        }
    }
}
