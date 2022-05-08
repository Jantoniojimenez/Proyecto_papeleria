using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AccesoBDDatos.AgregarBuscarPrefijoNew
{
    public class InsertarPrefijo
    {

        public static string ExtraerLink(string Prefijo)
        {
   

            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())
            {

                connection.Open();
                 
                string sentencia = "Select Rutas from PrefijosYrutas where prefijos = @PrefijoBuscado";

                using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))
                {

                    comando.Parameters.Add("@PrefijoBuscado", DbType.String).Value = Prefijo;
                    comando.CommandType = CommandType.Text;                 

                    using (SQLiteDataReader Reade = comando.ExecuteReader())
                    {
                    
                       List<string> lista = new List<string>();

                        while (Reade.Read())
                        {

                            lista.Add(Reade[0].ToString());

                        }


                        if (lista.Count != 0) return lista.First();

                        else return null;

                    }

                }
          

            }
        

        }


        public static void InsertarDatos(String prefijo, string Ruta)
        {
            
            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())
            {

                connection.Open();
                using (SQLiteTransaction transacsion = connection.BeginTransaction())
                {

                    try
                {

                        string sentencia = "Insert into PrefijosYrutas(prefijos,Rutas) Values(@Prefij,@link)";
                        using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))

                        {

                            comando.Transaction = transacsion;
                            comando.CommandType = CommandType.Text;
                            comando.Parameters.AddWithValue("@Prefij", prefijo);
                            comando.Parameters.AddWithValue("@link", Ruta);
                            comando.ExecuteNonQuery();
                            transacsion.Commit();

                        }

                }
                catch (Exception)
                {

                        transacsion.Rollback();
                     if(connection.State == ConnectionState.Open)   connection.Close();

                    }

                }

            }


        }

    }
}
