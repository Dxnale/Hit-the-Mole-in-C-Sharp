using System.Drawing;

namespace PROG2EVA1javierNievesDanielTorrealba
{
    internal class Topo
    {
        private bool estado;
        private Bitmap imagenTopo;
        private Bitmap imagenHoyo;
        private Bitmap imagen;
        public Topo()
        {
            this.estado = false;
            this.imagenTopo = Properties.Resources.topo_HIT;
            this.imagenHoyo = Properties.Resources.topo_VACIO;
            this.imagen = imagenHoyo;
        }
        public bool Estado
        {
            get { return estado; }
        }
        public Bitmap Imagen
        {
            get { return imagen; }
        }
        public void Aparicion()
        {
            this.estado = true;
            this.imagen = imagenTopo;
        }
        public void Desaparicion()
        {
            this.estado = false;
            this.imagen = imagenHoyo;
        }

    }
}
