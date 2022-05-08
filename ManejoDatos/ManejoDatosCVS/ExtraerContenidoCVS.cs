using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBDDatos;
using ClasesGenerales;

namespace ManejoDatosAndCarpetas.ManejoDatosCVS
{

    public class ExtraerContenidoCVS
    {

        private static readonly ManejoCvsDisponibles MiListaArchivos = new ManejoCvsDisponibles();

        public static List<string> GetArchivos(string Prefijo, DateTime FechaInicio, DateTime FechaFinal)
        {

            return MiListaArchivos.BuscarArchivosCvs(Prefijo, FechaInicio, FechaFinal);

        }

        public static List<SubImpresion> GetContenidoArchivo(string NameArchivo, string prefijo)
        {

            using (DataTable Tabla = MiListaArchivos.ExtraerContenidoCvs(NameArchivo,prefijo))
            {


                List<SubImpresion> Impresion = new List<SubImpresion>();

                foreach (DataRow Row in Tabla.Rows)
                {

                    var objeto = new SubImpresion()
                    {
                        Prefijo = Row.ItemArray.First().ToString(),
                        Tray = Row.ItemArray.ElementAt(1).ToString(),
                        Order = Row.ItemArray.ElementAt(7).ToString(),
                        Date_Impresion = Convert.ToDateTime(Row.ItemArray.Last().ToString())

                    };

                    Impresion.Add(objeto);

                }

                var Columnas = (from I in Impresion group I by new {I.Prefijo, I.Tray, I.Order, I.Date_Impresion } into H select new SubImpresion {

                    Prefijo = H.Key.Prefijo,
                    Tray = H.Key.Tray,
                    Order = H.Key.Order,
                    Date_Impresion = H.Key.Date_Impresion

                }).OrderBy(item => item.Tray).GroupBy(x => x.Order)
                .Select(item => item.First()).ToList(); 


                InsertarExtraerDatosCvsBBdatos.InsertarMaterialCvsBDD2(Columnas);

                return Columnas;

            }

        }


        public static SubImpresion[] GetListImpresionesBDD(DateTime DateStar, DateTime DateEnd)
        {

            var Milist = InsertarExtraerDatosCvsBBdatos.GetImprecionesBDD2(DateStar, DateEnd);

            return Milist.ToArray();
        }

        public static Impresion[] GetListImpresionesBDDAll(DateTime DateStar, DateTime DateEnd)
        { 
                var Mitabla = InsertarExtraerDatosCvsBBdatos.GetImprecionesBDD(DateStar, DateEnd);

                return Mitabla.ToArray();

         }

           
        }


    }
  


