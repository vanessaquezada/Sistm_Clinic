using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class permisos
    {
        String _IDPermiso;
        String _IDGrupo;
        String _IDOpcion;
        String _FechaCreacion;

        public String FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public String IDOpcion
        {
            get { return _IDOpcion; }
            set { _IDOpcion = value; }
        }
        public String IDGrupo
        {
            get { return _IDGrupo; }
            set { _IDGrupo = value; }
        }
        
        public String IDPermiso
        {
            get { return _IDPermiso; }
            set { _IDPermiso = value; }
        }

        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO permisos(IDGrupo,IDOpcion,FechaCreacion) VALUES(");
            Sentencia.Append("'" + this.IDGrupo + "', ");
            Sentencia.Append("'" + this.IDOpcion+ "', ");
            Sentencia.Append("" + "NOW()" + "); ");



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
            Sentencia.Append("UPDATE permisos SET ");
            Sentencia.Append("IDGrupo = '" + this.IDGrupo + "',");
            Sentencia.Append("IDOpcion = '" + this.IDOpcion + "'");
         
            Sentencia.Append("WHERE IDPermiso = " + this.IDPermiso + ";");

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
            Sentencia.Append("DELETE FROM permisos");
            Sentencia.Append(" WHERE IDPermiso = " + this.IDPermiso + ";");
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
