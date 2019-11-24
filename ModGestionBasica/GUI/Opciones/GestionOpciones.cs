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

namespace ModGestionBasica.Opciones
{
    public partial class GestionOpciones : Form
    {
        BindingSource _OPCION = new BindingSource();

        String _IDOpcionSeleccionado;
        String _OpcionSeleccinada;
        Boolean _Seleccionada = false;

        public Boolean Seleccionada
        {
            get { return _Seleccionada; }
            set { _Seleccionada = value; }
        }

        public String OpcionSeleccinada
        {
            get { return _OpcionSeleccinada; }
            set { _OpcionSeleccinada = value; }
        }

        public String IDOpcionSeleccionado
        {
            get { return _IDOpcionSeleccionado; }
            set { _IDOpcionSeleccionado = value; }
        }

        private void CargarOpcion()
        {
            try
            {
                _OPCION.DataSource = CacheManager.Cache.TODO_Las_Opciones();
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
                _OPCION.RemoveFilter();
            }
            else
            {
                _OPCION.Filter = "Opcion LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgopciones.AutoGenerateColumns = false;
            dtgopciones.DataSource = _OPCION;
            lblNumeroFilas.Text = dtgopciones.Rows.Count.ToString() + " Registros Encontrados";
        }


        public GestionOpciones()
        {
            InitializeComponent();
        }

        private void GestionOpciones_Load(object sender, EventArgs e)
        {
            CargarOpcion();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionOpcion frm = new EdicionOpcion();
            frm.ShowDialog();
            CargarOpcion();
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionOpcion frm = new EdicionOpcion(true);
            frm._IDOpcion = dtgopciones.CurrentRow.Cells["IDOpcion"].Value.ToString();
            frm._Opcion = dtgopciones.CurrentRow.Cells["Opcion"].Value.ToString();
            frm._Categoria = dtgopciones.CurrentRow.Cells["Categoria"].Value.ToString();
            frm.ShowDialog();
            CargarOpcion();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgopciones.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    Opcioness Modelo = new Opcioness();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDOpcion = this.dtgopciones.Rows[Index].Cells["IDOpcion"].Value.ToString();

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

            CargarOpcion();

        }

        private void dtgopciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDOpcionSeleccionado = dtgopciones.CurrentRow.Cells["IDOpcion"].Value.ToString();
                _OpcionSeleccinada = dtgopciones.CurrentRow.Cells["opcion"].Value.ToString() + " " + dtgopciones.CurrentRow.Cells["Categoria"].Value.ToString();
                Seleccionada = true;
                Close();
            }
            catch { 
            
            }
        }

        

    }
}
