using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Login : Form
    {
        private List<CLASEEVALUA2danielTorrealba> logins = new List<CLASEEVALUA2danielTorrealba>();

        private static bool valido;
        private static string digito;

        //array de digitos constantes para el algoritmo
        private static readonly int[] digitosAlgoritmo = { 3, 2, 7, 6, 5, 4, 3, 2 };

        private DataTable dataTable;


        private readonly string conectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GIT\\PROG2EVA1javierNievesDanielTorrealba\\p2bdd.mdf;Integrated Security=True";

        private static readonly string tableName = "danielTorrealba_PERFILES";

        public Login()
        {
            InitializeComponent();
        }
        public static bool ValidarRut(string Rut)
        {
            digito = null; //Resetea el digito verificador

            Rut = Rut.Replace(".", "").Replace("-", "").ToUpper(); //quita puntos y guiones y pasa a mayusculas si el rut es menor a 9 digitos agrega un 0 al inicio

            if (Rut.Length <= 2 || Rut.Length > 9) return false; //si el rut no es del largo correcto corta la ejecucion

            Rut = Rut.Length < 9 ? "0" + Rut : Rut; //si el rut es menor a 9 digitos agrega un 0 al inicio

            digito = ValidarDigito(Rut);

            return Rut[Rut.Length - 1].ToString().Equals(digito);

        }
        public static string ValidarDigito(string Rut)
        {
            int suma = 0;

            for (int i = 0; i < Rut.Length - 1; i++)
            {
                suma += digitosAlgoritmo[i] * Int32.Parse(Rut[i].ToString()); //multiplica cada digito por el valor del array de digitos constantes y lo suma a la variable suma
            }

            int residuo = suma % 11;
            int resultado = 11 - residuo;

            return resultado == 10 ? "K" : resultado == 11 ? "0" : resultado.ToString(); //si el resultado es 10 retorna K, si es 11 retorna 0, si no simplemente retorna el digito resultante
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!TableExists(tableName))
            {
                MessageBox.Show("Aún no hay una tabla en tu base de datos.");
                return;
            }

            if (!valido || !ValidarRut(textBoxRut.Text) || textBoxNombre.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre, RUT y contraseña validos para poder jugar");
                logins.Add(new CLASEEVALUA2danielTorrealba(textBoxRut.Text, "Login Fallido"));
                return;
            }

            string rutIngresado = textBoxRut.Text.Replace(".", "").Replace("-", "").ToUpper();
            string passIngresado = textBoxPass.Text.ToUpper();

            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable($"select * from {tableName};", conexion);
            conexion.Close();
            bool rutEncontrado = false;

            foreach (DataRow row in dataTable.Rows)
            {
                string rutBD = row[0].ToString();
                string passBD = row[5].ToString();
                int nivelBD = int.Parse(row[6].ToString());

                if (rutBD == rutIngresado && passBD == passIngresado)
                {
                    if (nivelBD == 2)
                    {
                        rutEncontrado = true;
                        logins.Add(new CLASEEVALUA2danielTorrealba(textBoxRut.Text, "Login Exitoso"));
                        RunGame();
                    }
                    else if (nivelBD == 1)
                    {
                        rutEncontrado = true;
                        RunPanel();
                        MessageBox.Show("Bienvenido administrador.");
                    }
                }
                else if (rutBD == rutIngresado && passBD != passIngresado)
                {
                    rutEncontrado = true;
                    MessageBox.Show("Contraseña incorrecta.");
                    logins.Add(new CLASEEVALUA2danielTorrealba(textBoxRut.Text, "Login Fallido"));
                }
            }

            if (!rutEncontrado)
            {
                MessageBox.Show("RUT no registrado.");
                logins.Add(new CLASEEVALUA2danielTorrealba(textBoxRut.Text, "Login Fallido"));
            }
        }
        private void RunPanel()
        {
            PanelAdmin panel = new PanelAdmin(textBoxNombre.Text.ToUpper(),logins, textBoxRut.Text.ToUpper());
            panel.Show();
            this.Hide();
        }
        public void RunGame()
        {
            Game game = new Game(textBoxNombre.Text.ToUpper(), logins, textBoxRut.Text.ToUpper());
            game.Show();
            this.Hide();
        }
        private void textBoxRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida que la tecla ingresada sea un numero, o una k o una K o un "-" o una tecla de control (ej: borrar)
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'k' || e.KeyChar == 'K' || e.KeyChar == '-' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEnter_Click(sender, e);
            }
        }
        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {
            string rut = textBoxRut.Text.Trim();
            rut = rut.Replace(".", "").Replace("-", "").ToUpper();
            //valida que el rut tenga solo numeros y una k al final (anti-copypaste)
            valido = Regex.IsMatch(rut, @"^\d{1,10}[kK]?$");

            resultado.ForeColor = System.Drawing.Color.White;
            resultado.Text = "Ingrese RUT";

            if (valido && ValidarRut(rut))
            {
                resultado.ForeColor = System.Drawing.Color.SpringGreen;
                resultado.Text = "VALIDO";
            }
            else if (digito != null && textBoxRut.Text.Length > 7)
            {
                resultado.ForeColor = System.Drawing.Color.White;
                resultado.Text = ($" DV: {digito}");
            }
        }
        private DataTable GetDataTable(string consulta, SqlConnection conexion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            if (!TableExists(tableName))
            {
                CreateTable();
                MessageBox.Show("La tabla se ha creado correctamente.");
            }
            else
            {
                MessageBox.Show("La tabla ya existe en la base de datos.");
            }
        }
        private bool TableExists(string tableName)
        {
            SqlConnection connection = new SqlConnection(conectionString);
            connection.Open();
            string consulta = $"select * from INFORMATION_SCHEMA.TABLES;";
            dataTable = GetDataTable(consulta, connection);
            connection.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[2].ToString() == tableName)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        private void CreateTable()
        {
            using (SqlConnection conexion = new SqlConnection(conectionString))
            {
                string consultaCreate = $"create table {tableName} (rut nvarchar(10) not null primary key,nombre nvarchar(30) not null, apPat nvarchar(30) not null, apMat nvarchar(30) not null, edad int not null, clave nvarchar(13) not null, Nivel int not null);";

                string insertInit = $"insert into {tableName} (rut, nombre, apPat, apMat, edad, clave, Nivel) values ('111111111', 'LUIS', 'YAÑEZ', 'CARREÑO', 49, 'LYC11111111-1', 1);";

                conexion.Open();
                dataTable = GetDataTable(consultaCreate, conexion);
                conexion.Close();

                conexion.Open();
                dataTable = GetDataTable(insertInit, conexion);
                conexion.Close();
            }
        }
        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEnter_Click(sender, e);
            }
        }
    }
}
