using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class Expedientes_recetas
    {
        String _ID;
        String _IDExpediente;
        String _IDReceta;

        public String IDReceta
        {
            get { return _IDReceta; }
            set { _IDReceta = value; }
        }

        public String IDExpediente
        {
            get { return _IDExpediente; }
            set { _IDExpediente = value; }
        }

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }



        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO expedientes_recetas(IDExpediente,IDReceta) VALUES(");
            Sentencia.Append("'" + this.IDExpediente + "', ");
            Sentencia.Append("'" + this.IDReceta + "'); ");



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
            Sentencia.Append("UPDAT expedientes_recetas SET ");
            Sentencia.Append("IDExpediente = '" + this.IDExpediente + "',");
            Sentencia.Append("IDReceta = '" + this.IDReceta + "'");
            Sentencia.Append("WHERE ID = " + this.ID + ";");

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
            Sentencia.Append("DELETE FROM expedientes_recetas");
            Sentencia.Append(" WHERE ID = " + this.ID + ";");
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
