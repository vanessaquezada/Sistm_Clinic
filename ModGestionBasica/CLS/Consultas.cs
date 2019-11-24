using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class Consultas
    {
        String _IDConsulta;
        String _Tipo;
        String _Detalles;
        String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public String Detalles
        {
            get { return _Detalles; }
            set { _Detalles = value; }
        }

        public String Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        public String IDConsulta
        {
            get { return _IDConsulta; }
            set { _IDConsulta = value; }
        }



        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO consultas(Tipo,Detalles,Estado) VALUES(");
            Sentencia.Append("'" + this.Tipo + "', ");
            Sentencia.Append("'" + this.Detalles + "', ");
            Sentencia.Append("'" + this.Estado + "'); ");



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
            Sentencia.Append("UPDATE  consultas SET ");
            Sentencia.Append("Tipo = '" + this.Tipo + "',");
            Sentencia.Append("Detalles = '" + this.Detalles + "',");
            Sentencia.Append("Estado = '" + this.Estado + "'");
            Sentencia.Append("WHERE IDConsulta = " + this.IDConsulta + ";");

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
            Sentencia.Append("DELETE FROM consultas");
            Sentencia.Append(" WHERE IDConsulta = " + this.IDConsulta + ";");
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
