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
namespace ModGestionBasica.Responsable_pacientes
{
    public partial class GestionResponsable : Form
    {
        BindingSource  _responsable = new BindingSource();

        private void CargaResponsable()
        {
            try
            {
                _responsable.DataSource = CacheManager.Cache.Todos_los_responsables();
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
                _responsable.RemoveFilter();
            }
            else
            {
                _responsable.Filter = "Nombres LIKE '%" + filtro.Text + "%'";
            }
            dtgresponsable.AutoGenerateColumns = false;
            dtgresponsable.DataSource = _responsable;
            lblNumeroFilas.Text = dtgresponsable.Rows.Count.ToString() + " Registros Encontrados";
        }
        public GestionResponsable()
        {
            InitializeComponent();
        }

        private void GestionResponsable_Load(object sender, EventArgs e)
        {
            CargaResponsable();
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            EdicionResponsable frm = new EdicionResponsable();
            frm.ShowDialog();
            CargaResponsable();
        }

        private void btnaditar_Click(object sender, EventArgs e)
        {
            EdicionResponsable frm = new EdicionResponsable(true);
            frm._IDResponsable = dtgresponsable.CurrentRow.Cells["IDResponsable"].Value.ToString();
            frm._Nombres = dtgresponsable.CurrentRow.Cells["Nombres"].Value.ToString();
            frm._Apellidos = dtgresponsable.CurrentRow.Cells["Apellidos"].Value.ToString();
            frm._Parentesco = dtgresponsable.CurrentRow.Cells["Parentesco"].Value.ToString();
            frm.ShowDialog();
            CargaResponsable();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgresponsable.CurrentRow.Index;
                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resp == DialogResult.Yes)
                {
                    responsable_paciente _res = new responsable_paciente();
                    _res.IDResponsable = this.dtgresponsable.Rows[Index].Cells["IDResponsable"].Value.ToString();

                    if (_res.Eliminar())
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
            CargaResponsable();
        }
    }
}
