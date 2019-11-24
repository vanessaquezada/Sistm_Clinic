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

namespace ModGestionBasica.Expedientes_
{
    public partial class GestionExpedientes : Form
    {
        BindingSource _expediente = new BindingSource();

        String _IDExpedienteSelecionado;
        String _ExpedienteSeleccionado;
        Boolean _Seleccionado = false;

        public Boolean Seleccionado
        {
            get { return _Seleccionado; }
            set { _Seleccionado = value; }
        }

        public String ExpedienteSeleccionado
        {
            get { return _ExpedienteSeleccionado; }
            set { _ExpedienteSeleccionado = value; }
        }

        public String IDExpedienteSelecionado
        {
            get { return _IDExpedienteSelecionado; }
            set { _IDExpedienteSelecionado = value; }
        }

        private void CargarExpediente()
        {
            try
            {
                _expediente.DataSource = CacheManager.Cache.TODOS_LOS_EXPEDIENTES();
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
                _expediente.RemoveFilter();
            }
            else
            {
                _expediente.Filter = "IDExpediente LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgexpediente.AutoGenerateColumns = false;
            dtgexpediente.DataSource = _expediente;
            lblNumeroFilas.Text = dtgexpediente.Rows.Count.ToString() + " Registros Encontrados";
        }
        public GestionExpedientes()
        {
            InitializeComponent();
        }

        private void GestionExpedientes_Load(object sender, EventArgs e)
        {
            CargarExpediente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionExpediente frm = new EdicionExpediente();
            frm.ShowDialog();
            CargarExpediente();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionExpediente frm = new EdicionExpediente(true);
            frm._IDExpediente = dtgexpediente.CurrentRow.Cells["IDExpediente"].Value.ToString();
            frm._IDDoctor = dtgexpediente.CurrentRow.Cells["IDDoctor"].Value.ToString();
            frm._IDPaciente = dtgexpediente.CurrentRow.Cells["IDPaciente"].Value.ToString();
            frm._FreqCardiaca = dtgexpediente.CurrentRow.Cells["FreqCardiaca"].Value.ToString();
            frm._FreqRespiratoria = dtgexpediente.CurrentRow.Cells["FreqRespiratoria"].Value.ToString();
            frm._Temperatura = dtgexpediente.CurrentRow.Cells["Temperatura"].Value.ToString();
            frm._PesoActual = dtgexpediente.CurrentRow.Cells["PesoActual"].Value.ToString();
            frm._Altura = dtgexpediente.CurrentRow.Cells["Altura"].Value.ToString();
            frm._Sintomas = dtgexpediente.CurrentRow.Cells["Sintomas"].Value.ToString();
            frm._Diagnostico = dtgexpediente.CurrentRow.Cells["Diagnostico"].Value.ToString();
            frm._Indicaciones = dtgexpediente.CurrentRow.Cells["Indicaciones"].Value.ToString();
            frm.ShowDialog();
            CargarExpediente();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgexpediente.CurrentRow.Index;
                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    expedientes ex = new expedientes();
                    ex.IDExpediente = this.dtgexpediente.Rows[Index].Cells["IDExpediente"].Value.ToString();

                    if (ex.Eliminar())
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
            CargarExpediente();
        }

        private void dtgexpediente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDExpedienteSelecionado = dtgexpediente.CurrentRow.Cells["IDExpediente"].Value.ToString();
                _ExpedienteSeleccionado = dtgexpediente.CurrentRow.Cells["IDDoctor"].Value.ToString() + " " + dtgexpediente.CurrentRow.Cells["IDPaciente"].Value.ToString();
                Seleccionado = true;
                Close();
            }
            catch { 
            
            }
        }

    }
}
