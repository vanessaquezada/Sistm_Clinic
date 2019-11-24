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
namespace ModGestionBasica.Consultas_
{
    public partial class GestionConsultas : Form
    {

        BindingSource _con = new BindingSource();
        String _IDConsultaSelecionada;
        String _ConsultaSelecionada;
        Boolean _Seleccionada = false;

        public Boolean Seleccionada
        {
            get { return _Seleccionada; }
            set { _Seleccionada = value; }
        }

       

        public String ConsultaSelecionada
        {
            get { return _ConsultaSelecionada; }
            set { _ConsultaSelecionada = value; }
        }

        public String IDConsultaSelecionada
        {
            get { return _IDConsultaSelecionada; }
            set { _IDConsultaSelecionada = value; }
        }
        private void CargarConsultas()
        {
            try
            {
                _con.DataSource = CacheManager.Cache.TODOS_LAS_Consultas();
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
                _con.RemoveFilter();
            }
            else
            {
                _con.Filter = "Tipo LIKE '%" + filtro.Text + "%'";
            }
            dtgconsulta.AutoGenerateColumns = false;
            dtgconsulta.DataSource = _con;
            lblNumeroFilas.Text = dtgconsulta.Rows.Count.ToString() + " Registros Encontrados";
        }

        public GestionConsultas()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GestionConsultas_Load(object sender, EventArgs e)
        {
            CargarConsultas();
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionConsulta frm = new EdicionConsulta();
            frm.ShowDialog();
            CargarConsultas();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionConsulta frm = new EdicionConsulta(true);
            frm._IDConsulta = dtgconsulta.CurrentRow.Cells["IDConsulta"].Value.ToString();
            frm._Tipo = dtgconsulta.CurrentRow.Cells["Tipo"].Value.ToString();
            frm._Detalles = dtgconsulta.CurrentRow.Cells["Detalles"].Value.ToString();
            frm._Estado = dtgconsulta.CurrentRow.Cells["Estado"].Value.ToString();
            frm.ShowDialog();
            CargarConsultas();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                int Index = this.dtgconsulta.CurrentRow.Index;
                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    Consultas con = new Consultas();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    con.IDConsulta = this.dtgconsulta.Rows[Index].Cells["IDConsulta"].Value.ToString();

                    if (con.Eliminar())
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

            CargarConsultas();    
        }

        private void filtro_Click(object sender, EventArgs e)
        {

        }

        private void dtgconsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _IDConsultaSelecionada = dtgconsulta.CurrentRow.Cells["IDConsulta"].Value.ToString();
                _ConsultaSelecionada = dtgconsulta.CurrentRow.Cells["Tipo"].Value.ToString() + " " + dtgconsulta.CurrentRow.Cells["Detalles"].Value.ToString();
                Seleccionada = true;
                Close();

            }
            catch { }
        }

    }
}
