using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba.Forms
{
    public partial class Actions : Form
    {

        private readonly string nombre;
        private readonly string rut;

        //Se utilizará para separar al alcance en las consultas
        private readonly bool admin;

        private List<Vigia> vigia;
        private DataTable dataTable;

        private readonly string conectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GIT\\PROG2EVA1javierNievesDanielTorrealba\\p2bdd.mdf;Integrated Security=True";
        private static readonly string tableName = "ACCIONES";


        public Actions(string username, string userRut, object logs, bool admin)
        {
            //Constructor administrador
            InitializeComponent();
            this.nombre = username;
            this.rut = userRut;
            this.admin = admin;
            vigia = (List<Vigia>)logs;
        }

        private void Actions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        }
    }
}
