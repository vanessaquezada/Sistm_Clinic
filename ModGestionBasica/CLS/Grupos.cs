using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using System.Data;

namespace ModGestionBasica.CLS
{
    class Grupos
    {
        //Control + r + e
        String _IDgrupo;
        String _grupo;
        String _fechaCreacion;

        public String FechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }

        public String Grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

        public String IDGrupo
        {
            get { return _IDgrupo; }
            set { _IDgrupo = value; }
        }

        //Creacion de Guardar, eliminar y actualizar

        //Guardar

        public Boolean Guardar()
        {

            Boolean Guardado = false;

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO Grupos(Grupo, FechaCreacion) VALUES(");
                Sentencia.Append("'" + this.Grupo + "', ");
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
            Sentencia.Append("UPDATE Grupos SET");
            Sentencia.Append(" Grupo = '" + this.Grupo + "'");
            Sentencia.Append("WHERE IDGrupo = "+ this.IDGrupo + ";");
        
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
            Sentencia.Append("DELETE FROM Grupos");
            Sentencia.Append(" WHERE IDGrupo = " + this.IDGrupo + ";");
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
