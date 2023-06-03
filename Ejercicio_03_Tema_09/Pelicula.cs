using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio_03_Tema_09
{
    public class Pelicula
    {
        // Miembros de la clase
        private string titulo, genero, saga;
        private int duracion;


        // Propiedades
        public string Titulo {get => titulo; set => titulo = value;}
        public int Duracion { get => duracion; set => duracion = value; }
        public string Genero { get => genero; set => genero = value;}
        public string Saga { get => saga; set => saga = value;}


        // Constructor
        public Pelicula(string titulo, int duracion, string genero, string saga)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.genero = genero;
            this.saga = saga;
        }
    }
}
