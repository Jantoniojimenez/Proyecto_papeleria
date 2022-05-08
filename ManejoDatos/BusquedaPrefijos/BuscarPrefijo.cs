using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AccesoBDDatos.AgregarBuscarPrefijoNew;

namespace ManejoDatosAndCarpetas.BusquedaPrefijos
{
    
    public class ResultadoBuscarPrefijo
    {


        public static String GetPrefijo(string Prefijo, Byte DiasAnteriores)
    {
            //string path = @"C:\Users\anton\OneDrive\Himnario_Adventista\";
            string path = @"\\PRMX2DATA\mx2_Fabdata\";

            return BuscarPrefijo.BusquedaDeprefijos(Prefijo, path, DiasAnteriores);

    }


    }

    
}
