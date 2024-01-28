using PROG2EVA1javierNievesDanielTorrealba.Forms;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Menu : Form
    {
        private List<Vigia> acciones = new List<Vigia>();
        private string rut;
        private string nombre;
        private string apellidoPat;
        private string apellidoMat;
        private string clave;
        private int nivel;
        private bool admin;


        public Menu(DataRow datos, object log, bool admin)
        {
            InitializeComponent();

            acciones = (List<Vigia>)log;

            rut = datos[0].ToString();
            nombre = datos[1].ToString();
            apellidoPat = datos[2].ToString();
            apellidoMat = datos[3].ToString();
            clave = datos[5].ToString();
            nivel = int.Parse(datos[6].ToString());

            this.admin = admin;
            btnPerfiles.Visible = admin;

        }


        private void RunPanel()
        {
            PanelAdmin panel = new PanelAdmin(nombre, acciones, rut);
            panel.Show();
            this.Hide();
        }
        public void RunGame()
        {
            Game game = new Game(nombre.ToUpper(), acciones, rut);
            game.Show();
            this.Hide();
        }
        public void RunActions()
        {
            Actions actions = new Actions(nombre, clave, rut, acciones, nivel);
            actions.Show();
            this.Hide();
        }



        private void btnJugar_Click(object sender, System.EventArgs e)
        {
            RunGame();
        }
        private void btnAcciones_Click(object sender, System.EventArgs e)
        {
            RunActions();
        }
        private void btnPerfiles_Click(object sender, System.EventArgs e)
        {
            RunPanel();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
