using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class Doctoress
    {
        String _IDDoctor;
        String _IDEMpleado;
        String _IDEspecialidad;
        String _Turno;

        public String Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
        }
        public String IDEspecialidad
        {
            get { return _IDEspecialidad; }
            set { _IDEspecialidad = value; }
        }
    
        public String IDEMpleado
        {
            get { return _IDEMpleado; }
            set { _IDEMpleado = value; }
        }
    
        public String IDDoctor
        {
            get { return _IDDoctor; }
            set { _IDDoctor = value; }
        }




        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO doctores(IDEmpleado,IDEspecialidad,Turno) VALUES(");
            Sentencia.Append("'"+ this.IDEMpleado + "',");
            Sentencia.Append("'" + this.IDEspecialidad + "',");
            Sentencia.Append("'"+this.Turno + "');");
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
            Sentencia.Append("UPDATE doctores SET");
            Sentencia.Append(" IDEmpleado = '" + this.IDEMpleado + "',");
            Sentencia.Append("IDEspecialidad = '" + this.IDEspecialidad + "',");
            Sentencia.Append("Turno = '" + this.Turno + "'");
            Sentencia.Append("WHERE IDDoctor = " + this.IDDoctor + ";");

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
            Sentencia.Append("DELETE FROM doctores");
            Sentencia.Append(" WHERE IDDoctor= " + this.IDDoctor + ";");
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
