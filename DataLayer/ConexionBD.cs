using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataLayer
{
    public abstract class ConexionBD
    {
        protected  MySqlConnection _CONEXION;

        protected String ObtenerIPServer()
        {
            return _CONEXION.DataSource.ToString();
        }

        public Boolean Conectar()
        {
            Boolean Conectado = false;
            String CadenaConexion = "Server = 192.168.1.11; Port = 3306; Database = DBHospital; Uid = root; Pwd = admin;";
            _CONEXION = new MySqlConnection();
            _CONEXION.ConnectionString = CadenaConexion;
            try
            {
                _CONEXION.Open();
                Conectado = true;
            }
            catch
            {
                Conectado = false;
            }
            return Conectado;
        }
        protected void Desconectar()
        {
            try
            {
                if(_CONEXION.State==System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch
            {

            }
        }

    }
}
