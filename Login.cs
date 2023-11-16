using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Login : Form
    {
        private static bool valido;
        private static string digito;
        private static readonly int[] digitosAlgoritmo = { 3, 2, 7, 6, 5, 4, 3, 2 }; //array de digitos constantes para el algoritmo
        public Login()
        {
            InitializeComponent();
        }
        private static bool ValidarRut(string Rut)
        {

            digito = null; //Resetea el digito verificador

            Rut = Rut.Replace(".", "").Replace("-", "").ToUpper(); //quita puntos y guiones y pasa a mayusculas si el rut es menor a 9 digitos agrega un 0 al inicio

            if (Rut.Length <= 2 || Rut.Length > 9) return false; //si el rut no es del largo correcto corta la ejecucion

            Rut = Rut.Length < 9 ? "0" + Rut : Rut; //si el rut es menor a 9 digitos agrega un 0 al inicio

            digito = ValidarDigito(Rut);

            return Rut[Rut.Length - 1].ToString().Equals(digito);

        }
        private static string ValidarDigito(string Rut)
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
            if (valido && ValidarRut(textBoxRut.Text) && textBoxNombre.Text != "")
            {
                RunGame();
            }
            else
            {
                MessageBox.Show("Debes ingresar un nombre y RUT validos para poder jugar");
            }
        }

        private void RunGame()
        {
            Game game = new Game(textBoxNombre.Text);
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
    }
}
