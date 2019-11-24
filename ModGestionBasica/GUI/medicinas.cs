using ModGestionBasica.REP;
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
    public partial class medicinas : Form
    {
        public medicinas()
        {
            InitializeComponent();
        }

        private void medicinas_Load(object sender, EventArgs e)
        {
            CRMedicinas cr = new CRMedicinas();
            cr.SetDataSource(CacheManager.Cache.REP_MEDICINAS());
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
