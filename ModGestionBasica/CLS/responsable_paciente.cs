using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class responsable_paciente
    {
        String _IDResponsable;
        String _Nombres;
        String _Apellidos;
        String _Parentesco;

        public String Parentesco
        {
            get { return _Parentesco; }
            set { _Parentesco = value; }
        }

        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public String IDResponsable
        {
            get { return _IDResponsable; }
            set { _IDResponsable = value; }
        }


        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO responsable_paciente(Nombres,Apellidos,Parentesco) VALUES(");
            Sentencia.Append("'" + this.Nombres + "', ");
            Sentencia.Append("'" + this.Apellidos + "', ");
            Sentencia.Append("'" + this.Parentesco + "'); ");
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


        //ACTUALIZAR
        public Boolean Actualizar()
        {

            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE responsable_paciente SET");
            Sentencia.Append(" Nombres = '" + this.Nombres + "',");
            Sentencia.Append("Apellidos = '" + this.Apellidos + "',");
            Sentencia.Append("Parentesco = '" + this.Parentesco + "'");   
            Sentencia.Append("WHERE IDResponsable = " + this.IDResponsable + ";");

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

        //ELIMINAR
        public Boolean Eliminar()
        {

            Boolean Eliminado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM responsable_paciente");
            Sentencia.Append(" WHERE IDResponsable = " + this.IDResponsable + ";");
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
