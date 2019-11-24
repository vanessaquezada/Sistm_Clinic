using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModGestionBasica.expedientes_recetas_
{
    public partial class GestionExpediente_Recetas : Form
    {

        BindingSource _exR = new BindingSource();

        private void CargarExpedientes_recetas()
        {
            try
            {
                _exR.DataSource = CacheManager.Cache.TODOS_LOS_EXPEDIENTES_RECETAS();
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
                _exR.RemoveFilter();
            }
            else
            {
                _exR.Filter = "ID LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtg_recetas_expedientes.AutoGenerateColumns = false;
            dtg_recetas_expedientes.DataSource = _exR;
            lblNumeroFilas.Text = dtg_recetas_expedientes.Rows.Count.ToString() + " Registros Encontrados";
        }


        public GestionExpediente_Recetas()
        {
            InitializeComponent();
        }

        private void EdicionRecetas_Load(object sender, EventArgs e)
        {
            CargarExpedientes_recetas();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Edicionexpediente_recetas frm = new Edicionexpediente_recetas();
            frm.ShowDialog();
            CargarExpedientes_recetas();
        }

        private void txteditar_Click(object sender, EventArgs e)
        {
            Edicionexpediente_recetas frm = new Edicionexpediente_recetas();
            frm._ID = dtg_recetas_expedientes.CurrentRow.Cells["ID"].Value.ToString();
            frm._IDExpediente = dtg_recetas_expedientes.CurrentRow.Cells["IDExpediente"].Value.ToString();
            frm._IDReceta = dtg_recetas_expedientes.CurrentRow.Cells["IDReceta"].Value.ToString();
            frm.ShowDialog();
            CargarExpedientes_recetas();
        }
    }
}
