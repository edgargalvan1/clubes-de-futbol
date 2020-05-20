using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TT
{
     public class Class1
    {
        int duracion;
        Color color;
        private string nombrePelicula;
        private string colab;
        private string art;
        private string genero;
        private string album;
        private static int cantidad_canciones;

public int Cantidad_canciones { get => cantidad_canciones; set => cantidad_canciones = value; }
        public string Album { get => album; set => album = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Art { get => art; set => art = value; }
        public string Colab { get => colab; set => colab = value; }
        public string NombrePelicula { get => nombrePelicula; set => nombrePelicula = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public Color Color { get => color; set => color = value; }
    }
}
