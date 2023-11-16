using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Game : Form
    {
        private string player;

        public Game(string player)
        {
            InitializeComponent();
            this.player = player;
            lblNombre.Text = player;
        }
    }
}
