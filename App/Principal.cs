using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Principal : Form
    {
        

        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        public Principal()
        {
            InitializeComponent();
        }
        

        private bool AccesoInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            new Thread(Habilitar_Permisos).Start();

            this.WindowState = FormWindowState.Maximized;
            lblUsuario.Text = _SESION.Usuario;
            lblGrupo.Text = _SESION.Grupo;
            lblEmpleado.Text = _SESION.Nombres + " " + _SESION.Apellidos;
            lblEstacion.Text = Environment.MachineName.ToString();
            lblHoraInicio.Text = DateTime.Now.ToShortTimeString();
            DataLayer.OperacionBD oOperacion = new DataLayer.OperacionBD();
            lblDireccionServer.Text = oOperacion.ObtenerIPServer();

            
            
        }

        private void Habilitar_Permisos()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(this.Habilitar_Permisos));
                return;
            }

            // Listar los botones de las Tablas los subprocesos ==> deshabilitándolas
            eMPLEADOSToolStripMenuItem.Enabled = false;
            gRUPOSToolStripMenuItem.Enabled = false;
            uSUARIOSToolStripMenuItem.Enabled = false;
            dOCTORESToolStripMenuItem.Enabled = false;
            eSPECIALIDADESToolStripMenuItem.Enabled = false;
            /*mEDICINAToolStripMenuItem.Enabled = false;*/
            /*iNVENTARIOMEDICINAToolStripMenuItem.Enabled = false;*/
            pACIENTEToolStripMenuItem.Enabled = false;
            cONSULTAToolStripMenuItem.Enabled = false;
            eXPEDIENTEToolStripMenuItem.Enabled = false;
            rECETAMEDICAToolStripMenuItem.Enabled = false;
            /*pROXIMACITAToolStripMenuItem.Enabled = false;*/
            eXPEDIENTERECETAToolStripMenuItem.Enabled = false;
            /*rESPONSABLEPACIENTEToolStripMenuItem.Enabled = false;*/
            rEPORTEPOREMPLEADOToolStripMenuItem.Enabled = false;
            rEPORTEPORRECETAToolStripMenuItem.Enabled = false;
            /*rEPORTEPOREXPPACIENTEToolStripMenuItem.Enabled = false;*/
            oPCIONESToolStripMenuItem.Enabled = false;
            pERMISOSToolStripMenuItem.Enabled = false;
            // Si tiene el Nombre del Valor, habilitarlas
            foreach (string Value in _SESION.Permisos)
            {
                if (Value.Equals("CRUD Empleados"))
                {
                    eMPLEADOSToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Grupos"))
                {
                    gRUPOSToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Usuarios"))
                {
                    uSUARIOSToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Doctores"))
                {
                    dOCTORESToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Especialidades"))
                {
                    eSPECIALIDADESToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Medicinas"))
                {
                    mEDICINAToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD InventarioMedicinas"))
                {
                    iNVENTARIOMEDICINAToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Pacientes"))
                {
                    pACIENTEToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Consultas"))
                {
                    cONSULTAToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Expedientes"))
                {
                    eXPEDIENTEToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD ProximaCita"))
                {
                    pROXIMACITAToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD ExpedienteRecetas"))
                {
                    eXPEDIENTERECETAToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD ResponsablePacientes"))
                {
                    rESPONSABLEPACIENTEToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("Reporte Paciente"))
                {
                rEPORTEPOREXPPACIENTEToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("Reporte Empleados"))
                {
                    rEPORTEPOREMPLEADOToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("Reporte Recetas"))
                {
                    rEPORTEPORRECETAToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Opciones"))
                {
                    oPCIONESToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Permisos"))
                {
                    pERMISOSToolStripMenuItem.Enabled = true;
                }
                if (Value.Equals("CRUD Recetas"))
                {
                    rECETAMEDICAToolStripMenuItem.Enabled = true;
                }
             }
        }

        private void gestionarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.GUI.GestionGrupos frm = new ModGestionBasica.GUI.GestionGrupos(this);
            frm.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
            Login frm = new Login();
            frm.ShowDialog();
          
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblGrupo_Click(object sender, EventArgs e)
        {

        }

        private void bancoDeSagreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblHoraInicio_Click(object sender, EventArgs e)
        {

        }

        private void gestionEspecialiadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionResponsablesPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionMedecinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void gestionPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void doctoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void crearExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void recetasMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void medicinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Medecinas.GestionMedecinas frm = new ModGestionBasica.Medecinas.GestionMedecinas();
            frm.Show();
        }

        private void proximasCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void expedientesRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Empleadosss.GestionEMpleados frm = new ModGestionBasica.Empleadosss.GestionEMpleados(this);
            frm.Show();
        }

        private void gRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.GUI.GestionGrupos frm = new ModGestionBasica.GUI.GestionGrupos(this);
            frm.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModGestionBasica.Usuarios_.GestionUsuarios frm = new ModGestionBasica.Usuarios_.GestionUsuarios();
            frm.Show();
        }

        private void dOCTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Doctores.GestionDoctores frm = new ModGestionBasica.Doctores.GestionDoctores();
            frm.Show();
        }

        private void eSPECIALIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModGestionBasica.Especialidades.GestionEspecialidades frm = new ModGestionBasica.Especialidades.GestionEspecialidades(this);
            frm.Show();
        }

        private void mEDICINAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ModGestionBasica.Medecinas.GestionMedecinas frm = new ModGestionBasica.Medecinas.GestionMedecinas();
            frm.Show();
        }

        private void iNVENTARIOMEDICINAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModGestionBasica.Existencias_.GestionExistencias frm = new ModGestionBasica.Existencias_.GestionExistencias();
            frm.Show();
        }

        private void pACIENTEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            ModGestionBasica.Pacientes_.GestionPacientes frm = new ModGestionBasica.Pacientes_.GestionPacientes();
            frm.Show();
        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Consultas_.GestionConsultas frm = new ModGestionBasica.Consultas_.GestionConsultas();
            frm.Show();
        }

        private void eXPEDIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Expedientes_.GestionExpedientes frm = new ModGestionBasica.Expedientes_.GestionExpedientes();
            frm.Show();
        }

        private void rECETAMEDICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Recetas_.GestionRecetas frm = new ModGestionBasica.Recetas_.GestionRecetas();
            frm.Show();
        }

        private void pROXIMACITAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Fecha_Citas.GestionFechaCitas frm = new ModGestionBasica.Fecha_Citas.GestionFechaCitas();
            frm.Show();
        }

        private void eXPEDIENTERECETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.expedientes_recetas_.GestionExpediente_Recetas frm = new ModGestionBasica.expedientes_recetas_.GestionExpediente_Recetas();
            frm.Show();
        }

        private void rESPONSABLEPACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Responsable_pacientes.GestionResponsable frm = new ModGestionBasica.Responsable_pacientes.GestionResponsable();
            frm.Show();
        }

        private void oPCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Opciones.GestionOpciones frm = new ModGestionBasica.Opciones.GestionOpciones();
            frm.Show();

        }

        private void pERMISOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ModGestionBasica.Permisos_.GestionPermisos frm = new ModGestionBasica.Permisos_.GestionPermisos();
            frm.Show();
        }

        private void eMPLEADOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXPEDIENTEPORPACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXPEDIENTEPOREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXPEDIENTEPORRECETAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTEPOREXPPACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.GUI.expedientes frm = new ModGestionBasica.GUI.expedientes();
            frm.Show();
        }
        private void fICHACITASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.Fecha_Citas.GestionFechaCitas frm = new ModGestionBasica.Fecha_Citas.GestionFechaCitas();
            frm.Show();
        }

        private void rEPORTEPOREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModGestionBasica.REP.empleados frm = new ModGestionBasica.REP.empleados();
            frm.Show();
        }

        private void rEPORTEPORRECETAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModGestionBasica.GUI.medicinas frm = new ModGestionBasica.GUI.medicinas();
            frm.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDireccionServer_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            MessageBox.Show("Tu IP local es: " + localIP);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (AccesoInternet())
            {
                MessageBox.Show("Acesso a Internet");
            }
            else {
                MessageBox.Show("Sin Acceso a Internet");
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reportesEInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        

       

        
    }
}
