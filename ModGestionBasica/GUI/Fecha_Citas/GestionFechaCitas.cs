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

namespace ModGestionBasica.Fecha_Citas
{
    public partial class GestionFechaCitas : Form
    {
        BindingSource _fecha = new BindingSource();

        private void CargarFechaCita()
        {
            try
            {
                _fecha.DataSource = CacheManager.Cache.TODAS_FECHAS_CITAS();
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
                _fecha.RemoveFilter();
            }
            else
            {
                _fecha.Filter = "IDCita LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgfichacitas.AutoGenerateColumns = false;
            dtgfichacitas.DataSource = _fecha;
            lblNumeroFilas.Text = dtgfichacitas.Rows.Count.ToString() + " Registros Encontrados";
        }
        public GestionFechaCitas()
        {
            InitializeComponent();
        }

        private void GestionFechaCitas_Load(object sender, EventArgs e)
        {
            CargarFechaCita();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionCitas frm = new EdicionCitas();
            frm.ShowDialog();
            CargarFechaCita();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionCitas frm = new EdicionCitas();
            frm._IDCita = dtgfichacitas.CurrentRow.Cells["IDCita"].Value.ToString();
            frm._IDPaciente = dtgfichacitas.CurrentRow.Cells["IDPaciente"].Value.ToString();
            frm._IDDoctor = dtgfichacitas.CurrentRow.Cells["IDDoctor"].Value.ToString();
            frm._IDConsulta = dtgfichacitas.CurrentRow.Cells["IDConsulta"].Value.ToString();
            frm._FechaPrixima = dtgfichacitas.CurrentRow.Cells["FechaProxima"].Value.ToString();
            frm.ShowDialog();
            CargarFechaCita();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                int Index = this.dtgfichacitas.CurrentRow.Index;
                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    Ficha_citas con = new Ficha_citas();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    con.IDCita = this.dtgfichacitas.Rows[Index].Cells["IDCita"].Value.ToString();

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
        }
    }
}
