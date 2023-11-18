using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Peliculas
    {
     
        public int codigo_pelicula { get; set; }
        public string nombre_pelicula { get; set; }
        public int codigo_cine { get; set; }
        public string director { get; set; }
        public int codigo_categoria { get; set; }
        public int codigo_clasificacion { get; set; }
        public int codigo_formato { get; set; }
        public TimeSpan? duracion { get; set; }

        public Peliculas(int codigo_pelicula, string nombre_pelicula, int codigo_cine, string director, int codigo_categoria, int codigo_clasificacion, int codigo_formato, TimeSpan duracion)
        {
            this.codigo_pelicula = codigo_pelicula;
            this.nombre_pelicula = nombre_pelicula;
            this.codigo_cine = codigo_cine;
            this.director = director;
            this.codigo_categoria = codigo_categoria;
            this.codigo_clasificacion = codigo_clasificacion;
            this.codigo_formato = codigo_formato;
            this.duracion = duracion;
        }

        public Peliculas()
        {
            this.codigo_pelicula = 0;
            this.nombre_pelicula = null;     
            this.codigo_cine = 0;
            this.director = null;
            this.codigo_categoria = 0;
            this.codigo_clasificacion = 0;
            this.codigo_formato = 0;
            this.duracion= null;
        }
    }
}
