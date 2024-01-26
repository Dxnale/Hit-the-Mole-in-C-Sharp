using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        private static readonly string conectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GIT\\PROG2EVA1javierNievesDanielTorrealba\\p2bdd.mdf;Integrated Security=True";
        private static readonly string tableName = "ACCIONES";
        private const string file = @"C:\\TXTS\\VIGIADANIELTORREALBA.csv";

        private SqlConnection conexion = new SqlConnection(conectionString);

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
        private void MostrarTablaSegunNivel(int nivel)
        {
            string consulta;

            if (nivel == 1) consulta = $"select * from {tableName}";
            else consulta = $"select * from {tableName} where clave ='{clave}'";

            conexion.Open();
            dgvAdmin.DataSource = GetDataTable(consulta, conexion);
            conexion.Close();
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
                DateTime fechaInicioBD = Convert.ToDateTime(row[1]);
                DateTime fechaFinBD = Convert.ToDateTime(row[2]);
                DateTime fechaAccionBD = Convert.ToDateTime(row[3]);

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
            MostrarTablaSegunNivel(nivel);
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

            MostrarTablaSegunNivel(nivel);
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
        private void Actions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFrecuencia_Click(object sender, EventArgs e)
        {
            //Actualizar la vista de la tabla segun el nivel
            MostrarTablaSegunNivel(nivel);


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //Exportar los datos del datagridview a un archivo excel
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            //Exportar los datos del datagridview a un archivo pdf
        }
    }
}
