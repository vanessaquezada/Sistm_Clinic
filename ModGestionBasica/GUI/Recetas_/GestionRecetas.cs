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

namespace ModGestionBasica.Recetas_
{
    public partial class GestionRecetas : Form
    {

        BindingSource _recetas = new BindingSource();

        String _IDRecetaSeleccionada;
        String _RecetaSeleccionada;
        Boolean _Seleccionado = false;

        public Boolean Seleccionado
        {
            get { return _Seleccionado; }
            set { _Seleccionado = value; }
        }

        public String RecetaSeleccionada
        {
            get { return _RecetaSeleccionada; }
            set { _RecetaSeleccionada = value; }
        }

        public String IDRecetaSeleccionada
        {
            get { return _IDRecetaSeleccionada; }
            set { _IDRecetaSeleccionada = value; }
        }

        private void CargarRecetas()
        {
            try
            {
                _recetas.DataSource = CacheManager.Cache.TODAS_LAS_RECETAS();
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
                _recetas.RemoveFilter();
            }
            else
            {
                _recetas.Filter = "IDReceta LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgrecetas.AutoGenerateColumns = false;
            dtgrecetas.DataSource = _recetas;
            lblNumeroFilas.Text = dtgrecetas.Rows.Count.ToString() + " Registros Encontrados";
        }
        public GestionRecetas()
        {
            InitializeComponent();
        }

        private void GestionRecetas_Load(object sender, EventArgs e)
        {
            CargarRecetas();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionRecetas frm = new EdicionRecetas();
            frm.ShowDialog();
            CargarRecetas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionRecetas frm = new EdicionRecetas();
            frm._IDReceta = dtgrecetas.CurrentRow.Cells["IDReceta"].Value.ToString();
            frm._IDDoctor = dtgrecetas.CurrentRow.Cells["IDDoctor"].Value.ToString();
            frm._IDPaciente = dtgrecetas.CurrentRow.Cells["IDPaciente"].Value.ToString();
            frm._IDMedicina = dtgrecetas.CurrentRow.Cells["IDMedicina"].Value.ToString();
            frm._Dosis = dtgrecetas.CurrentRow.Cells["Dosis"].Value.ToString();
            frm._Cantidad = dtgrecetas.CurrentRow.Cells["Cantidad"].Value.ToString();
            frm.ShowDialog();
            CargarRecetas();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgrecetas.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    recetas_medicas Modelo = new recetas_medicas();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDReceta = this.dtgrecetas.Rows[Index].Cells["IDReceta"].Value.ToString();

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

            CargarRecetas();
        }

        private void dtgrecetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDRecetaSeleccionada = dtgrecetas.CurrentRow.Cells["IDReceta"].Value.ToString();

                _RecetaSeleccionada = dtgrecetas.CurrentRow.Cells["IDDoctor"].Value.ToString() + " " + dtgrecetas.CurrentRow.Cells["IDPaciente"].Value.ToString();
                Seleccionado = true;
                Close();
            }
            catch { 
            
            }
        }

    }
}
