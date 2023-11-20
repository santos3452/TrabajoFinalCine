using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Dominio
{
    public class Salas
    {
      
        public int id_sala { get; set; }
        public int cantidad_butaca { get; set; }
        public int codigo_cine { get; set; }

        public Salas(int id_sala, int cantidad_butaca, int codigo_cine)
        {
            this.id_sala = id_sala;
            this.cantidad_butaca = cantidad_butaca;
            this.codigo_cine = codigo_cine;
        }

        public Salas()
        {
            this.id_sala = 0;
            this.cantidad_butaca = 0;
            this.codigo_cine = 0;
        }
    }
}
