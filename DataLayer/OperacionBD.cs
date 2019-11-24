using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class OperacionBD: ConexionBD
    {
        public String ObtenerIPServer()
        {
            if(base.Conectar())
            {
                return base.ObtenerIPServer();
            }
            else
            {
                return "0.0.0.0";
            }
        }
        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        

        private Int32 EjecutarSentencia(String pSentecia)
        {
            Int32 NumeroFilasAfectadas = 0;
            if(base.Conectar())
            {
                MySqlCommand Comando = new MySqlCommand();
                Comando.Connection = base._CONEXION;
                Comando.CommandText = pSentecia;
                try
                {
                    NumeroFilasAfectadas = Comando.ExecuteNonQuery();
                }
                catch
                {
                    NumeroFilasAfectadas = 0;
                }
            }
            return NumeroFilasAfectadas;
        }
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }
        private DataTable EjecutarConsulta(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            try
            {
                if (base.Conectar())
                {
                    MySqlCommand Comando = new MySqlCommand();
                    MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                    Comando.Connection = base._CONEXION;
                    Comando.CommandText = pConsulta;
                    Comando.CommandType = CommandType.Text;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                }
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }
    }
}