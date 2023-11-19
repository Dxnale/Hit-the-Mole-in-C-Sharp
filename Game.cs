using System;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Game : Form
    {
        private Topo[,] topos = new Topo[3, 3];
        private PictureBox[,] pictureBoxes = new PictureBox[3, 3];
        private Random rnd = new Random();
        private string player;
        private int score = 0;
        private int fails = 0;
        private Timer timer = new Timer();
        private Timer timer2 = new Timer();
        private const int baby = 1000;
        private const int easy = 500;
        private const int medium = 250;
        private const int hard = 100;

        public Game(string player)
        {
            InitializeComponent();
            this.player = player;
            lblNombre.Text = player;
            StartGame();
        }
        private void StartGame()
        {
            TimerDificultad(baby);

            for (int i = 0; i < topos.GetLength(0); i++)
            {
                for (int j = 0; j < topos.GetLength(1); j++)
                {
                    topos[i, j] = new Topo();
                    CreaBoxes(i, j);
                }
            }

            for (int i = 0; i < topos.GetLength(0); i++)
            {
                for (int j = 0; j < topos.GetLength(1); j++)
                {
                    panelJuego.Controls.Add(pictureBoxes[i, j], i, j);
                }
            }
        }
        private void TimerAparicion(object sender, EventArgs e)
        {
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);
            if (topos[x, y].Estado == false)
            {
                topos[x, y].Aparicion();
                pictureBoxes[x, y].Image = topos[x, y].Imagen;
            }

            if (timer.Interval == medium || timer.Interval == hard)
            {
                x = rnd.Next(0, 3);
                y = rnd.Next(0, 3);
                if (topos[x, y].Estado == false)
                {
                    topos[x, y].Aparicion();
                    pictureBoxes[x, y].Image = topos[x, y].Imagen;
                }
            }
        }
        private void Timer_Desaparicion(object sender, EventArgs e)
        {
            for (int i = 0; i < topos.GetLength(0); i++)
            {
                for (int j = 0; j < topos.GetLength(1); j++)
                {
                    if (topos[i, j].Estado == true)
                    {
                        topos[i, j].Desaparicion();
                        pictureBoxes[i, j].Image = topos[i, j].Imagen;
                    }
                }
            }
        }
        private void CreaBoxes(int i, int j)
        {
            this.pictureBoxes[i, j] = new PictureBox();
            this.pictureBoxes[i, j].Image = topos[i, j].Imagen;
            this.pictureBoxes[i, j].Dock = DockStyle.Fill;
            this.pictureBoxes[i, j].Name = "pictureBox" + i + j;
            this.pictureBoxes[i, j].Size = new System.Drawing.Size(263, 193);
            this.pictureBoxes[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxes[i, j].Click += TopoClick;
        }

        private void TopoClick(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            int i = int.Parse(pb.Name[10].ToString());
            int j = int.Parse(pb.Name[11].ToString());

            if (topos[i, j].Estado)
            {
                topos[i, j].Desaparicion();
                pictureBoxes[i, j].Image = topos[i, j].Imagen;

                score++;
                lblScorePuntos.Text = score.ToString();
            }
            else
            {
                fails++;
                lblScoreFallas.Text = fails.ToString();
            }

        }

        private void TimerDificultad(int dificultad)
        {
            switch (dificultad)
            {
                case baby:
                    timer.Interval = baby;
                    timer2.Interval = baby;
                    break;
                case easy:
                    timer.Interval = easy;
                    timer2.Interval = easy;
                    break;
                case medium:
                    timer.Interval = medium;
                    timer2.Interval = medium;
                    break;
                case hard:
                    timer.Interval = hard;
                    timer2.Interval = hard;
                    break;
            }
            timer.Tick += TimerAparicion;
            timer2.Tick += Timer_Desaparicion;
            timer.Start();
            timer2.Start();
        }
    }
}
