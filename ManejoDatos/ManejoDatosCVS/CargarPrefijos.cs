using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBDDatos;

namespace ManejoDatosAndCarpetas.ManejoDatosCVS
{
    public class CargarPrefijos
    {

            public static List<string> CargarPrefijosCombo()
            {
                return ClassExtraerDatos.ExtraerPrefijosBBD();

            }


    }
}
