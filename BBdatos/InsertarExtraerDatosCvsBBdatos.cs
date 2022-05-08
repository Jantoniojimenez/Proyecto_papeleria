using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesGenerales;
using System.Data.SQLite;

namespace AccesoBDDatos
{
   public class InsertarExtraerDatosCvsBBdatos
    {

        public static List<Impresion> GetImprecionesBDD(DateTime StarHour, DateTime EndHour)
        {


            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())

            {

                connection.Open();

                string sentencia = "Select Prefijo,Tray,[Sales Order],[Upper Start],[Upper End],[Lower Start],[Lower End],[Quantity Remaining],[Hora Impresion] " +
                                   "from Tabla_Datos_Papeleria where [Hora Impresion] between @StarHour and @EndHour";


                using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))
                {

                    comando.Parameters.Add("@StarHour", DbType.Date).Value = StarHour;
                    comando.Parameters.Add("@EndHour", DbType.Date).Value = EndHour;
                    comando.CommandType = CommandType.Text;
                    

                    using (SQLiteDataReader Reade = comando.ExecuteReader())
                    {


                        List<Impresion> lista = new List<Impresion>();

                        while (Reade.Read())
                        {
                  
                            lista.Add(new Impresion
                            {
                                Prefijo = Reade[0].ToString(),
                                Tray = Reade[1].ToString(),
                                Order = Reade[2].ToString(),
                                Upper_Start = Reade[3].ToString(),
                                Upper_End = Reade[4].ToString(),
                                Lower_Start = Reade[5].ToString(),
                                Lower_End = Reade[6].ToString(),
                                Quantity_Remaining = Reade[7].ToString(),
                                Date_Impresion = Convert.ToDateTime(Reade[8].ToString())
                            });

                        }

                     
                        return lista;
                  
                    }

                }

            }


        }


        public static List<SubImpresion> GetImprecionesBDD2(DateTime StarHour, DateTime EndHour)
        {

            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())
            {

                connection.Open();

                string sentencia = "Select Prefijo,Tray,[Sales Order],Hora_Impresion from Tble_Ordenes_Procesadas where Hora_Impresion between @StarHour and @EndHour";


                using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))
                {

                    comando.Parameters.Add("@StarHour", DbType.Date).Value = StarHour;
                    comando.Parameters.Add("@EndHour", DbType.Date).Value = EndHour;
                    comando.CommandType = CommandType.Text;


                    using (SQLiteDataReader Reade = comando.ExecuteReader())
                    {

                        List<SubImpresion> lista = new List<SubImpresion>();

                        while (Reade.Read())
                        {

                            lista.Add(new SubImpresion
                            {   
                                Prefijo = Reade[0].ToString(),
                                Tray = Reade[1].ToString(),
                                Order = Reade[2].ToString(),                            
                                Date_Impresion = Convert.ToDateTime( Reade[3].ToString())
                            });

                        }                            

                        return lista;

                    }

                }

            }


        }



        public static void InsertarMaterialCvsBDD(DataTable MiLista)
        {

            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())
            {

                connection.Open();

                string trays = "";
                foreach (DataRow T in MiLista.Rows) { trays += T.ItemArray.GetValue(1) + "','"; }
           

                if (OrdenesDuplicated(connection, trays) == false)


                    using (SQLiteTransaction transacsion = connection.BeginTransaction())
                    {

                    try
                    {

                        string sentencia = "Insert into Tabla_Datos_Papeleria(Prefijo,Tray,[Sales Order],[Upper Start],[Upper End],[Lower Start],[Lower End],[Quantity Remaining],[Hora Impresion])" +
                                           " Values(@Prefijo,@Tray,@Sales_Order,@C1,@C2,@C3,@C4,@C5,@Hora_Impresion)";
                        using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))

                        {
                            comando.Transaction = transacsion;
                            comando.CommandType = CommandType.Text;                         

                            foreach (DataRow row in MiLista.Rows)
                            {
                                    comando.Parameters.AddWithValue("@Prefijo", row.ItemArray.First().ToString());
                                    comando.Parameters.AddWithValue("@Tray", row.ItemArray.ElementAt(1).ToString());
                                    comando.Parameters.AddWithValue("@Sales_Order", row.ItemArray.ElementAt(7).ToString());
                                    comando.Parameters.AddWithValue("@C1", row.ItemArray.ElementAt(2).ToString());
                                    comando.Parameters.AddWithValue("@C2", row.ItemArray.ElementAt(3).ToString());
                                    comando.Parameters.AddWithValue("@C3", row.ItemArray.ElementAt(4).ToString());
                                    comando.Parameters.AddWithValue("@C4", row.ItemArray.ElementAt(5).ToString());
                                    comando.Parameters.AddWithValue("@C5", row.ItemArray.ElementAt(6).ToString());
                                    comando.Parameters.Add("@Hora_Impresion", DbType.Date).Value = DateTime.Parse(row.ItemArray.Last().ToString());

                                    comando.ExecuteNonQuery();
                                comando.Parameters.Clear();
                            }

                            transacsion.Commit();
                        }

                    }
                    catch (Exception)
                    {
                           
                            transacsion.Rollback();
                    if (connection.State == ConnectionState.Open) connection.Close();

                    }

                }

            }


        }

        public static void InsertarMaterialCvsBDD2(List<SubImpresion> MiLista)
        {


            using (SQLiteConnection connection = ClassConexion.ConexionSqlite())
            {

                connection.Open();

                string trays = ""; 
                foreach (var T in MiLista ) 
                {
                    if (T.Tray.ToString() != string.Empty)

                    {                   
                            if (trays.Contains(T.Tray)==false) trays += T.Tray + "','";

                    }
                    
                }

                if (OrdenesDuplicated(connection,trays)==false)
                
             
                using (SQLiteTransaction transacsion = connection.BeginTransaction())
                {

                    try
                    {


                            string sentencia = "Insert into Tble_Ordenes_Procesadas(Prefijo,Tray,[Sales Order],Hora_Impresion) Values(@Prefijo,@Tray,@Sales_Order,@Hora_Impresion)";
                            

                        using (SQLiteCommand comando = new SQLiteCommand(sentencia, connection))
                        {
                            comando.Transaction = transacsion;
                            comando.CommandType = CommandType.Text;

                            foreach (var H in MiLista.ToArray())
                            {
                                comando.Parameters.AddWithValue("@Prefijo", H.Prefijo);
                                comando.Parameters.AddWithValue("@Tray", H.Tray);
                                comando.Parameters.AddWithValue("@Sales_Order", H.Order);
                                comando.Parameters.Add("@Hora_Impresion", DbType.Date).Value = H.Date_Impresion;
                                comando.ExecuteNonQuery();
                                comando.Parameters.Clear();
                            }

                            transacsion.Commit();
                        }

                    }
                    catch (Exception)
                    {                    
                        transacsion.Rollback();
                      if (connection.State == ConnectionState.Open )  connection.Close();

                    }

                }

            }


        }

        private static Boolean OrdenesDuplicated(SQLiteConnection Miconexion, string array)
        {

            try
            {

                string sentencia = "Select Tray from Tble_Ordenes_Procesadas where Tray in('" + array + "')";

                using (SQLiteCommand comando = new SQLiteCommand(sentencia, Miconexion))
            {

                    comando.CommandType = CommandType.Text;

                using (SQLiteDataReader Reade = comando.ExecuteReader())
                {

                    if (Reade.HasRows) return true; else return false;              

                }

            }


            }
            catch (Exception)
            {
                return false;
            }
           

        }

    }
}

