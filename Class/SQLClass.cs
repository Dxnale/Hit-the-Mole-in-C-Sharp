using System.Data.SqlClient;

namespace PROG2EVA1javierNievesDanielTorrealba.Class
{
    public class SQLClass
    {
        private static readonly string conectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GIT\\PROG2EVA1javierNievesDanielTorrealba\\p2bdd.mdf;Integrated Security=True";

        private SqlConnection conexion;

        public SQLClass()
        {
            conexion = new SqlConnection(conectionString);
        }

        public static string ConectionString => conectionString;

        public SqlConnection Conexion
        {
            get => conexion;
        }
    }
}
