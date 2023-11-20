using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Game : Form
    {

        private TablaPuntos tablaPuntos = new TablaPuntos();
        private readonly Topo[,] topos = new Topo[3, 3];
        private readonly PictureBox[,] pictureBoxes = new PictureBox[3, 3];
        private readonly Random rnd = new Random();

        private readonly string player;
        private int score = 0;
        private int fails = 0;

        private Timer timerAparece;
        private Timer timerDesaparece;

        private const int Baby = 1500;
        private const int Easy = 750;
        private const int Medium = 500;
        private const int Hard = 250;
        private int dificultadActual;

        public Game(string player)
        {
            InitializeComponent();

            this.player = player;
            lblNombre.Text = player;
            lblShowDificultad.Text = "REGALADO";
            btnReset.Visible = false;

            MostrarScores();
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

            TimerDificultad(Baby);
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

            if (!topos[x, y].Estado)
            {
                topos[x, y].Aparicion();
                ActualizarImagen(pictureBoxes[x, y], topos[x, y].Imagen);
            }
            else
            {
                topos[x, y].Desaparicion();
                ActualizarImagen(pictureBoxes[x, y], topos[x, y].Imagen);
                return;
            }


            if (dificultadActual <= Medium)
            {
                AparicionAdicional(x, y);
            }

            ActualizarDificultad();
            MostrarScores();
        }
        private void AparicionAdicional(int x, int y)
        {
            int w = rnd.Next(0, 3);
            int k = rnd.Next(0, 3);

            if (topos[w, k].Estado || (w == x && k == y))
            {
                topos[w, k].Desaparicion();
                ActualizarImagen(pictureBoxes[w, k], topos[w, k].Imagen);
                return;
            }

            topos[w, k].Aparicion();
            ActualizarImagen(pictureBoxes[w, k], topos[w, k].Imagen);

            if (dificultadActual == Hard)
            {
                w = rnd.Next(0, 3);
                k = rnd.Next(0, 3);

                if (!topos[w, k].Estado)
                {
                    topos[w, k].Aparicion();
                    ActualizarImagen(pictureBoxes[w, k], topos[w, k].Imagen);
                }
                else
                {
                    topos[w, k].Desaparicion();
                    ActualizarImagen(pictureBoxes[w, k], topos[w, k].Imagen);
                }
            }
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
                        ActualizarImagen(pictureBoxes[i, j], topos[i, j].Imagen);
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
        private void ActualizarImagen(PictureBox pictureBox, Bitmap imagen)
        {
            pictureBox.Invoke((MethodInvoker)delegate
            {
                pictureBox.Image = imagen;
            });
        }
        private async void TopoClick(object pictureBox, EventArgs evento)
        {
            PictureBox pb = (PictureBox)pictureBox;

            int i = int.Parse(pb.Name[10].ToString());
            int j = int.Parse(pb.Name[11].ToString());

            if (topos[i, j].Estado)
            {
                ActualizarImagen(pictureBoxes[i, j], Properties.Resources.topo_UP);
                score += 1000;
                lblScorePuntos.Text = score.ToString();
            }
            else
            {
                ActualizarImagen(pictureBoxes[i, j], Properties.Resources.topo_FAIL);
                fails++;
                lblScoreFallas.Text = fails.ToString();

                ActualizarFails();
                MostrarScores();
            }

            await Task.Delay(dificultadActual);

            topos[i, j].Desaparicion();
            ActualizarImagen(pictureBoxes[i, j], topos[i, j].Imagen);
        }
        private void ActualizarScore()
        {
            tablaPuntos.ActualizarScore(player, score);
            MostrarScores();
        }
        private void MostrarScores()
        {
            DataTable topScores = tablaPuntos.ObtenerTopScores();
            dataGridViewScores.DataSource = topScores;
        }

        private void ActualizarDificultad()
        {
            switch (score)
            {
                case 12000:
                    TimerDificultad(Easy);
                    lblShowDificultad.Text = "FACILITO";
                    break;
                case 24000:
                    TimerDificultad(Medium);
                    lblShowDificultad.Text = "MEDIO";
                    break;
                case 30000:
                    TimerDificultad(Hard);
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
                ActualizarScore();
                MessageBox.Show($"Has perdido {player}.\nTu puntuación es de {score} puntos.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void TimerDificultad(int dificultad)
        {
            dificultadActual = dificultad;

            switch (dificultad)
            {
                case Baby:
                    timerAparece.Interval = Baby;
                    timerDesaparece.Interval = Baby;
                    break;
                case Easy:
                    timerAparece.Interval = Easy;
                    timerDesaparece.Interval = Easy;
                    break;
                case Medium:
                    timerAparece.Interval = Medium;
                    timerDesaparece.Interval = Medium;
                    break;
                case Hard:
                    timerAparece.Interval = Hard;
                    timerDesaparece.Interval = Hard;
                    break;
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            EndGame();
            StartGame();
        }
        private void EndGame()
        {
            timerAparece?.Stop();
            timerAparece?.Dispose();
            timerDesaparece?.Stop();
            timerDesaparece?.Dispose();

            score = 0;
            fails = 0;
            lblScorePuntos.Text = score.ToString();
            lblScoreFallas.Text = fails.ToString();
            lblShowDificultad.Text = "REGALADO";
            btnReset.Visible = false;

            panelJuego.Controls.Clear();
        }
    }
}
