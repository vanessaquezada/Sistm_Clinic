using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class expedientes
    {
        String _IDExpediente;
        String _IDDoctor;
        String _IDPaciente;
        String _FreqCardiaca;
        String _FreqRespiratoria;
        String _Temperatura;
        String _PesoActual;
        String _Altura;
        String _Sintomas;
        String _Diagnostico;
        String _Indicaciones;

        public String Indicaciones
        {
            get { return _Indicaciones; }
            set { _Indicaciones = value; }
        }

        public String Diagnostico
        {
            get { return _Diagnostico; }
            set { _Diagnostico = value; }
        }

        public String Sintomas
        {
            get { return _Sintomas; }
            set { _Sintomas = value; }
        }

        public String Altura
        {
            get { return _Altura; }
            set { _Altura = value; }
        }

        public String PesoActual
        {
            get { return _PesoActual; }
            set { _PesoActual = value; }
        }

        public String Temperatura
        {
            get { return _Temperatura; }
            set { _Temperatura = value; }
        }

        public String FreqRespiratoria
        {
            get { return _FreqRespiratoria; }
            set { _FreqRespiratoria = value; }
        }

        public String FreqCardiaca
        {
            get { return _FreqCardiaca; }
            set { _FreqCardiaca = value; }
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

        public String IDExpediente
        {
            get { return _IDExpediente; }
            set { _IDExpediente = value; }
        }




        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO expedientes (IDDoctor,IDPaciente,FreqCardiaca,FreqRespiratoria,Temperatura,PesoActual,Altura,Sintomas,Diagnostico,Indicaciones) VALUES(");
            Sentencia.Append("'" + this.IDDoctor + "', ");
            Sentencia.Append("'" + this.IDPaciente + "', ");
            Sentencia.Append("'" + this.FreqCardiaca + "', ");
            Sentencia.Append("'" + this.FreqRespiratoria + "', ");
            Sentencia.Append("'" + this.Temperatura + "', ");
            Sentencia.Append("'" + this.PesoActual + "', ");
            Sentencia.Append("'" + this.Altura + "', ");
            Sentencia.Append("'" + this.Sintomas + "', ");
            Sentencia.Append("'" + this.Diagnostico + "', ");
            Sentencia.Append("'" + this.Indicaciones + "');");
       

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
            Sentencia.Append("UPDATE Expedientes SET ");
            Sentencia.Append("IDExpediente = '" + this.IDExpediente + "',");
            Sentencia.Append("IDPaciente = '" + this.IDPaciente + "',");
            Sentencia.Append("FreqCardiaca = '" + this.FreqCardiaca + "',");
            Sentencia.Append("FreqRespiratoria = '" + this.FreqRespiratoria + "',");
            Sentencia.Append("Temperatura = '" + this.Temperatura + "',");
            Sentencia.Append("PesoActual = '" + this.PesoActual + "',");
            Sentencia.Append("Altura = '" + this.Altura + "',");
            Sentencia.Append(" Sintomas = '" + this.Sintomas + "',");
            Sentencia.Append(" Diagnostico = '" + this.Diagnostico + "',");
            Sentencia.Append(" Indicaciones = '" + this.Indicaciones + "'");
            Sentencia.Append("WHERE IDExpediente = " + this.IDExpediente + ";");

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
            Sentencia.Append("DELETE FROM Expedientes");
            Sentencia.Append(" WHERE IDExpediente = " + this.IDExpediente + ";");
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
