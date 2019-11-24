using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class Ficha_citas
    {
        String _IDCita;
        String _IDPaciente;
        String _IDDoctor;
        String _IDConsulta;
        String _FechaProxima;

        public String FechaProxima
        {
            get { return _FechaProxima; }
            set { _FechaProxima = value; }
        }

        public String IDConsulta
        {
            get { return _IDConsulta; }
            set { _IDConsulta = value; }
        }

        public String IDDoctor
        {
            get { return _IDDoctor; }
            set { _IDDoctor = value; }
        }

        public String IDPaciente
        {
            get { return _IDPaciente; }
            set { _IDPaciente = value; }
        }

        public String IDCita
        {
            get { return _IDCita; }
            set { _IDCita = value; }
        }


        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO ficha_citas(IDPaciente,IDDoctor,IDConsulta,FechaProxima) VALUES(");
            Sentencia.Append("'" + this.IDPaciente + "', ");
            Sentencia.Append("'" + this.IDDoctor + "', ");
            Sentencia.Append("'" + this.IDConsulta + "', ");
            Sentencia.Append("'" + this.FechaProxima+ "'); ");



            OperacionBD oOperacion = new OperacionBD();

            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
            }
            catch
            {
                Guardado = false;
            }

            return Guardado;
        }



        public Boolean Actualizar()
        {

            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDAT  ficha_citas SET");
            Sentencia.Append("IDPaciente = '" + this.IDPaciente + "',");
            Sentencia.Append("IDDoctor = '" + this.IDDoctor + "',");
            Sentencia.Append("IDConsulta = '" + this.IDConsulta + "',");
            Sentencia.Append("FechaProxima = '" + this._FechaProxima + "',");
            Sentencia.Append("WHERE IDCita = " + this.IDConsulta + ";");

            OperacionBD oOperacion = new OperacionBD();

            try
            {
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
                {
                    Actualizado = true;
                }
                else
                {
                    Actualizado = false;
                }
            }
            catch
            {
                Actualizado = false;
            }

            return Actualizado;
        }


        public Boolean Eliminar()
        {

            Boolean Eliminado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM fecha_citas");
            Sentencia.Append(" WHERE IDCita = " + this.IDCita + ";");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
                {
                    Eliminado = true;
                }
                else
                {
                    Eliminado = false;
                }
            }
            catch
            {
                Eliminado = false;
            }

            return Eliminado;
        }
    
    


    }
}
