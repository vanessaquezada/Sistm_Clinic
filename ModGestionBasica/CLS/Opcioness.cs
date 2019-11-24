using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using System.Data;

namespace ModGestionBasica.CLS
{
    class Opcioness
    {
        String _IDOpcion;
        String _Opcion;
        String _Categoria;
        String _FechaCreacion;

        public String FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public String Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        public String Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

        public String IDOpcion
        {
            get { return _IDOpcion; }
            set { _IDOpcion = value; }
        }
        //Guardar

        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO Opciones(Opcion,Categoria,FechaCreacion) VALUES(");
            Sentencia.Append("'" + this.Opcion + "', ");
            Sentencia.Append("'" + this.Categoria + "', ");
            Sentencia.Append("" + "NOW()" + ");");

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
            Sentencia.Append("UPDATE opciones SET");
            Sentencia.Append(" Opcion = '" + this.Opcion + "',");
            Sentencia.Append(" Categoria = '" + this.Categoria + "'");
            Sentencia.Append("WHERE IDOpcion = " + this.IDOpcion+ ";");

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
            Sentencia.Append("DELETE FROM opciones");
            Sentencia.Append(" WHERE IDOpcion = " + this.IDOpcion + ";");
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
