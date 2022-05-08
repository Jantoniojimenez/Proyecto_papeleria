using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccesoBDDatos.AgregarBuscarPrefijoNew
{
    public class BuscarPrefijo
    {
        
      //private static readonly string Ruta = @"C:\Users\anton\OneDrive\Himnario_Adventista\";//string Ruta = @"\\PRMX2DATA\mx2_Fabdata\";
      private static String LinkPrefijo;
      private static string Prefijo=String.Empty; 

        public static string BusquedaDeprefijos(string prefijo,string patth, Byte DiasAnteriores)
        {
            Prefijo = prefijo;
            LinkPrefijo = string.Empty;
            string Link = @"\dp_backup\" + DateTime.Today.AddDays(-DiasAnteriores).ToString("MMddyy");

            if (prefijo.Trim() != string.Empty)
            {
                foreach (var Subcarpta in Directory.GetDirectories(patth))
                {
               
                        foreach (var Subcarpta2 in Directory.GetDirectories(Subcarpta))
                        {

                            if (Directory.Exists(Subcarpta2 + Link)) BuscarFiles(Subcarpta2 + Link);

                            if (LinkPrefijo != string.Empty) return LinkPrefijo;

                        }
                               

                }

            }

            return LinkPrefijo;
        }


        static void BuscarFiles(string Buscar_archivos)
        {

            foreach (var file in Directory.GetFiles(Buscar_archivos, "*.txt", SearchOption.TopDirectoryOnly))
            {

                FileInfo archivo = new FileInfo(file);

                
                if (archivo.Name.Contains(Prefijo))
                {

                    var J = archivo.Name.LastIndexOf('_')+1;

                    if (archivo.Name.Substring(J, Prefijo.Length) == Prefijo && Char.IsNumber(archivo.Name.Substring(J, Prefijo.Length + 1), Prefijo.Length))
                    {

                        LinkPrefijo = Buscar_archivos;

                        InsertarPrefijo.InsertarDatos(Prefijo, Buscar_archivos.Substring(0, Buscar_archivos.Length-7));

                        return;

                    }
                }

            }

        }

    }
}