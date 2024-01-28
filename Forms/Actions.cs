using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PROG2EVA1javierNievesDanielTorrealba.Class;
using PROG2EVA1javierNievesDanielTorrealba.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba.Forms
{
    public partial class Actions : Form
    {

        private readonly string nombre;
        private readonly string rut;
        private string clave;

        //Se utilizará para separar al alcance en las consultas
        private readonly int nivel;

        private List<Vigia> vigia;
        private DataTable datatable;

        private static readonly string tableName = "ACCIONES";
        private const string file = @"C:\\TXTS\\VIGIADANIELTORREALBA.csv";

        private SqlConnection conexion = new SQLClass().Conexion;

        public Actions(string nombre, string clave, string rut, object logs, int nivel)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.rut = rut;
            this.clave = clave;
            this.nivel = nivel;

            vigia = (List<Vigia>)logs;
        }

        private string GetClave(string rut)
        {
            if (rut == "") return "";

            string consulta = $"select * from PERFILES where rut ='{rut}'";

            conexion.Open();
            datatable = GetDataTable(consulta, conexion);
            conexion.Close();

            DataRow row = datatable.Rows[0];

            return row[5].ToString();

        }
        private void LimpiarTabla(string tableName)
        {

            string DROP = $"drop table {tableName}";

            string CREATE = $"create table {tableName} (num int identity(1,1) primary key not null,clave nvarchar(13) not null,rut nvarchar(10) not null, iniciosesion nvarchar(30) not null, finsesion nvarchar(30) not null, accion nvarchar(30) not null, accionf nvarchar(30) not null);";

            string INIT = $"insert into {tableName} (clave,rut,iniciosesion,finsesion,accion,accionf) values ('LYC11111111-1','111111111','01/01/0001 12:00:00 a. m.','01/01/0001 12:00:00 a. m.','Login Exitoso','01/01/0001 12:00:00 a. m.');";

            conexion.Open();
            datatable = GetDataTable(DROP, conexion);
            datatable = GetDataTable(CREATE, conexion);
            datatable = GetDataTable(INIT, conexion);
            conexion.Close();
        }
        private DataTable GetTablaSegunNivel(int nivel)
        {
            string consulta;

            if (nivel == 1) consulta = $"select * from {tableName}";
            else consulta = $"select * from {tableName} where clave ='{clave}'";

            conexion.Open();
            datatable = GetDataTable(consulta, conexion);
            conexion.Close();

            return datatable;
        }
        private DataTable GetDatosSegunRango(DateTime fechaDesde, DateTime fechaHasta)
        {
            string consultaporc = $"SELECT num,iniciosesion,finsesion,accionf FROM {tableName};";

            conexion.Open();
            datatable = GetDataTable(consultaporc, conexion);
            conexion.Close();

            List<int> indices = new List<int>();

            foreach (DataRow row in datatable.Rows)
            {

                string inicioBD = row[1].ToString();
                string finBD = row[2].ToString();
                string accionfBD = row[3].ToString();

                string inicioLimpioBD = inicioBD.Length >= 16 ? inicioBD.Substring(0, 16) : inicioBD;
                string finLimpioBD = finBD.Length >= 16 ? finBD.Substring(0, 16) : finBD;
                string accionfLimpioBD = accionfBD.Length >= 16 ? accionfBD.Substring(0, 16) : accionfBD;

                DateTime fechaInicioBD = Convert.ToDateTime(inicioLimpioBD);
                DateTime fechaFinBD = Convert.ToDateTime(finLimpioBD);
                DateTime fechaAccionBD = Convert.ToDateTime(accionfLimpioBD);

                if (fechaInicioBD >= fechaDesde && fechaInicioBD <= fechaHasta)
                {
                    indices.Add(int.Parse(row[0].ToString()));
                }
                else if (fechaFinBD >= fechaDesde && fechaFinBD <= fechaHasta)
                {
                    indices.Add(int.Parse(row[0].ToString()));
                }
                else if (fechaAccionBD >= fechaDesde && fechaAccionBD <= fechaHasta)
                {
                    indices.Add(int.Parse(row[0].ToString()));
                }
            }

            if (indices.Count == 0) return null;

            if (nivel == 1)
                consultaporc = $"SELECT * FROM {tableName} where num between {indices[0]} and {indices[indices.Count - 1]};";
            else
                consultaporc = $"SELECT * FROM {tableName} where clave ='{clave}' and num between {indices[0]} and {indices[indices.Count - 1]};";

            conexion.Open();
            datatable = GetDataTable(consultaporc, conexion);
            conexion.Close();

            return datatable;
        }
        private DataTable GetDataTable(string consulta, SqlConnection conexion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }


        private void Actions_Load(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = GetTablaSegunNivel(nivel);
        }
        private void Actions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnTraspaso_Click(object sender, EventArgs e)
        {
            LimpiarTabla(tableName);

            string[] archivoCompleto = File.ReadAllLines(file);

            for (int i = 0; i < archivoCompleto.Length; i++)
            {
                string[] datos = archivoCompleto[i].Split(',');

                string clave = GetClave(datos[0]);

                string insert = $"insert into {tableName} (clave,rut,iniciosesion,finsesion,accion,accionf) values ('{clave}','{datos[0]}','{datos[1]}','{datos[2]}','{datos[3]}','{datos[4]}')";

                conexion.Open();
                datatable = GetDataTable(insert, conexion);
                conexion.Close();
            }

            dgvAdmin.DataSource = GetTablaSegunNivel(nivel);
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            DateTime fechaInicioConvertida = DTPickerDesde.Value;
            DateTime fechaFinConvertida = DTPickerHasta.Value;

            datatable = GetDatosSegunRango(fechaInicioConvertida, fechaFinConvertida);

            if (datatable == null)
            {
                MessageBox.Show("No se encontraron datos en el rango de fechas seleccionado");
                return;
            }

            dgvAdmin.DataSource = datatable;

        }
        private void btnFrecuencia_Click(object sender, EventArgs e)
        {
            //Actualizar la vista de la tabla segun el nivel
            datatable = GetTablaSegunNivel(nivel);

            int jugadores1_2 = 0;
            int jugadores2_3 = 0;
            int jugadores3_4 = 0;
            int totalJugadores = 0;

            foreach (DataRow row in datatable.Rows)
            {
                string aperturaStr = row[3].ToString().Trim();
                string cierreStr = row[4].ToString().Trim();

                aperturaStr = aperturaStr.Length >= 16 ? aperturaStr.Substring(0, 16) : aperturaStr;
                cierreStr = cierreStr.Length >= 16 ? cierreStr.Substring(0, 16) : cierreStr;

                DateTime apertura = Convert.ToDateTime(aperturaStr);
                DateTime cierre = Convert.ToDateTime(cierreStr);

                double duracionHoras = (cierre - apertura).TotalHours;

                if (duracionHoras >= 0 && duracionHoras < 2)
                {
                    jugadores1_2++;
                }
                else if (duracionHoras >= 2 && duracionHoras < 3)
                {
                    jugadores2_3++;
                }
                else if (duracionHoras >= 3 && duracionHoras < 4)
                {
                    jugadores3_4++;
                }

                totalJugadores++;
            }

            double porcentaje1_2 = (double)jugadores1_2 / totalJugadores * 100;
            double porcentaje2_3 = (double)jugadores2_3 / totalJugadores * 100;
            double porcentaje3_4 = (double)jugadores3_4 / totalJugadores * 100;
            double porcentajeTotal = (double)totalJugadores / totalJugadores * 100;
            // Construir el mensaje para el MessageBox

            string mensaje = $"Intervalo\t    Sesiones\tPorcentaje\n";


            mensaje += $"1-2 horas\t{jugadores1_2}\t\t{porcentaje1_2:F2}%\n";
            mensaje += $"2-3 horas\t{jugadores2_3}\t\t{porcentaje2_3:F2}%\n";
            mensaje += $"3-4 horas\t{jugadores3_4}\t\t{porcentaje3_4:F2}%\n";
            mensaje += $"Total\t\t{totalJugadores}\t\t{porcentajeTotal:F2}%";

            // Mostrar el MessageBox
            MessageBox.Show(mensaje, "Tabla de Frecuencias", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            datatable = GetTablaSegunNivel(nivel);

            using (XLWorkbook libro = new XLWorkbook())
            {
                Bitmap logo = Resources.logo;
                Stream stream = new MemoryStream();

                logo.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Position = 0;

                IXLWorksheet worksheets = libro.Worksheets.Add(datatable, "Datos");

                var picture = worksheets.AddPicture(stream).MoveTo(worksheets.Cell("H1"));

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                save.Title = "Guardar como archivo de Excel";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    libro.SaveAs(save.FileName);
                    MessageBox.Show("La Exportacion a sido Exitosa");
                }
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos PDF (.pdf)|.pdf";
            save.Title = "Guardar como archivo PDF";

            if (save.ShowDialog() != DialogResult.OK) return;

            FileStream streamBDD = new FileStream(save.FileName, FileMode.Create);

            Document file = new Document(PageSize.LETTER, 4, 4, 6, 6);

            PdfWriter PDFWriter = PdfWriter.GetInstance(file, streamBDD);

            PDFWriter.Open();
            file.Open();

            file.AddAuthor("Golpea al topo");
            file.AddTitle("Exportado");

            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            Bitmap pblogo = new Bitmap(Resources.logo, new Size(80, 80));
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(pblogo, System.Drawing.Imaging.ImageFormat.Png);

            file.Add(imagen);
            file.Add(Chunk.NEWLINE);

            PdfPTable TablaAcciones = new PdfPTable(7);
            TablaAcciones.WidthPercentage = 100;

            datatable = GetTablaSegunNivel(nivel);

            foreach (DataRow row in datatable.Rows)
            {
                for (int i = 0; i < 7; i++)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(row[i].ToString(), standarFont));

                    celda.BorderWidth = 0;
                    celda.BorderWidthBottom = 0.60f;

                    TablaAcciones.AddCell(celda);
                }

                TablaAcciones.CompleteRow();
            }

            file.Add(TablaAcciones);

            file.Close();
            PDFWriter.Close();

            MessageBox.Show("Reporte listo \n Grande la U");
        }



        private void btnJugar_Click(object sender, EventArgs e)
        {
            Game game = new Game(nombre.ToUpper(), vigia, rut);
            game.Show();
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DTPickerDesde.Value = DateTime.Now;
            DTPickerHasta.Value = DateTime.Now;
            Actions_Load(sender, e);
        }


    }
}
