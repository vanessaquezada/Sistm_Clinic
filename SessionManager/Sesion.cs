using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public class Sesion
    {
        private static volatile Sesion _Instancia=null;
        private static object Bloqueador = new Object();

        String _IDUsuario;
        String _Usuario;
        String _Nombres;
        String _Apellidos;
        String _IDGrupo;
        String _Grupo;
        String _IDEmpleado;

        public List<String> Permisos = new List<string>();

        public String IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        public String Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        public String IDGrupo
        {
            get { return _IDGrupo; }
            set { _IDGrupo = value; }
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

        public String IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public static Sesion Instancia
        {
            get 
            {
                if(_Instancia==null)
                {
                    lock(Bloqueador)
                    {
                        if(_Instancia==null)
                        {
                            _Instancia = new Sesion();
                        }
                    }
                }
                return Sesion._Instancia; 
            }
        }

        private Sesion()
        {

        }


    }
}
