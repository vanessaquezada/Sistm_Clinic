using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager
{
    public static class Cache
    {
        public static DataTable REP_EXPEDIENTES(String ID)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT
	E.IDExpediente AS ID,
    (SELECT CONCAT(Emp.Nombres, ' ', Emp.Apellidos)
		FROM Empleados Emp, Doctores D
        WHERE Emp.IDEmpleado = D.IDEmpleado
        AND E.IDDoctor = D.IDDoctor) AS 'Doctor',
    CONCAT(E.FreqCardiaca, ' Latidos por Seg') AS 'Frecuencia Cardiaca',
    CONCAT(E.FreqRespiratoria, ' Respiraciones por Min') AS 'Frecuencia Respiratoria',
    CONCAT(E.Temperatura, ' °C') AS 'Temperatura',
    CONCAT(E.PesoActual, ' Lb') AS 'Peso Actual',
    CONCAT(E.Altura, ' M') AS 'Altura',
    E.Sintomas,
    E.Diagnostico,
    E.Indicaciones
FROM
	Expedientes E
WHERE 
	E.IDPaciente = " + ID + ";";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }


        public static DataTable REP_MEDICINAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT E.IDExistencia AS ID, M.Medicamento AS Medicamento,M.Concentrado AS Concentracion,CONCAT(M.Forma, ' ', M.Via) AS Presentacion,"+
            "E.Unidad AS Unidad,E.Cantidad AS Cantidad FROM Medicinas M, Existencias E WHERE M.IDMedicina = E.IDMedicina  AND M.Estado = 'Activa' AND E.Cantidad > 0;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static DataTable REP_EMPLEADOS(String FechaInicio, String FechaFin)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM Empleados WHERE FechaCreacion >= '" + FechaInicio + "' AND FechaCreacion < '" + FechaFin + "' AND Estado = 'Activo';";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }


        public static DataTable TODAS_FECHAS_CITAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDCita,IDPaciente,IDDoctor,IDConsulta,FechaProxima FROM ficha_citas ORDER BY  IDCita;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String FECHA_Citas_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDCita) FROM  ficha_citas;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }


        /************************************************************************************************************/
        public static DataTable TODOS_LOS_EXPEDIENTES_RECETAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT ID,IDExpediente,IDReceta FROM expedientes_recetas ORDER BY  ID;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String EXPEDIENTE_RECETAS_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(ID) FROM  expedientes_recetas;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }


        /********************************************************************************************************/
        public static DataTable TODAS_LAS_RECETAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDReceta,IDDoctor,IDPaciente,IDMedicina,Dosis,Cantidad FROM recetas_medicas ORDER BY  IDReceta;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String RECETAS_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDReceta) FROM  recetas_medicas;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }



        /***********************************************************************************************/
        public static DataTable TODOS_LOS_EXPEDIENTES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDExpediente,IDDoctor,IDPaciente,FreqCardiaca,FreqRespiratoria,Temperatura,PesoActual,Altura,Sintomas,Diagnostico,Indicaciones FROM expedientes ORDER BY  IDExpediente;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String Expedientes_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDExpediente) FROM expedientes;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }



        /***************************************************************************************************************************/

        public static DataTable TODOS_LAS_Consultas()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDConsulta,Tipo,Detalles,Estado FROM consultas ORDER BY  IDConsulta;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String Consultas_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDConsulta) FROM consultas;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }

        /******************************************************************************/
        

        public static DataTable TODOS_LOS_DOCTORES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDDoctor,IDEmpleado,IDEspecialidad,Turno FROM doctores ORDER BY  IDDoctor;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String DOCTORES_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDDoctor) FROM doctores;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        /************************************************************************************************/
        public static DataTable TODOS_LOS_PACIENTES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDPaciente,Nombres,Apellidos,Sexo,FechaNac,EstadoCivil,DUI,NIT,ISSS,Domicilio,Telefono,Estado FROM pacientes ORDER BY  Nombres;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String Pacientes_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDPaciente) FROM pacientes;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
       
 
        /***********************************************************************************/
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDUsuario,IDEmpleado,IDGrupo,Usuario,Credencial,Conectado,FechaCreacion,FechaModificacion FROM usuarios ORDER BY  Usuario;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String Usuarios_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDUsuario) FROM usuaios;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
       
        /*****************************************************************************/
        public static DataTable TODOS_LOS_PERMISOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDPermiso,IDGrupo,IDOpcion,FechaCreacion FROM permisos ORDER BY IDGrupo ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String Permisos_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDPermiso) FROM permisos;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        
        /*********************************************************************************************/
        public static DataTable Todas_LAS_Existencias()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDExistencia,IDMedicina,Unidad,Cantidad FROM existencias ORDER BY IDMedicina ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String Existencias_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDExistencia) FROM existencias;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        
        /*********************************************************************/
        #region ..:: Opciones ::..
        public static DataTable TODO_Las_Opciones()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDOpcion,Opcion,Categoria,FechaCreacion FROM Opciones ORDER BY Opcion ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }

        public static String OPCIONES_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDOpcion) FROM opciones;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        #endregion

        #region ..:: Medecinas ::..
        public static DataTable Todos_las_Medecinas()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDMedicina,Medicamento,Concentrado,Forma,Via,Estado FROM Medicinas ORDER BY Medicamento ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }
        
        public static String Medecina_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDMedicina) FROM Medicinas;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        #endregion
        /******************************************************************************************/
        /*********************************************************************************************/
        public static DataTable Todos_los_responsables()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDResponsable,Nombres,Apellidos,Parentesco FROM responsable_paciente ORDER BY Nombres ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }


        public static String Responsable_MAX_IDRes()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDResponsable) FROM responsable_paciente;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        
        /************************************************************************************/
        public static DataTable Todos_las_Especialidades()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDEspecialidad,especialidad FROM especialidades ORDER BY especialidad ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }


        public static String Especialiadad_MAX_ID()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDEspecialidad) FROM especialiadades;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }

        /**************************************************************************************************************+*/

        

        public static DataTable Todos_los_Empleados()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDempleado,Nombres,Apellidos,Sexo,DUI,NIT,ISSS,NUP,Telefono,Domicilio,Departamento,Municipio,Estado,FechaCreacion FROM empleados ORDER BY Nombres ASC;";
            OperacionBD oOperacion = new OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }


        public static String GRUPO_MAX_IDEM()
        {
            String Max = "0";
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT MAX(IDEmpleado) FROM empleados;");
            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                    return Max;
                }
                else
                {
                    return Max;
                }

            }
            catch
            {
                return Max;
            }
        }
        #region ..:: Grupos ::..

        public static DataTable TODO_LOS_GRUPOS()
            {
                DataTable Datos = new DataTable();
                String Consulta;
                Consulta = "SELECT IDGrupo, Grupo, FechaCreacion FROM Grupos ORDER BY Grupo ASC;";
                OperacionBD oOperacion = new OperacionBD();
                try
                {
                    Datos = oOperacion.Consultar(Consulta);
                }
                catch
                {
                    Datos = new DataTable();
                }

                return Datos;
            }

            public static String GRUPO_MAX_ID()
            {
                String Max = "0";
                StringBuilder Sentencia = new StringBuilder();
                Sentencia.Append(" SELECT MAX(IDGrupo) FROM Grupos;");
                OperacionBD oOperacion = new OperacionBD();

                try
                {
                    DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                    if (Aux != null)
                    {
                        Max = Aux.Rows[Aux.Rows.Count - 1][0].ToString();

                        return Max;
                    }
                    else
                    {
                        return Max;
                    }

                }
                catch
                {
                    return Max;
                }
            }

        #endregion

        public static DataTable DATOS_USUARIO(String pUsuario, String pCredencial)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT 
            a.IDUsuario,
            a.Usuario,
            a.Credencial,
            a.IDEmpleado,
            b.Nombres,
            b.Apellidos,
            a.IDGrupo,
            c.Grupo
            FROM usuarios a, empleados b, grupos c
            WHERE
            a.IDEmpleado=b.IDEmpleado
            AND a.IDGrupo=c.IDGrupo
            AND a.Usuario ='"+pUsuario+@"'
            AND a.Credencial=md5('"+pCredencial+@"');";
            DataLayer.OperacionBD oOperacion = new DataLayer.OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }



        public static DataTable TODO_LOS_EMPLEADOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT IDempleado, nombres,IDhospital FROM empleados ORDER BY Grupo ASC;";
            DataLayer.OperacionBD oOperacion = new DataLayer.OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }
        public static DataTable DATOS_EMPLEADOS(String pUsuario, String pCredencial)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT 
            a.IDUsuario,
            a.Usuario,
            a.Credencial,
            a.IDEmpleado,
            b.Nombres,
            b.Apellidos,
            a.IDGrupo,
            c.Grupo
            FROM usuarios a, empleados b, grupos c
            WHERE
            a.IDEmpleado=b.IDEmpleado
            AND a.IDGrupo=c.IDGrupo
            AND a.Usuario ='" + pUsuario + @"'
            AND a.Credencial=md5('" + pCredencial + @"');";
            DataLayer.OperacionBD oOperacion = new DataLayer.OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }



        // Leer de la BD todos los permisos / opciones según el Grupo del Usuario
        public static List<String> Usuario_Permisos(String Grupo)
        {
            List<String> Permisos = new List<string>();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(" SELECT ");
	            Sentencia.Append(" P.IDPermiso AS ID, ");
	            Sentencia.Append(" G.Grupo, ");
                Sentencia.Append(" O.Opcion AS Opcion, ");
                Sentencia.Append(" P.FechaCreacion AS Fecha ");
            Sentencia.Append(" FROM ");
	            Sentencia.Append(" Permisos P, Grupos G, Opciones O ");
            Sentencia.Append(" WHERE ");
                Sentencia.Append(" P.IDGrupo = G.IDGrupo AND ");
	            Sentencia.Append(" P.IDGrupo = '" + Grupo + "' AND ");
                Sentencia.Append(" P.IDOpcion = O.IDOpcion; ");

            OperacionBD oOperacion = new OperacionBD();

            try
            {
                DataTable Aux = oOperacion.Consultar(Sentencia.ToString());

                if (Aux != null)
                {
                    for (int i = 0; i < Aux.Rows.Count; i++)
                    {
                        // A Permisos le Agrego de la Fila "i" de la columna "Opcion" de la tabla AUX
                        Permisos.Add(Aux.Rows[i]["Opcion"].ToString());
                    }
                }
            }
            catch
            {

            }

            return Permisos;
        }
    }
}
