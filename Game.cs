using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    public partial class Game : Form
    {
        //Lista de logs
        private List<CLASEEVALUA2danielTorrealba> LISTAEVALUA2 = new List<CLASEEVALUA2danielTorrealba>();

        private TablaPuntos tablaPuntos = new TablaPuntos();
        private readonly Topo[,] topos = new Topo[3, 3];
        private readonly PictureBox[,] pictureBoxes = new PictureBox[3, 3];
        private readonly Random rnd = new Random();

        private readonly string player;
        private readonly string playerRut;
        private int score = 0;
        private int fails = 0;

        private Timer timerAparece;
        private Timer timerDesaparece;

        private const int Baby = 1500;
        private const int Easy = 750;
        private const int Medium = 500;
        private const int Hard = 250;
        private int dificultadActual;

        public Game(string player, object logs, string playerRut)
        { 
            //Asigna la lista de logs recibida desde el login a la lista de logs de la clase Game
            this.LISTAEVALUA2 = (List<CLASEEVALUA2danielTorrealba>)logs;

            InitializeComponent(); // Inicializa los componentes base del formulario

            this.player = player; // Recibe el nombre del jugador desde el login
            this.playerRut = playerRut; // Recibe el rut del jugador desde el login
            lblNombre.Text = player; // Muestra el nombre del jugador en el formulario
            lblShowDificultad.Text = "REGALADO";
            btnReset.Visible = false; // Oculta el botón de reinicio (el boton se usa al final)

            MostrarScores(); // Muestra los scores desde la clase TablaPuntos en el DataGridView       
            StartGame(); // Inicia el juego

        }
        private void StartGame()
        {
            StartTimers(); // Inicia los timers de aparición y desaparición de los topos

            for (int i = 0; i < topos.GetLength(0); i++)
            {
                for (int j = 0; j < topos.GetLength(1); j++)
                {
                    topos[i, j] = new Topo(); //Crea una matriz de objetos de de la clase Topo
                    CreaBoxes(i, j); // Crea una matriz de PictureBoxes con propiedades por defecto
                    panelJuego.Controls.Add(pictureBoxes[i, j], i, j); // Agrega los PictureBoxes al panel
                }
            }

            TimerDificultad(Baby); // Inicia el timer de dificultad en Baby por defecto
        }
        private void StartTimers() 
        {
            // Si los timers ya existen, los detiene y los destruye
            timerAparece?.Stop(); 
            timerAparece?.Dispose();
            timerDesaparece?.Stop();
            timerDesaparece?.Dispose();
            // Limpia el panel de juego
            panelJuego.Controls.Clear();
            // Crea los timers
            timerAparece = new Timer();
            timerDesaparece = new Timer();
            // Asigna los eventos a los timers
            timerAparece.Tick += TimerAparicion;
            timerDesaparece.Tick += TimerDesaparicion;
            // se ejecutan los eventos de los timers
            timerAparece.Start();
            timerDesaparece.Start();
        }
        private void TimerAparicion(object sender, EventArgs e)
        {
            // Genera dos números aleatorios entre 0 y 2 y los asigna a las variables x,y
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);

            if (!topos[x, y].Estado) // Verifica el estado del topo en la posición x, y para manejar su posible aparición o desaparición
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

            ActualizarDificultad(); //Verifica si el score es suficiente para aumentar la dificultad
            MostrarScores(); // Muestra los scores desde la clase TablaPuntos en el DataGridView
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
            // Castea el objeto a PictureBox para poder acceder a sus propiedades
            PictureBox pb = (PictureBox)pictureBox; 
            // Obtiene los números de la propiedad Name del PictureBox para poder acceder a la matriz de topos
            int i = int.Parse(pb.Name[10].ToString());
            int j = int.Parse(pb.Name[11].ToString());

            if (topos[i, j].Estado) //Utiliza el estado del topo para verificar si el click fue correcto o no
            { // Si el click fue correcto, cambia la imagen del topo
                ActualizarImagen(pictureBoxes[i, j], Properties.Resources.topo_UP);
                score += 1000; // Suma 1000 puntos al score
                lblScorePuntos.Text = score.ToString();

                LISTAEVALUA2.Add(new CLASEEVALUA2danielTorrealba(playerRut, $"Click Correcto en {i}-{j}")); // Agrega un log de click correcto 
            }
            else
            { // Si el click fue incorrecto, cambia la imagen del topo
                ActualizarImagen(pictureBoxes[i, j], Properties.Resources.topo_FAIL);
                fails++; // Suma 1 a los fails
                lblScoreFallas.Text = fails.ToString();
                // Actualiza el score y los fails en la tabla de scores

                LISTAEVALUA2.Add(new CLASEEVALUA2danielTorrealba(playerRut, $"Click Incorrecto en {i}-{j}")); // Agrega un log de click incorrecto

                ActualizarFails();
                MostrarScores();
            }

            await Task.Delay(dificultadActual);// Espera el tiempo establecido en la dificultad actual

            topos[i, j].Desaparicion(); // Desaparece el topo
            ActualizarImagen(pictureBoxes[i, j], topos[i, j].Imagen); // Actualiza la imagen del topo
        }
        private void ActualizarScore()
        {
            tablaPuntos?.ActualizarScore(player, score);
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
            LISTAEVALUA2.Add(new CLASEEVALUA2danielTorrealba(playerRut, "Reinicio de Juego"));
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
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Cada elemento de la lista debe ser almacenado en el archivo de texto con el siguiente formato: Rut, InicioSesion, FinSesion, Accion, AccionF;
            LISTAEVALUA2.Add(new CLASEEVALUA2danielTorrealba(playerRut,"Juego Cerrado", true));

            StreamWriter archivo = new StreamWriter(@"C:\\TXTS\\VIGIADANIELTORREALBA.csv", true);

            foreach (CLASEEVALUA2danielTorrealba log in LISTAEVALUA2)
            {
                archivo.WriteLine($"{log.Rut},{log.InicioSesion},{log.FinSesion},{log.Accion},{log.AccionF}");
            }

            archivo.Close();

            EndGame();

            Application.Exit();
        }
    }
}
