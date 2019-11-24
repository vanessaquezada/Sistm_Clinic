using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class usuarios
    {
        String _IDUsuario;
        String _IDEmpleado;
        String _IDGrupo;
        String _Usuario;
        String _Credencial;
        String _Conectado;
        String _FechaCreacion;
        String _FechaModificacion;

        public String IDGrupo
        {
            get { return _IDGrupo; }
            set { _IDGrupo = value; }
        }
     
        public String FechaModificacion
        {
            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }

        public String FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public String Conectado
        {
            get { return _Conectado; }
            set { _Conectado = value; }
        }

        public String Credencial
        {
            get { return _Credencial; }
            set { _Credencial = value; }
        }

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public String IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        public String IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }



        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO usuarios(IDEmpleado,IDGrupo,Usuario,Credencial,Conectado,FechaCreacion,FechaModificacion) VALUES(");
            Sentencia.Append("'" + this.IDEmpleado + "', ");
            Sentencia.Append("'" + this.IDGrupo+ "', ");
            Sentencia.Append("'" + this.Usuario + "', ");
            Sentencia.Append("MD5('" + this.Credencial + "'),");
            Sentencia.Append("'" + this.Conectado + "', ");
            Sentencia.Append("" + "NOW()" + ",");
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



        public Boolean Actualizar()
        {

            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE usuarios SET ");
            Sentencia.Append("IDEmpleado = '" + this.IDEmpleado + "',");
            Sentencia.Append("IDGrupo = '" + this.IDGrupo + "',");
            Sentencia.Append("Usuario = '" + this.Usuario + "',");
            Sentencia.Append("Credencial= '" + this.Credencial + "'");
            Sentencia.Append("WHERE IDUsuario = " + this.IDUsuario + ";");

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
            Sentencia.Append("DELETE FROM usuarios");
            Sentencia.Append(" WHERE IDUsuario = " + this.IDUsuario+ ";");
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
