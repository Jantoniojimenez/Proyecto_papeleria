
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;


namespace AccesoBDDatos
{
    public class ClassConexion

    {
        

            public static SqlConnection Conexion()

            {
                String cadena = @"Data Source = LAPMAQUINA97\SQLEXPRESS;Initial Catalog=Base_DeportesU7;Integrated Security=True";

                return new SqlConnection(cadena);

            }
        

            public static SQLiteConnection ConexionSqlite()
            {

            //String RutaBase = @"C:\Users\anton\OneDrive\REPORTE ELITE\Base_Papeleria.accdb";
            String RutaBase = "Base_Papeleria.db;Version=3";

            //String VarConeccion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + RutaBase  + ";jet OLEDB:Database password = 3066";
            String VarConeccion = "Data Source= " + RutaBase;



            return new SQLiteConnection(VarConeccion);

            }
        }
    
}
