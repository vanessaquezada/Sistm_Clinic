using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModGestionBasica.REP
{
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CREmpleados cr = new CREmpleados();
            cr.SetDataSource(CacheManager.Cache.REP_EMPLEADOS(Convert.ToDateTime(FechaInicio.Value).ToString("yyyy-MM-dd"), Convert.ToDateTime(FechaFin.Value).ToString("yyyy-MM-dd")));
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
