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
namespace ModGestionBasica.Empleadosss
{
    public partial class GestionEMpleados : Form
    {
        BindingSource _Empleado = new BindingSource();
        String _IDEmpleadoSeleccionado;
        String _EmpleadoSeleccionado;
        Boolean _Seleccionado = false;

        public Boolean Seleccionado
        {
            get { return _Seleccionado; }
            set { _Seleccionado = value; }
        }

        public String EmpleadoSeleccionado
        {
            get { return _EmpleadoSeleccionado; }
            set { _EmpleadoSeleccionado = value; }
        }

        public String IDEmpleadoSeleccionado
        {
            get { return _IDEmpleadoSeleccionado; }
            set { _IDEmpleadoSeleccionado = value; }
        }

        private void CargarEmpleados()
        {
            try
            {
                _Empleado.DataSource = CacheManager.Cache.Todos_los_Empleados();
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
                _Empleado.RemoveFilter();
            }
            else
            {
                _Empleado.Filter = "Nombres LIKE '%" + filtrar.Text + "%'";
            }
            dtgempleados.AutoGenerateColumns = false;
            dtgempleados.DataSource = _Empleado;
            lblNumeroFilas.Text = dtgempleados.Rows.Count.ToString() + " Registros Encontrados";
        }
        /****************************//////////////
        Form _frm ;
  
        public GestionEMpleados(Form frm)
        {
          
            _frm = frm;
            InitializeComponent();
        }
        /*********************************************/

        private void GestionEMpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionEmpleado frm = new EdicionEmpleado();
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionEmpleado frm = new EdicionEmpleado(true);
            frm._IDempleado = dtgempleados.CurrentRow.Cells["IDempleado"].Value.ToString();
            frm._Nombres = dtgempleados.CurrentRow.Cells["Nombres"].Value.ToString();
            frm._Apellidos = dtgempleados.CurrentRow.Cells["Apellidos"].Value.ToString();
            frm._Sexo = dtgempleados.CurrentRow.Cells["Sexo"].Value.ToString();
            frm._DUI = dtgempleados.CurrentRow.Cells["DUI"].Value.ToString();
            frm._NIT = dtgempleados.CurrentRow.Cells["NIT"].Value.ToString();
            frm._ISSS = dtgempleados.CurrentRow.Cells["ISSS"].Value.ToString();
            frm._NUP = dtgempleados.CurrentRow.Cells["NUP"].Value.ToString();
            frm._Telefono = dtgempleados.CurrentRow.Cells["Telefono"].Value.ToString();
            frm._Domicilio = dtgempleados.CurrentRow.Cells["Domicilio"].Value.ToString();
            frm._Departamento = dtgempleados.CurrentRow.Cells["Departamento"].Value.ToString();
            frm._Municipio = dtgempleados.CurrentRow.Cells["Municipio"].Value.ToString();
            frm._Estado = dtgempleados.CurrentRow.Cells["Estado"].Value.ToString();
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try {
                int Index = this.dtgempleados.CurrentRow.Index;
                 DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                 if (Resp == DialogResult.Yes) {
                     Empleado em = new Empleado();
                     em.IDEmpleado = this.dtgempleados.Rows[Index].Cells["IDEmpleado"].Value.ToString();

                     if (em.Eliminar())
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
            CargarEmpleados();
        }

        private void filtrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgempleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int id = Convert.ToInt32(dtgempleados.Rows[dtgempleados.CurrentRow.Index].Cells[0].Value);
            //String idd = id.ToString();
         
            //ModGestionBasica.Usuarios_.EdicionUsuario frm = (ModGestionBasica.Usuarios_.EdicionUsuario)_frm;
           
            //frm.txtidempleado.Text = idd;
            //Close();
             
           
            
           
        }

        private void dtgempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgempleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDEmpleadoSeleccionado = dtgempleados.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                _EmpleadoSeleccionado = dtgempleados.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgempleados.CurrentRow.Cells["Apellidos"].Value.ToString();
                Seleccionado = true;
                Close();
            }
            catch
            {

            }

        }
    }
}
