using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModGestionBasica.GUI
{
    public partial class expedientes : Form
    {
        //private string ID;
        public expedientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ModGestionBasica.REP.CRExpedientes cr = new ModGestionBasica.REP.CRExpedientes();
            cr.SetDataSource(CacheManager.Cache.REP_EXPEDIENTES(txtIDPaciente.Text));
                crystalReportViewer1.ReportSource=cr;
        }

        private void expedientes_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Expedientes_.GestionExpedientes frm = new Expedientes_.GestionExpedientes();
            frm.ShowDialog();

            if (frm.Seleccionado) {

                txtIDPaciente.Text = frm.IDExpedienteSelecionado;
            }
            
        }
    }
}
