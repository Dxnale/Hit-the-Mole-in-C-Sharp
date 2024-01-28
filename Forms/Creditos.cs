using System;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba.Forms
{
    partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }
        private void Creditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
