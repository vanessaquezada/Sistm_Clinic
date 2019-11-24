using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class exitencias
    {
        String _IDExistencia;
        String _IDMedicina;
        String _Unidad;
        String _Cantidad;

        public String Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public String Unidad
        {
            get { return _Unidad; }
            set { _Unidad = value; }
        }

        public String IDMedicina
        {
            get { return _IDMedicina; }
            set { _IDMedicina = value; }
        }

        public String IDExistencia
        {
            get { return _IDExistencia; }
            set { _IDExistencia = value; }
        }

        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO existencias(IDMedicina,Unidad,Cantidad) VALUES(");
            Sentencia.Append("'" + this.IDMedicina + "', ");
            Sentencia.Append("'" + this.Unidad + "', ");
            Sentencia.Append("'" + this.Cantidad + "'); ");
         


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
            Sentencia.Append(" UPDATE existencias SET  ");
            Sentencia.Append("IDMedicina = '" + this.IDMedicina + "',");
            Sentencia.Append("Unidad = '" + this.Unidad + "',");
            Sentencia.Append("Cantidad = '" + this.Cantidad + "'");
            Sentencia.Append("WHERE IDExistencia = " + this.IDExistencia + ";");

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
            Sentencia.Append("DELETE FROM existencias");
            Sentencia.Append(" WHERE IDExistencia  = " + this.IDExistencia + ";");
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
