using ClasesGenerales;
using ManejoDatosAndCarpetas.BusquedaPrefijos;
using ManejoDatosAndCarpetas.ManejoDatosCVS;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Globalization;
using System.IO;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using System.Data;

namespace App_Papeleria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            panel1.Width = 462;
            PanelOrdenes.Height = 0;

        }


        private void ComboPrefijos_DropDown(object sender, EventArgs e)
        {
            try
            {

                ListArchivos.DataSource = null;
                ListArchivos.Items.Clear();

                List<string> Milista = CargarPrefijos.CargarPrefijosCombo();

                ComboPrefijos.Items.Clear();

                foreach (var item in Milista)
                {

                    ComboPrefijos.Items.Add(item);

                }



            }
            catch (Exception error)
            {
           End(error.Message, MessageBoxIcon.Error, "Error");
            }


        }


        private void ComboPrefijos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (TexFecha.Text != string.Empty && TexFecha1.Text != string.Empty)
            {
                try
                {

                    ListArchivos.SelectionMode = SelectionMode.None;
                    ListArchivos.DataSource = ExtraerContenidoCVS.GetArchivos(ComboPrefijos.SelectedItem.ToString(), Convert.ToDateTime(TexFecha.Text), Convert.ToDateTime(TexFecha1.Text));
                    ListArchivos.SelectionMode = SelectionMode.One;

                }
                catch (DirectoryNotFoundException)
                {

                    End("No, se encontro ninguna carpeta con la fecha: " + TexFecha.Text, MessageBoxIcon.Warning, "Link no encontrado");
                    return;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Archivos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;

                }

            }
            else
            {
                End("Campo(s) de Fecha vacio(s), verifiquelos e intentelo de nuevo", MessageBoxIcon.Warning, "Fecha Vacia"); return;
            }

            if (ListArchivos.Items.Count == 0)
            {
                End("No se encontraron archivos dentro del rango de fecha y hora seleccionados", MessageBoxIcon.Information, "Datos Vacios");
            }
        }



        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            TexFecha.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void DateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            TexFecha1.Text = dateTimePicker2.Value.ToShortDateString();
        }



        private void IconPictureBox1_Click(object sender, EventArgs e)
        {

            AumentaDisminuye(panel1, 462, 77);

        }


        private void IconBuscarPrefijo_Click(object sender, EventArgs e)
        {

            try
            {
                label4.Text = "Prefijo A Buscar"; OrdenesAndPrefijo.Text = null;
                byte J = 0;
                string Link = string.Empty;

                string prefijo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Prefijo a Buscar", "Busqueda de Prefijos").Trim().ToUpper();
                OrdenesAndPrefijo.Text = prefijo;

                if (prefijo != string.Empty)
                {

                    while (J < 3 && Link == string.Empty)
                    {

                        Link = ResultadoBuscarPrefijo.GetPrefijo(prefijo, J);
                        J++;
                    }

                    if (Link != string.Empty)
                    {
                        linkPrefijo.Text = Link;
                        End("El Prefijo: " + prefijo + " Fue encontrado", MessageBoxIcon.Information, "Busqueda");
                    }
                    else
                    {

                        linkPrefijo.Text = "No, se encontro el link del prefijo: " + prefijo;

                        End("No, se encontro el link del prefijo: " + prefijo, MessageBoxIcon.Exclamation, "Busqueda de prefijo");

                    }

                }

            }catch(Exception E)
            {
                if(E.Message == "The network path was not found.\r\n")
                    MessageBox.Show("La ruta no fue encontrada.\n" + E.Message, "Exception"); 
                else MessageBox.Show("Ocurrio un error:\n" + E.Message, "Exception");
            }

        }


        private void LinkPrefijo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                linkPrefijo.LinkVisited = true;

                System.Diagnostics.Process.Start(linkPrefijo.Text);
            }
            catch (Exception error)
            {
                End(error.Message, MessageBoxIcon.Error, "Error al Buscar el link");
            }
        }


        private void ListArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "Listado de ordenes";

                if (ListArchivos.SelectedItem != null)
                {
                    
                    GridView1.DataSource = ExtraerContenidoCVS.GetContenidoArchivo(ListArchivos.SelectedItem.ToString(),ComboPrefijos.Text);

                    OrdenesAndPrefijo.Text = null;

                    foreach (DataGridViewRow item in GridView1.Rows) OrdenesAndPrefijo.Text += item.Cells[2].Value.ToString() + ",";

                    End("Proceso Finalizado con exito ", MessageBoxIcon.Information);
                    ListArchivos.SetSelected(ListArchivos.SelectedIndex, false);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }



        private void End(string Mensaje, MessageBoxIcon Icono, string Titulo = "Process completed")
        {
            MessageBox.Show(Mensaje,Titulo, MessageBoxButtons.OK, Icono);

        }

        private async void IButtonHistorial_Click(object sender, EventArgs e)
        {
            try
            {

                OrdenesAndPrefijo.Text = null;
                GridView1.DataSource = null;

                var Array = Task.Run(() => ExtraerContenidoCVS.GetListImpresionesBDDAll(Convert.ToDateTime(TexFecha.Text), Convert.ToDateTime(TexFecha1.Text)).ToArray());

                GridView1.DataSource = await Array;

                if (GridView1.RowCount > 0) End("Proceso Finalizado con exito",MessageBoxIcon.Information);
                else End("No! se encontraron datos, dentro de las fechas establecidas", MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                
                End(ex.Message + "Verifique que los campos de las fechas no esten vacios, o que estas, esten correctas.",MessageBoxIcon.Error, "Error de proceso");

            }
            //ExportExcel();
            AumentaDisminuye(PanelOrdenes, 90, 5);
        }

        private async void ButtonImpresiones_Click(object sender, EventArgs e)
        {

            try
            {

                var Array = new Task<SubImpresion[]>(ExtraerContenidoCVS.GetListImpresionesBDD(Convert.ToDateTime(TexFecha.Text), Convert.ToDateTime(TexFecha1.Text)).ToArray);
                Array.Start();

                OrdenesAndPrefijo.Text = null;
                GridView1.DataSource = null;

                GridView1.DataSource = await Array;

                if (GridView1.RowCount > 0) End("Proceso Finalizado con exito", MessageBoxIcon.Information);
                else End("No! se encontraron datos, dentro de las fechas establecidas", MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                End(ex.Message + "Verifique que los campos de las fechas no esten vacios, o que estas, esten correctas.",MessageBoxIcon.Error,"Error de proceso");

            }
            AumentaDisminuye(PanelOrdenes, 90, 5);
        }


        private void IconBGetData_MouseHover(object sender, EventArgs e)
        { }

        private void IconBGetData_Click(object sender, EventArgs e)
        {
            AumentaDisminuye(PanelOrdenes, 90, 5);

            PanelOrdenes.Width = 173;
            IButtonHistorial.Width = 173;
            ButtonImpresiones.Width = 173;

        }


        public void AumentaDisminuye(Panel Mipanel, int Altura, int Altura2)
        {
            int HEIGHT = Mipanel.Height;

            if (Mipanel.Height == Altura || Mipanel.Width == Altura)
            {

                while (true)
                {
                    //Thread.Sleep(10);
                    if (HEIGHT == Altura) Mipanel.Height -= Altura2; else Mipanel.Width -= Altura2;
                    if (Mipanel.Height == 0 || Mipanel.Width == 0) break;

                }

            }
            else if (Mipanel.Height == 0 || Mipanel.Width == 0)
            {

                while (true)
                {

                    if (HEIGHT == 0) Mipanel.Height += Altura2; else Mipanel.Width += Altura2;
                    if (Mipanel.Height == Altura || Mipanel.Width == Altura) break;

                }


            }

        }

        public void ExportExcel()
        {

            string path = @"C:\Users\anton\OneDrive\Escritorio\prueva.xlsx";

            SLDocument Miexcel = new SLDocument();

          using(DataTable Tabla = new DataTable()){

                foreach (DataGridViewColumn column in GridView1.Columns)
                {

                    Tabla.Columns.Add(column.HeaderText);


                }

                foreach (DataGridViewRow column in GridView1.Rows)
                {

                    Tabla.Rows.Add(column.Cells[0].Value, column.Cells[1].Value, column.Cells[2].Value, column.Cells[3].Value,
                        column.Cells[4].Value, column.Cells[5].Value, column.Cells[6].Value, column.Cells[7].Value);


                }


                Miexcel.ImportDataTable(1, 1, Tabla, true);

                Miexcel.SaveAs(path);

            }


        }

        
    }
}
