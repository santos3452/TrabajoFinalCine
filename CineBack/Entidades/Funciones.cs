﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Funciones
    {
    
        public int codigo_funcion { get; set; }
        public int codigo_pelicula { get; set; }
        public DateTime? fecha { get; set; }
        public TimeSpan? HoraPeli { get; set; }
        public int precio { get; set; }
        public int id_sala { get; set; }

        public Funciones(int codigo_funcion, int codigo_pelicula, DateTime? fecha, TimeSpan? horaPeli, int precio, int id_sala)
        {
            this.codigo_funcion = codigo_funcion;
            this.codigo_pelicula = codigo_pelicula;
            this.fecha = fecha;
            HoraPeli = horaPeli;
            this.precio = precio;
            this.id_sala = id_sala;
        }

        public Funciones()
        {
            this.codigo_funcion = 0;
            this.codigo_pelicula = 0;
            this.fecha = null;
            this.HoraPeli = null;
            this.precio = 0;
            this.id_sala = 0;
        }
    }
}
