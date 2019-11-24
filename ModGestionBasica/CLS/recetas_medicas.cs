using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class recetas_medicas
    {
        String _IDReceta;
        String _IDDoctor;
        String _IDPaciente;
        String _IDMedicina;
        String _Dosis;
        String _Cantidad;

        public String Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public String Dosis
        {
            get { return _Dosis; }
            set { _Dosis = value; }
        }

        public String IDMedicina
        {
            get { return _IDMedicina; }
            set { _IDMedicina = value; }
        }

        public String IDPaciente
        {
            get { return _IDPaciente; }
            set { _IDPaciente = value; }
        }

        public String IDDoctor
        {
            get { return _IDDoctor; }
            set { _IDDoctor = value; }
        }

        public String IDReceta
        {
            get { return _IDReceta; }
            set { _IDReceta = value; }
        }


        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO recetas_medicas(IDDoctor,IDPaciente,IDMedicina,Dosis,Cantidad) VALUES(");
            Sentencia.Append("'" + _IDDoctor + "', ");
            Sentencia.Append("'" + _IDPaciente + "',");
            Sentencia.Append("'" + _IDMedicina + "',");
            Sentencia.Append("'" + _Dosis + "',");
            Sentencia.Append("'" + _Cantidad + "');");

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
            Sentencia.Append("UPDATE recetas_medicas SET");
            Sentencia.Append(" IDDoctor = '" + this.IDDoctor + "'");
            Sentencia.Append(" IDPaciente = '" + this.IDPaciente + "'");
            Sentencia.Append(" IDMedicina= '" + this.IDMedicina + "'");
            Sentencia.Append(" Dosis = '" + this.Dosis + "'");
            Sentencia.Append("Cantidad = '" + this.Cantidad + "'");
            Sentencia.Append("WHERE IDReceta = " + this.IDReceta + ";");

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
            Sentencia.Append("DELETE FROM recetas_medicas");
            Sentencia.Append(" WHERE IDReceta = " + this.IDReceta + ";");
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
