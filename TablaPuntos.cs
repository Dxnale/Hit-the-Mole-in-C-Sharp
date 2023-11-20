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
            {
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

            // Ordenar y tomar los top 7
            puntajes = puntajes.OrderByDescending(entry => entry.Score).Take(10).ToArray();

            foreach (var entry in puntajes)
            {
                tablaDatos.Rows.Add(entry.Player, entry.Score);
            }

            return tablaDatos;
        }

        private Entrada[] LeerScoresDesdeArchivo()
        {
            puntajes = new Entrada[0];

            using (StreamReader leer = new StreamReader(ruta))
            {
                string line;

                while ((line = leer.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string playerName = parts[0].Trim();
                    string scoreString = parts[1].Replace("puntos", string.Empty).Trim();

                    int playerScore = int.Parse(scoreString);
                    Array.Resize(ref puntajes, puntajes.Length + 1);
                    puntajes[puntajes.Length - 1] = new Entrada { Player = playerName, Score = playerScore };
                }
            }

            return puntajes;
        }

        private class Entrada
        {
            public string Player { get; set; }
            public int Score { get; set; }
        }
    }
}
