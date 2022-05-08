

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using AccesoBDDatos.AgregarBuscarPrefijoNew;
using ClasesGenerales;

namespace AccesoBDDatos
{
    public class ManejoCvsDisponibles
    {

        private string RutaFile;


        public void GetRuta(String Prefijo)
        {

            RutaFile = InsertarPrefijo.ExtraerLink(Prefijo);

        }


        public DataTable ExtraerContenidoCvs(string NameArchivo,string prefijo)
        {

            using (DataTable Tabla = new DataTable())
            {

                if (RutaFile != string.Empty)
                {

                    using (FileStream Archivo1 = File.Open(RutaFile + @"\" + NameArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader Archivo = new StreamReader(Archivo1))
                        {

                            int linea = 0; DateTime DateHourImpresion = DateTime.Now;

                            for (int I = 0; I < 9; I++)
                            {
                                Tabla.Columns.Add();
                            }

                            while (Archivo.Peek() != -1)
                            {

                                var Filas = Archivo.ReadLine().Split(',');
                                if (linea != 0) Tabla.Rows.Add(prefijo,Filas[0], Filas[7], Filas[8], Filas[9], Filas[10], Filas[11], Filas[13], DateHourImpresion);

                                linea++;
                            }

                        }
                      
                    }
                }

                if (Tabla.Rows.Count > 0) InsertarExtraerDatosCvsBBdatos.InsertarMaterialCvsBDD(Tabla);

                return Tabla;

            }

        }


        public List<string> BuscarArchivosCvs(string Prefijo, DateTime FechaDnicio, DateTime FechaHfinal)
        {

            GetRuta(Prefijo);

            List<string> ListaArchivos = new List<string>();

            if (RutaFile != string.Empty)
            {
                RutaFile += @"\" + FechaDnicio.ToString("MMddyy");

                foreach (var file in Directory.GetFiles(RutaFile, "*.csv", SearchOption.TopDirectoryOnly))
                {
                    FileInfo Archivo = new FileInfo(file);

                    if (Archivo.LastWriteTime >= FechaDnicio && Archivo.LastWriteTime <= FechaHfinal)
                        ListaArchivos.Add(Archivo.Name);

                }

                return ListaArchivos;

            }
            return null;

        }

    }


}
