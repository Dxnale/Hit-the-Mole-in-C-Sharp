using System;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    //Clase vigia para registrar las acciones de los usuarios
    internal class CLASEEVALUA2danielTorrealba
    {
        string rut;
        DateTime inicioSesion;
        DateTime finSesion;
        string accion;
        DateTime accionF;

        public CLASEEVALUA2danielTorrealba(string rut)
        {
            //Constructor de la clase para el login
            this.accion = "Login Exitoso";
            this.rut = rut;
            this.inicioSesion = DateTime.Now;
        }

        public CLASEEVALUA2danielTorrealba(string rut, string accion)
        {
            //Constructor de la clase para las acciones
            this.rut = rut;
            this.accion = accion;
            this.accionF = DateTime.Now;
        }

        public CLASEEVALUA2danielTorrealba(string rut,string accion, bool finPartida)
        {
            //Constructor de la clase para el logout
            this.rut = rut;
            this.accion = accion;
            this.finSesion = DateTime.Now;
        }

        public string Rut { get => rut; set => rut = value; }
        public DateTime InicioSesion { get => inicioSesion; set => inicioSesion = value; }
        public DateTime FinSesion { get => finSesion; set => finSesion = value; }
        public string Accion { get => accion; set => accion = value; }
        public DateTime AccionF { get => accionF; set => accionF = value; }
    }
}
