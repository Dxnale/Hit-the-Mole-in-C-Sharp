using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static PROG2EVA1javierNievesDanielTorrealba.Login;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class PanelAdmin : Form
    {
        private readonly string username;
        private readonly string userRut;
        private List<CLASEEVALUA2danielTorrealba> logins;

        private DataTable dataTable;
        private readonly string conectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GIT\\PROG2EVA1javierNievesDanielTorrealba\\p2bdd.mdf;Integrated Security=True";
        private static readonly string tableName = "danielTorrealba_PERFILES";

        public PanelAdmin(string username,object logs, string userRut)
        {
            this.username = username;
            this.userRut = userRut;
            logins = (List<CLASEEVALUA2danielTorrealba>)logs;

            InitializeComponent();
        }



        private DataTable GetDataTable(string consulta, SqlConnection conexion)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        private string ValidadorRUT(string rut)
        {
            rut = rut.Replace(".", "").Replace("-", "").ToUpper();
            bool rutValido = Regex.IsMatch(rut, @"^\d{1,10}[kK]?$");

            if (!rutValido)
            {
                MessageBox.Show("El rut ingresado contiene digitos erroneos");
                return null;
            }

            rutValido = ValidarRut(rut);

            if (!rutValido)
            {
                MessageBox.Show("El rut ingresado no es valido");
                return null;
            }

            return rut;
        }
        private string GenerarClave(string nombre, string apPat, string apMat, string rut)
        {
            char n = nombre[0];
            char ap = apPat[0];
            char am = apMat[0];
            string rutSinDigito = rut.Substring(0, rut.Length - 1);
            string digito = rut.Substring(rut.Length - 1, 1);

            return $"{n}{ap}{am}{rutSinDigito}-{digito}";
        }
        private bool ValidarCampos()
        {
            if (textBoxNombreAdd.Text == "" || textBoxApPatAdd.Text == "" || textBoxApMatAdd.Text == "" || textBoxEdadAdd.Text == "" || textBoxNivelAdd.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios");
                return false;
            }

            foreach (char c in textBoxEdadAdd.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("La edad ingresada contiene caracteres no validos");
                    return false;
                }
            }

            foreach (char c in textBoxNivelAdd.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("El nivel ingresado contiene caracteres no validos");
                    return false;
                }

                if (c != '1' && c != '2')
                {
                    MessageBox.Show("El nivel ingresado no es valido");
                    return false;
                }
            }

            if (textBoxRutAdd.Text.Length > 10)
            {
                MessageBox.Show("El rut ingresado es demasiado largo");
                return false;
            }

            if (textBoxNombreAdd.Text.Length > 30)
            {
                MessageBox.Show("El nombre ingresado es demasiado largo");
                return false;
            }

            if (textBoxApPatAdd.Text.Length > 30)
            {
                MessageBox.Show("El apellido paterno ingresado es demasiado largo");
                return false;
            }

            if (textBoxApMatAdd.Text.Length > 30)
            {
                MessageBox.Show("El apellido materno ingresado es demasiado largo");
                return false;
            }

            if (textBoxEdadAdd.Text.Length > 3)
            {
                MessageBox.Show("La edad ingresada es demasiado larga");
                return false;
            }

            if (textBoxNivelAdd.Text.Length > 1)
            {
                MessageBox.Show("El nivel ingresado es demasiado largo");
                return false;
            }

            return true;
        }
        private string rutExiste(string rut)
        {
            string consulta = $"select * from {tableName} where rut = '{rut}'";
            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();

            bool existe = false;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[0].ToString() == rut) existe = true;
            }

            if (!existe) return null;

            return rut;
        }



        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            string consulta = $"SELECT * FROM {tableName}";
            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();
            dgvAdmin.DataSource = dataTable;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string rut = ValidadorRUT(textBoxRutEliminar.Text);

            if (rut == null) return;

            if (rutExiste(rut) == null)
            {
                MessageBox.Show("El rut ingresado no se ha encontrado");
                return;
            }

            string consulta = $"delete from {tableName} where rut = '{rut}'";
            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();

            MessageBox.Show("Usuario eliminado correctamente");

            textBoxRutEliminar.Text = "";

            PanelAdmin_Load(sender, e);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string rut = ValidadorRUT(textBoxRutConsultar.Text);

            if (rut == null) return;

            if (rutExiste(rut) == null)
            {
                MessageBox.Show("El rut ingresado no se ha encontrado");
                return;
            }

            string consulta = $"select * from {tableName} where rut = '{rut}'";
            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();

            dgvAdmin.DataSource = dataTable;

            textBoxRutAdd.Text = dataTable.Rows[0][0].ToString();
            textBoxNombreAdd.Text = dataTable.Rows[0][1].ToString();
            textBoxApPatAdd.Text = dataTable.Rows[0][2].ToString();
            textBoxApMatAdd.Text = dataTable.Rows[0][3].ToString();
            textBoxEdadAdd.Text = dataTable.Rows[0][4].ToString();
            textBoxNivelAdd.Text = dataTable.Rows[0][6].ToString();
            textBoxRutConsultar.Text = "";

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string rut = ValidadorRUT(textBoxRutAdd.Text);

            if (rut == null) return;

            if (!ValidarCampos()) return;

            string rutYaExiste = rutExiste(rut);

            if (rut == rutYaExiste)
            {
                MessageBox.Show("El rut ingresado ya existe");
                return;
            }

            string nombre = textBoxNombreAdd.Text;
            string apPat = textBoxApPatAdd.Text;
            string apMat = textBoxApMatAdd.Text;
            string edad = textBoxEdadAdd.Text;
            string nivel = textBoxNivelAdd.Text;
            string clave = GenerarClave(nombre, apPat, apMat, rut);

            string consulta = $"insert into {tableName} (rut, nombre, apPat, apMat, edad, clave, Nivel) values ('{rut}', '{nombre}', '{apPat}', '{apMat}', {edad}, '{clave}', {nivel});";

            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();
            dgvAdmin.DataSource = dataTable;

            MessageBox.Show("Usuario agregado correctamente");

            btnReset_Click(sender, e);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string rut = ValidadorRUT(textBoxRutAdd.Text);

            if (rut == null) return;

            if (!ValidarCampos()) return;

            if (rutExiste(rut) == null)
            {
                MessageBox.Show("El rut ingresado no se ha encontrado");
                return;
            }

            string nombre = textBoxNombreAdd.Text;
            string apPat = textBoxApPatAdd.Text;
            string apMat = textBoxApMatAdd.Text;
            string edad = textBoxEdadAdd.Text;
            string nivel = textBoxNivelAdd.Text;
            string clave = GenerarClave(nombre, apPat, apMat, rut);

            string consulta = $"update {tableName} set nombre = '{nombre}', apPat = '{apPat}', apMat = '{apMat}', edad = {edad}, clave = '{clave}', Nivel = {nivel} where rut = '{rut}'";

            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();
            dataTable = GetDataTable(consulta, conexion);
            conexion.Close();

            MessageBox.Show("Usuario modificado correctamente");

            btnReset_Click(sender, e);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxNivelAdd.Text = "";
            textBoxApMatAdd.Text = "";
            textBoxApPatAdd.Text = "";
            textBoxNombreAdd.Text = "";
            textBoxRutAdd.Text = "";
            textBoxEdadAdd.Text = "";
            textBoxRutEliminar.Text = "";
            textBoxRutConsultar.Text = "";
            PanelAdmin_Load(sender, e);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Game game = new Game(username.ToUpper(), logins, userRut.ToUpper());
            game.Show();
            this.Hide();
        }
        private void PanelAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
