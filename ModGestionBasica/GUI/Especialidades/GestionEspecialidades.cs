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

namespace ModGestionBasica.Especialidades
{
    public partial class GestionEspecialidades : Form
    {
        BindingSource _esp = new BindingSource();

        private void CargarEspecialidad()
        {
            try
            {
                _esp.DataSource = CacheManager.Cache.Todos_las_Especialidades();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            if (filtro.TextLength == 0)
            {
                _esp.RemoveFilter();
            }
            else
            {
                _esp.Filter = "especialidad LIKE '%" + filtro.Text + "%'";
            }
            dtgespecialidad.AutoGenerateColumns = false;
            dtgespecialidad.DataSource = _esp;
            lblNumeroFilas.Text = dtgespecialidad.Rows.Count.ToString() + " Registros Encontrados";
        }

        Form  _frm;
        public GestionEspecialidades( Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();

        }


        private void GestionEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidad();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionEspecialidades frm = new EdicionEspecialidades();
            frm.ShowDialog();
            CargarEspecialidad();
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionEspecialidades frm = new EdicionEspecialidades(true);
            frm._IDEspecialidad = dtgespecialidad.CurrentRow.Cells["IDEspecialidad"].Value.ToString();
            frm._Especialidad = dtgespecialidad.CurrentRow.Cells["especialidad"].Value.ToString();
            frm.ShowDialog();
            CargarEspecialidad();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            
            {

            int Index = this.dtgespecialidad.CurrentRow.Index;
            DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
                if(Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    Especialidad esp = new Especialidad();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    esp.IDEspecialidad = this.dtgespecialidad.Rows[Index].Cells["IDEspecialidad"].Value.ToString();

                    if (esp.Eliminar())
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

            CargarEspecialidad();
        }

        private void filtro_Click(object sender, EventArgs e)
        {

        }

        private void dtgespecialidad_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dtgespecialidad.Rows[dtgespecialidad.CurrentRow.Index].Cells[0].Value);
            String idd = id.ToString();

            ModGestionBasica.Doctores.EdicionDoctor frm = (ModGestionBasica.Doctores.EdicionDoctor)_frm;
            frm.txtidespecialidad.Text = idd;

            Close();
        }
       

    }
}
