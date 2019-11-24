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

namespace ModGestionBasica.Existencias_
{
    public partial class GestionExistencias : Form
    {
        BindingSource _existencia = new BindingSource();

        private void CargarExistencias()
        {
            try
            {
                _existencia.DataSource = CacheManager.Cache.Todas_LAS_Existencias();
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
                _existencia.RemoveFilter();
            }
            else
            {
                _existencia.Filter = "IDMedicina LIKE '%" + txtfiltrar.Text + "%'";
            }
            dtgexistencia.AutoGenerateColumns = false;
            dtgexistencia.DataSource = _existencia;
            lblNumeroFila.Text = dtgexistencia.Rows.Count.ToString() + " Registros Encontrados";
        }
        
        public GestionExistencias()
        {
            InitializeComponent();
        }

        private void GestionExistencias_Load(object sender, EventArgs e)
        {
            CargarExistencias();
        }

        private void brnagregar_Click(object sender, EventArgs e)
        {
            EdicionExistencia frm = new EdicionExistencia();
            frm.ShowDialog();
            CargarExistencias();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EdicionExistencia frm = new EdicionExistencia(true);
            frm._IDExistencia = dtgexistencia.CurrentRow.Cells["IDExistencia"].Value.ToString();
            frm._IDMedicina = dtgexistencia.CurrentRow.Cells["IDMedicina"].Value.ToString();
            frm._Unidad = dtgexistencia.CurrentRow.Cells["Unidad"].Value.ToString();
            frm._Cantidad = dtgexistencia.CurrentRow.Cells["Cantidad"].Value.ToString();
            frm.ShowDialog();
            CargarExistencias();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = this.dtgexistencia.CurrentRow.Index;

                DialogResult Resp = MessageBox.Show("¿Desea Eliminar el Registro?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(Resp == DialogResult.Yes)
                {
                    //PRIMER PASO, CREACION DE OBJETO
                    exitencias Modelo = new exitencias();
                    // SEGUNDO PASO SINCRONIZAR INTERFAZ GRAFICA CON EL OBJETO
                    Modelo.IDExistencia = this.dtgexistencia.Rows[Index].Cells["IDExistencia"].Value.ToString();

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
            catch(Exception exc)
            {
                MessageBox.Show("Registro Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CargarExistencias();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
        }
    }

