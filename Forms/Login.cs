using PROG2EVA1javierNievesDanielTorrealba.Class;
using PROG2EVA1javierNievesDanielTorrealba.Forms;
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
        private List<Vigia> acciones = new List<Vigia>();

        private static bool valido;
        private static string digito;

        //array de digitos constantes para el algoritmo
        private static readonly int[] digitosAlgoritmo = { 3, 2, 7, 6, 5, 4, 3, 2 };

        private DataTable dataTable;

        private static readonly string tablaPERFILES = "PERFILES";
        private static readonly string tablaACCIONES = "ACCIONES";

        private SqlConnection conexion = new SQLClass().Conexion;

        public Login()
        {
            InitializeComponent();

            if (!TableExists(tablaPERFILES)) CreateTablePERFILES();
            if (!TableExists(tablaACCIONES)) CreateTableACCIONES();
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
        private DataTable GetDataTable(string consulta, SqlConnection conexion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        private void CreateTablePERFILES()
        {
            string CREATE = $"create table {tablaPERFILES} (rut nvarchar(10) not null primary key,nombre nvarchar(30) not null, apPat nvarchar(30) not null, apMat nvarchar(30) not null, edad int not null, clave nvarchar(13) not null, Nivel int not null);";

            string INIT = $"insert into {tablaPERFILES} (rut, nombre, apPat, apMat, edad, clave, Nivel) values ('111111111', 'LUIS', 'YAÑEZ', 'CARREÑO', 49, 'LYC11111111-1', 1);";

            conexion.Open();
            dataTable = GetDataTable(CREATE, conexion);
            conexion.Close();

            conexion.Open();
            dataTable = GetDataTable(INIT, conexion);
            conexion.Close();

        }
        private void CreateTableACCIONES()
        {
            string CREATE = $"create table {tablaACCIONES} (num int identity(1,1) primary key not null,clave nvarchar(13) not null,rut nvarchar(10) not null, iniciosesion nvarchar(30) not null, finsesion nvarchar(30) not null, accion nvarchar(30) not null, accionf nvarchar(30) not null);";

            string INIT = $"insert into {tablaACCIONES} (clave,rut,iniciosesion,finsesion,accion,accionf) values ('LYC11111111-1','111111111','01/01/0001 12:00:00 a. m.','01/01/0001 12:00:00 a. m.','Login Exitoso','01/01/0001 12:00:00 a. m.');";

            conexion.Open();
            dataTable = GetDataTable(CREATE, conexion);
            conexion.Close();

            conexion.Open();
            dataTable = GetDataTable(INIT, conexion);
            conexion.Close();

        }
        private void RunMenuUser(DataRow data)
        {
            Menu menu = new Menu(data, acciones, false);
            menu.Show();
            this.Hide();
        }
        private void RunMenuAdmin(DataRow data)
        {
            Menu menu = new Menu(data, acciones, true);
            menu.Show();
            this.Hide();
        }
        private bool TableExists(string tableName)
        {
            conexion.Open();
            string consulta = $"select * from INFORMATION_SCHEMA.TABLES;";
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();

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



        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (!valido || !ValidarRut(textBoxRut.Text) || textBoxNombre.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre, RUT y contraseña validos para poder jugar");
                acciones.Add(new Vigia(textBoxRut.Text, "Login Fallido"));
                return;
            }

            string rutIngresado = textBoxRut.Text.Replace(".", "").Replace("-", "").ToUpper();
            string passIngresado = textBoxPass.Text;

            conexion.Open();
            dataTable = GetDataTable($"select * from {tablaPERFILES};", conexion);
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
                        acciones.Add(new Vigia(rutIngresado));
                        RunMenuUser(row);
                    }
                    else if (nivelBD == 1)
                    {
                        rutEncontrado = true;
                        acciones.Add(new Vigia(rutIngresado));
                        RunMenuAdmin(row);
                    }
                }
                else if (rutBD == rutIngresado && passBD != passIngresado)
                {
                    rutEncontrado = true;
                    MessageBox.Show("Contraseña incorrecta.");
                    acciones.Add(new Vigia(rutIngresado, "Login Fallido"));
                }
            }

            if (!rutEncontrado)
            {
                MessageBox.Show("RUT no registrado.");
                acciones.Add(new Vigia(textBoxRut.Text, "Login Fallido"));
            }
        }
        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {
            string rut = textBoxRut.Text.Trim();
            rut = rut.Replace(".", "").Replace("-", "").ToUpper();
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
        private void textBoxRut_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) btnEnter_Click(sender, e);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void linkLabelCreditos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }
    }
}
