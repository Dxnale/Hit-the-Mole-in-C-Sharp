using System;
using System.Data;
using System.IO;
using System.Linq;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    internal class TablaPuntos
    {
        private readonly string ruta = "score.txt";
        Entrada[] puntajes;
        DataTable tablaDatos;

        public void ActualizarScore(string player, int score)
        {
            using (StreamWriter guardar = new StreamWriter(ruta, true))
            { // Escribir el nombre del jugador y su puntaje en el archivo
                guardar.WriteLine($"{player}: {score} puntos");
            }
        }

        public DataTable ObtenerTopScores()
        {
            tablaDatos = new DataTable();
            tablaDatos.Columns.Add("Jugador");
            tablaDatos.Columns.Add("Puntuación");

            // Leer las líneas del archivo y agregarlas al DataTable
            puntajes = LeerScoresDesdeArchivo();

            // Ordenar y tomar los top 10 puntajes
            puntajes = puntajes.OrderByDescending(entry => entry.Score).Take(10).ToArray();

            foreach (var entry in puntajes)
            {
                tablaDatos.Rows.Add(entry.Player, entry.Score); // Agregar cada entrada al DataTable
            }

            return tablaDatos;
        }

        private Entrada[] LeerScoresDesdeArchivo() // Leer el archivo y devolver un array de entradas
        {
            puntajes = new Entrada[0]; // Inicializar el array de la clase Entrada (Player, Score)

            using (StreamReader leer = new StreamReader(ruta)) // Leer el archivo
            {
                string line;

                while ((line = leer.ReadLine()) != null) // Bucle que lee cada línea del archivo guardándola en la variable line
                {
                    string[] parts = line.Split(':'); // Separar la línea en dos partes, el nombre y el puntaje
                    string playerName = parts[0].Trim(); //Lipiar los espacios en blanco
                    string scoreString = parts[1].Replace("puntos", string.Empty).Trim(); // Quitar la palabra "puntos" y los espacios en blanco
                    int playerScore = int.Parse(scoreString); // Convertir el puntaje a entero
                    Array.Resize(ref puntajes, puntajes.Length + 1); // Redimensionar el array para agregar una nueva entrada
                    puntajes[puntajes.Length - 1] = new Entrada { Player = playerName, Score = playerScore }; // Agregar la nueva entrada al array
                }
            }
            return puntajes; //Retornar el array de entradas (string Player, int Score)
        }

        private class Entrada
        {
            public string Player { get; set; }
            public int Score { get; set; }
        }
    }
}