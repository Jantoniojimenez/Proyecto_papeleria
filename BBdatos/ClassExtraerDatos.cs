using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace AccesoBDDatos

{
    public class ClassExtraerDatos: ClassConexion

    {

            public static List<string> Datos()
            {

             string sentencia = "select * from Table_Cliente";
            using (SqlConnection connection = ClassConexion.Conexion())
            {

                connection.Open();

                using (SqlCommand comando = new SqlCommand(sentencia, connection))
                {

                    comando.CommandText = sentencia;
                    comando.CommandType = CommandType.Text;


                    using (SqlDataReader Reade = comando.ExecuteReader())
                    {

                        lista.Clear();

                        while (Reade.Read())
                        {

                            lista.Add(Reade[0].ToString());

                        }

                        return lista;

                    }

                }
            }

        }

        private static readonly List<string> lista = new List<string>();

        public static List<string> ExtraerPrefijosBBD()
        {

            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())
            {

                connection.Open();

                string sentencia = "select PREFIJOS from PrefijosYrutas";
                using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))

                {

                    comando.CommandText = sentencia;
                    comando.CommandType = CommandType.Text;                

                    using (SQLiteDataReader Reade = comando.ExecuteReader()){

                        lista.Clear();

                         while (Reade.Read())
                        {

                            lista.Add(Reade[0].ToString());

                        }
                                  
                    return lista;
                    }
                }

            }

        }
     
    }

}


