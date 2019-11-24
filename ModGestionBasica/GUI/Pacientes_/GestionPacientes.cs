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

namespace ModGestionBasica.Pacientes_
{
    public partial class GestionPacientes : Form
    {
        BindingSource _paciente = new BindingSource();

        String _IDPacienteSeleccionado;
        String _PacienteSelecionado;
        Boolean _Seleccionado = false;

        public Boolean Seleccionado
        {
            get { return _Seleccionado; }
            set { _Seleccionado = value; }
        }

        public String PacienteSelecionado
        {
            get { return _PacienteSelecionado; }
            set { _PacienteSelecionado = value; }
        }

        public String IDPacienteSeleccionado
        {
            get { return _IDPacienteSeleccionado; }
            set { _IDPacienteSeleccionado = value; }
        }
        private void CargarPacientes()
        {
            try
            {
                _paciente.DataSource = CacheManager.Cache.TODOS_LOS_PACIENTES();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            if (filtrar.TextLength == 0)
            {
                _paciente.RemoveFilter();
            }
            else
            {
                _paciente.Filter = "Nombres LIKE '%" + filtrar.Text + "%'";
            }
            dtgpaciente.AutoGenerateColumns = false;
            dtgpaciente.DataSource = _paciente;
            lblNumeroFila.Text = dtgpaciente.Rows.Count.ToString() + " Registros Encontrados";
        }
        public GestionPacientes()
        {
            InitializeComponent();
        }

        private void GestionPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionPaciente frm = new EdicionPaciente();
            frm.ShowDialog();
            CargarPacientes();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionPaciente frm = new EdicionPaciente(true);
            frm._IDPaciente = dtgpaciente.CurrentRow.Cells["IDPaciente"].Value.ToString();
            frm._Nombres = dtgpaciente.CurrentRow.Cells["Nombres"].Value.ToString();
            frm._Apellidos = dtgpaciente.CurrentRow.Cells["Apellidos"].Value.ToString();
            frm._Sexo = dtgpaciente.CurrentRow.Cells["Sexo"].Value.ToString();
            frm._FechaNac = dtgpaciente.CurrentRow.Cells["FechaNac"].Value.ToString();
            frm._EstadoCivil = dtgpaciente.CurrentRow.Cells["EstadoCivil"].Value.ToString();
            frm._DUI = dtgpaciente.CurrentRow.Cells["DUI"].Value.ToString();
            frm._NIT = dtgpaciente.CurrentRow.Cells["NIT"].Value.ToString();
            frm._ISSS = dtgpaciente.CurrentRow.Cells["ISSS"].Value.ToString();
            frm._Domicilio = dtgpaciente.CurrentRow.Cells["Domicilio"].Value.ToString();
            frm._Telefono = dtgpaciente.CurrentRow.Cells["Telefono"].Value.ToString();
            frm._Estado = dtgpaciente.CurrentRow.Cells["Estado"].Value.ToString();
            frm.ShowDialog();
            CargarPacientes();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgpaciente.CurrentRow.Index;
                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    Pacientes pa = new Pacientes();
                    pa.IDPaciente = this.dtgpaciente.Rows[Index].Cells["IDPaciente"].Value.ToString();

                    if (pa.Eliminar())
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
            CargarPacientes();
        }

        private void filtrar_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgpaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDPacienteSeleccionado = dtgpaciente.CurrentRow.Cells["IDPaciente"].Value.ToString();
                _PacienteSelecionado = dtgpaciente.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgpaciente.CurrentRow.Cells["Apellidos"].Value.ToString();
                Seleccionado = true;

                Close();
            }
            catch { 
            }

        }
    }
}
