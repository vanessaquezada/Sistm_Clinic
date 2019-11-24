using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class Empleado
    {
        String _IDEmpleado;
        String _Nombres;
        String _Apellidos;
        String _Sexo;
        String _DUI;
        String _NIT;
        String _ISSS;
        String _NUP;
        String _Telefono;
        String _Domicilio;
        String _Departamento;
        String _Municipio;
        String _Estado;
        String _FEchaCreacion;

        public String FEchaCreacion
        {
            get { return _FEchaCreacion; }
            set { _FEchaCreacion = value; }
        }

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public String Municipio
        {
            get { return _Municipio; }
            set { _Municipio = value; }
        }

        public String Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        public String Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = value; }
        }

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public String NUP
        {
            get { return _NUP; }
            set { _NUP = value; }
        }

        public String ISSS
        {
            get { return _ISSS; }
            set { _ISSS = value; }
        }

        public String NIT
        {
            get { return _NIT; }
            set { _NIT = value; }
        }

        public String DUI
        {
            get { return _DUI; }
            set { _DUI = value; }
        }

        public String Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
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

        public String IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }


        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO empleados (Nombres,Apellidos,Sexo,DUI,NIT,ISSS,NUP,Telefono,Domicilio,Departamento,Municipio,Estado,FechaCreacion) VALUES(");
            Sentencia.Append("'" + this.Nombres + "', ");
            Sentencia.Append("'" + this.Apellidos + "', ");
            Sentencia.Append("'" + this.Sexo + "', ");
            Sentencia.Append("'" + this.DUI + "', ");
            Sentencia.Append("'" + this.NIT + "', ");
            Sentencia.Append("'" + this.ISSS + "', ");
            Sentencia.Append("'" + this.NUP + "', ");
            Sentencia.Append("'" + this.Telefono + "', ");
            Sentencia.Append("'" + this.Domicilio + "', ");
            Sentencia.Append("'" + this.Departamento + "', ");
            Sentencia.Append("'" + this.Municipio + "', ");
            Sentencia.Append("'" + this.Estado + "', ");
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
            Sentencia.Append("UPDATE empleados SET");
            Sentencia.Append(" Nombres = '" + this.Nombres + "',");
            Sentencia.Append("Apellidos = '" + this.Apellidos + "',");
            Sentencia.Append("Sexo = '" + this.Sexo + "',");
            Sentencia.Append(" DUI = '" + this.DUI + "',");
            Sentencia.Append(" NIT = '" + this.NIT + "',");
            Sentencia.Append(" ISSS = '" + this.ISSS + "',");
            Sentencia.Append(" NUP = '" + this.NUP + "',");
            Sentencia.Append(" Telefono = '" + this.Telefono + "',");
            Sentencia.Append(" Domicilio = '" + this.Domicilio + "',");
            Sentencia.Append(" Departamento = '" + this.Departamento + "',");
            Sentencia.Append(" Municipio = '" + this.Municipio + "',");
            Sentencia.Append(" Estado = '" + this.Estado + "'");
            Sentencia.Append("WHERE IDEmpleado = " + this.IDEmpleado + ";");

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
            Sentencia.Append("DELETE FROM empleados");
            Sentencia.Append(" WHERE IDEmpleado = " + this.IDEmpleado + ";");
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
