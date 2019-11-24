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
namespace ModGestionBasica.Medecinas
{
    public partial class GestionMedecinas : Form
    {

        BindingSource _Medecina = new BindingSource();

        BindingSource _Especialidad = new BindingSource();
        String _IDEspecialidadselecionada;

        String _Especialidadseleccionada;

        Boolean _Seleccionado = false;

        public Boolean Seleccionado
        {
            get { return _Seleccionado; }
            set { _Seleccionado = value; }
        }
        public String Especialidadseleccionada
        {
            get { return _Especialidadseleccionada; }
            set { _Especialidadseleccionada = value; }
        }
        public String IDEspecialidadselecionada
        {
            get { return _IDEspecialidadselecionada; }
            set { _IDEspecialidadselecionada = value; }
        }

        private void CargarMedecina()
        {
            try
            {
                _Medecina.DataSource = CacheManager.Cache.Todos_las_Medecinas();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            if (txtfiltro.TextLength == 0)
            {
                _Medecina.RemoveFilter();
            }
            else
            {
                _Medecina.Filter = "Medicamento LIKE '%" + txtfiltro.Text + "%'";
            }
            dtgmedecina.AutoGenerateColumns = false;
            dtgmedecina.DataSource = _Medecina;
            lblNumeroFilas.Text = dtgmedecina.Rows.Count.ToString() + " Registros Encontrados";
        }

        public GestionMedecinas()
        {
            InitializeComponent();
        }

        private void GestionMedecinas_Load(object sender, EventArgs e)
        {
            CargarMedecina();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionMedecina frm = new EdicionMedecina();
            frm.ShowDialog();
            CargarMedecina();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionMedecina frm = new EdicionMedecina(true);
          frm._IDMedicina = dtgmedecina.CurrentRow.Cells["IDMedicina"].Value.ToString();
          frm._Medicamento = dtgmedecina.CurrentRow.Cells["Medicamento"].Value.ToString();
          frm._Concentrado = dtgmedecina.CurrentRow.Cells["Concentrado"].Value.ToString();
          frm._Forma = dtgmedecina.CurrentRow.Cells["Forma"].Value.ToString();
          frm._Via = dtgmedecina.CurrentRow.Cells["Via"].Value.ToString();
          frm._Estado = dtgmedecina.CurrentRow.Cells["Estado"].Value.ToString();
          frm.ShowDialog();
          CargarMedecina();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                int Index = this.dtgmedecina.CurrentRow.Index;
                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                     Medicina med = new Medicina();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    med.IDMedicina = this.dtgmedecina.Rows[Index].Cells["IDMedicina"].Value.ToString();

                    if (med.Eliminar())
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

            CargarMedecina();
        }

        private void dtgmedecina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgmedecina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDEspecialidadselecionada = dtgmedecina.CurrentRow.Cells["IDMedicina"].Value.ToString();
                _Especialidadseleccionada = dtgmedecina.CurrentRow.Cells["Medicamento"].Value.ToString() + " " + dtgmedecina.CurrentRow.Cells["Concentrado"].Value.ToString();
                Seleccionado = true;
                Close();
               
            }
            catch
            {

            }

        }


    }
}
