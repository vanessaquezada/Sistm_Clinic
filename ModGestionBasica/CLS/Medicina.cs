using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using System.Data;

namespace ModGestionBasica.CLS
{
    class Medicina
    {
        String _IDMedicina;
        String _Medicamento;
        String _Concentrado;
        String _Forma;
        String _Via;
        String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public String Via
        {
            get { return _Via; }
            set { _Via = value; }
        }

        public String Forma
        {
            get { return _Forma; }
            set { _Forma = value; }
        }

        public String Concentrado
        {
            get { return _Concentrado; }
            set { _Concentrado = value; }
        }

        public String Medicamento
        {
            get { return _Medicamento; }
            set { _Medicamento = value; }
        }

        public String IDMedicina
        {
            get { return _IDMedicina; }
            set { _IDMedicina = value; }
        }

        /*MEDTODO GUARDAR ,ACTUALIZAR,ELIMINAR*/
        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO medicinas(Medicamento,Concentrado,Forma,Via,Estado) VALUES(");
            Sentencia.Append("'" + this.Medicamento + "', ");
            Sentencia.Append("'" + this.Concentrado + "', ");
            Sentencia.Append("'" + this.Forma + "', ");
            Sentencia.Append("'" + this.Via + "', ");
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
            Sentencia.Append("UPDATE medicinas SET ");
            Sentencia.Append("Medicamento = '" + this.Medicamento + "',");
            Sentencia.Append("Concentrado = '" + this.Concentrado +"',");
            Sentencia.Append("Forma = '" + this.Forma + "',");
            Sentencia.Append("Via= '" + this.Via + "',");
            Sentencia.Append("Estado = '" + this.Estado + "'");
            Sentencia.Append("WHERE IDMedicina = " + this.IDMedicina + ";");

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
            Sentencia.Append("DELETE FROM medicinas");
            Sentencia.Append(" WHERE IDMedicina = " + this._IDMedicina + ";");
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
