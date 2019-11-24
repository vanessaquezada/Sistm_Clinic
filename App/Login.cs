using CacheManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Login : Form
    {
        //Atributo
        Boolean _Autorizado = false;
        //Convertir en propiedad (Ctrl + R + E)
        public Boolean Autorizado
        {
            get { return _Autorizado; }
        }

        private void IniciarSesion()
        {
            DataTable Datos=new DataTable();
            //HACIENDO USO ESTATICO DE LA CLASE CACHE.
            Datos = Cache.DATOS_EMPLEADOS(txbUsuario.Text, txbPassword.Text);
            //HACIENDO USO A TRAVES DE UNA INSTANCIA
            //CacheManager.Cache oCache = new CacheManager.Cache();
            if(Datos.Rows.Count==1)
            {
                SessionManager.Sesion _SESION =SessionManager.Sesion.Instancia;
                _SESION.Usuario = Datos.Rows[0]["Usuario"].ToString();
                _SESION.IDUsuario = Datos.Rows[0]["IDUsuario"].ToString();
                _SESION.IDEmpleado = Datos.Rows[0]["IDEmpleado"].ToString();
                _SESION.Nombres = Datos.Rows[0]["Nombres"].ToString();
                _SESION.Apellidos = Datos.Rows[0]["Apellidos"].ToString();
                _SESION.IDGrupo = Datos.Rows[0]["IDGrupo"].ToString();
                _SESION.Grupo = Datos.Rows[0]["Grupo"].ToString();

                //EL USUARIO EXISTE
                // A por los Permisos
                _SESION.Permisos = Cache.Usuario_Permisos(_SESION.IDGrupo);
                //MessageBox.Show("CORRECTO");
                _Autorizado = true;
                Close();
            }
            else
            {
                //USUARIO O CONTRASEÑA ERRONEOS
                MessageBox.Show("Usuario / Contraseña erroneos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                _Autorizado = false;
                txbPassword.Focus();
                txbPassword.SelectAll();
            }

        }

        public Login()
        {
            InitializeComponent();
        }

        private void txbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txbPassword.Focus();
                txbPassword.SelectAll();
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.IniciarSesion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txbPassword.PasswordChar = '*';
            }
            else
                if (txbPassword.Text != "")
                {
                    txbPassword.PasswordChar = '\0';
                }

        }
    }
}
