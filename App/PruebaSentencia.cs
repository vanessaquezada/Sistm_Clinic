using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
namespace App
{
    public partial class PruebaSentencia : Form
    {
        public PruebaSentencia()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            OperacionBD objOperacion = new OperacionBD();
            if(objOperacion.Insertar(txbSentencia.Text )>0)
            {
                MessageBox.Show("Insertardo");
            }
            else
            {
                MessageBox.Show("Falló");
            }
        }
    }
}
