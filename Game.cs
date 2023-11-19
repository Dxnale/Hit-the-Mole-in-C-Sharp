using System;
using System.Threading.Tasks;
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

        private Timer timerAparece = new Timer();
        private Timer timerDesaparece = new Timer();

        private const int baby = 1500;
        private const int easy = 750;
        private const int medium = 500;
        private const int hard = 250;
        private int dificultadActual;


        public Game(string player)
        {
            InitializeComponent();

            this.player = player;
            lblNombre.Text = player;
            lblShowDificultad.Text = "REGALADO";
            btnReset.Visible = false;

            StartGame();
        }
        private void StartGame()
        {
            StartTimers();

            for (int i = 0; i < topos.GetLength(0); i++)
            {
                for (int j = 0; j < topos.GetLength(1); j++)
                {
                    topos[i, j] = new Topo();
                    CreaBoxes(i, j);
                    panelJuego.Controls.Add(pictureBoxes[i, j], i, j);
                }
            }

            TimerDificultad(baby);
        }

        private void StartTimers()
        {
            timerAparece?.Stop();
            timerAparece?.Dispose();
            timerDesaparece?.Stop();
            timerDesaparece?.Dispose();

            panelJuego.Controls.Clear();

            timerAparece = new Timer();
            timerDesaparece = new Timer();

            timerAparece.Tick += TimerAparicion;
            timerDesaparece.Tick += TimerDesaparicion;

            timerAparece.Start();
            timerDesaparece.Start();
        }

        private void TimerAparicion(object sender, EventArgs e)
        {
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);

            if (topos[x, y].Estado == false)
            {
                topos[x, y].Aparicion();
                pictureBoxes[x, y].Image = topos[x, y].Imagen;

                if (dificultadActual <= medium)
                {
                    x = rnd.Next(0, 3);
                    y = rnd.Next(0, 3);

                    if (topos[x, y].Estado == false)
                    {
                        topos[x, y].Aparicion();
                        pictureBoxes[x, y].Image = topos[x, y].Imagen;

                        if (dificultadActual == hard)
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
                }
            }

            ActualizarDificultad();

        }
        private void TimerDesaparicion(object sender, EventArgs e)
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
            this.pictureBoxes[i, j].SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxes[i, j].Click += TopoClick;
        }
        private async void TopoClick(object pictureBox, EventArgs evento)
        {
            PictureBox pb = (PictureBox)pictureBox;

            int i = int.Parse(pb.Name[10].ToString());
            int j = int.Parse(pb.Name[11].ToString());

            if (topos[i, j].Estado)
            {
                pictureBoxes[i, j].Image = Properties.Resources.topo_UP;
                score += 1000;
                lblScorePuntos.Text = score.ToString();
            }
            else
            {
                pictureBoxes[i, j].Image = Properties.Resources.topo_FAIL;
                fails++;
                lblScoreFallas.Text = fails.ToString();
                ActualizarFails();

            }

            await Task.Delay(dificultadActual);
            topos[i, j].Desaparicion();
            pictureBoxes[i, j].Image = topos[i, j].Imagen;
        }

        private void ActualizarDificultad()
        {
            switch (score)
            {
                case 12000:
                    TimerDificultad(easy);
                    lblShowDificultad.Text = "FACILITO";
                    break;
                case 24000:
                    TimerDificultad(medium);
                    lblShowDificultad.Text = "MEDIO";
                    break;
                case 30000:
                    TimerDificultad(hard);
                    lblShowDificultad.Text = "INFIERNO";
                    break;
            }
        }

        private void ActualizarFails()
        {
            if (fails == 3)
            {
                foreach (var topo in topos)
                {
                    topo.Desaparicion();
                }
                foreach (var pictureBox in pictureBoxes)
                {
                    pictureBox.Image = Properties.Resources.topo_VACIO;
                }

                timerAparece?.Stop();
                timerDesaparece?.Stop();
                btnReset.Visible = true;
                MessageBox.Show($"Has perdido {player}.\nTu puntuación es de {score} puntos.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TimerDificultad(int dificultad)
        {
            dificultadActual = dificultad;

            switch (dificultad)
            {
                case baby:
                    timerAparece.Interval = baby;
                    timerDesaparece.Interval = baby;
                    break;
                case easy:
                    timerAparece.Interval = easy;
                    timerDesaparece.Interval = easy;
                    break;
                case medium:
                    timerAparece.Interval = medium;
                    timerDesaparece.Interval = medium;
                    break;
                case hard:
                    timerAparece.Interval = hard;
                    timerDesaparece.Interval = hard;
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EndGame();
            StartGame();
        }

        private void EndGame()
        {
            score = 0;
            fails = 0;
            lblScorePuntos.Text = score.ToString();
            lblScoreFallas.Text = fails.ToString();
            lblShowDificultad.Text = "REGALADO";
            btnReset.Visible = false;

            timerAparece?.Stop();
            timerAparece?.Dispose();
            timerDesaparece?.Stop();
            timerDesaparece?.Dispose();

            panelJuego.Controls.Clear();
        }
    }
}
