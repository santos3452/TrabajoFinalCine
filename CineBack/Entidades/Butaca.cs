using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Butaca
    {
    

        public int id_butaca { get; set; }
        public int id_estado { get; set; }
        public int id_sala { get; set; }
        public int numero { get; set; }

        public Butaca(int id_butaca, int id_estado, int id_sala, int numero)
        {
            this.id_butaca = id_butaca;
            this.id_estado = id_estado;
            this.id_sala = id_sala;
            this.numero = numero;
        }

        public Butaca()
        {
            this.id_butaca = 0;
            this.id_estado = 0;
            this.id_sala = 0;
            this.numero = 0;
        }
    }
}
