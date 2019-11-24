using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGestionBasica.CLS
{
    class Pacientes
    {
        String _IDPaciente;
        String _Nombres;
        String _Apellidos;
        String _Sexo;
        String _FechaNac;

        public String FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
        }
        String _EstadoCivil;
        String _DUI;
        String _NIT;
        String _ISSS;
        String _Domicilio;
        String _Telefono;
        String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public String Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = value; }
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

        public String EstadoCivil
        {
            get { return _EstadoCivil; }
            set { _EstadoCivil = value; }
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

        public String IDPaciente
        {
            get { return _IDPaciente; }
            set { _IDPaciente = value; }
        }



          public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO pacientes(Nombres,Apellidos,Sexo,FechaNac,EstadoCivil,DUI,NIT,ISSS,Domicilio,Telefono,Estado) VALUES(");
            Sentencia.Append("'" + this.Nombres + "',");
            Sentencia.Append("'" + this.Apellidos + "',");
            Sentencia.Append("'" + this.Sexo + "',");
            Sentencia.Append("'" + this.FechaNac + "',");
            Sentencia.Append("'" + this.EstadoCivil + "',");
            Sentencia.Append("'" + this.DUI + "',");
            Sentencia.Append("'" + this.NIT + "',");
            Sentencia.Append("'" + this.ISSS + "',");
            Sentencia.Append("'" + this.Domicilio + "',");
            Sentencia.Append("'" + this.Telefono + "',");
            Sentencia.Append("'" + this.Estado + "');");
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
              Sentencia.Append("UPDATE pacientes SET ");
              Sentencia.Append(" Nombres = '" + this.Nombres + "',");
              Sentencia.Append("Apellidos = '" + this.Apellidos + "',");
              Sentencia.Append("Sexo = '" + this.Sexo + "',");
              Sentencia.Append(" FechaNac = '" + this.FechaNac + "',");
              Sentencia.Append("EstadoCivil = '" + this.EstadoCivil + "',");
              Sentencia.Append(" DUI = '" + this.DUI + "',");
              Sentencia.Append(" NIT = '" + this.NIT + "',");
              Sentencia.Append(" ISSS = '" + this.ISSS + "',");
              Sentencia.Append(" Domicilio = '" + this.Domicilio + "',");
              Sentencia.Append(" Telefono = '" + this.Telefono + "',");
              
              Sentencia.Append(" Estado = '" + this.Estado + "'");
              Sentencia.Append("WHERE IDPaciente = " + this.IDPaciente + ";");

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
              Sentencia.Append("DELETE FROM pacientes ");
              Sentencia.Append(" WHERE IDPaciente = " + this.IDPaciente + ";");
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
