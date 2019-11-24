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

namespace ModGestionBasica.Doctores
{
    public partial class GestionDoctores : Form
    {


        BindingSource _doctor = new BindingSource();
      
        String _IDDoctorSelecionado;
        String _DoctorSeleccionado;
        Boolean _Selecionado = false;

        public Boolean Selecionado
        {
            get { return _Selecionado; }
            set { _Selecionado = value; }
        }

        public String DoctorSeleccionado
        {
            get { return _DoctorSeleccionado; }
            set { _DoctorSeleccionado = value; }
        }

        public String IDDoctorSelecionado
        {
            get { return _IDDoctorSelecionado; }
            set { _IDDoctorSelecionado = value; }
        }
        private void CargarDoctores()
        {
            try
            {
                _doctor.DataSource = CacheManager.Cache.TODOS_LOS_DOCTORES();
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
                _doctor.RemoveFilter();
            }
            else
            {
               _doctor.Filter = "Turno LIKE '%" + txtfiltro.Text + "%'";
            }
            dtgdoctor.AutoGenerateColumns = false;
            dtgdoctor.DataSource = _doctor;
            lblNumeroFilas.Text = dtgdoctor.Rows.Count.ToString() + " Registros Encontrados";
        }
        
        public GestionDoctores()
        {
            InitializeComponent();
        }

        private void GestionDoctores_Load(object sender, EventArgs e)
        {
            CargarDoctores();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionDoctor frm = new EdicionDoctor();
            frm.ShowDialog();
            CargarDoctores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionDoctor frm = new EdicionDoctor(true);
            frm._IDDoctor = dtgdoctor.CurrentRow.Cells["IDDoctor"].Value.ToString();
            frm._IDEmpleado = dtgdoctor.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            frm._IDEspecialiad = dtgdoctor.CurrentRow.Cells["IDEspecialidad"].Value.ToString();
            frm._Turno = dtgdoctor.CurrentRow.Cells["Turno"].Value.ToString();
            frm.ShowDialog();
            CargarDoctores();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        try
            {
                int Index = this.dtgdoctor.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    Doctoress Modelo = new Doctoress();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDDoctor = this.dtgdoctor.Rows[Index].Cells["IDDoctor"].Value.ToString();

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

            CargarDoctores();
        }

        private void txtfiltro_Click(object sender, EventArgs e)
        {

        }

        private void dtgdoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDDoctorSelecionado = dtgdoctor.CurrentRow.Cells["IDDoctor"].Value.ToString();
                _DoctorSeleccionado = dtgdoctor.CurrentRow.Cells["IDEmpleado"].Value.ToString() + " " + dtgdoctor.CurrentRow.Cells["IDEspecialidad"].Value.ToString();
                Selecionado = true;
                Close();
            }
            catch { 
            
            }
        }

    }
}
