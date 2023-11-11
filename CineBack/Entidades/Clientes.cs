using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Clientes
    {
     
        public int id_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string apellido_cliente{ get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public int DNI { get; set; }

        public Clientes(int id_cliente, string nom_cliente, string apellido_cliente, int telefono, string email, int dNI)
        {
            this.id_cliente = id_cliente;
            this.nom_cliente = nom_cliente;
            this.apellido_cliente = apellido_cliente;
            this.telefono = telefono;
            this.email = email;
            this.DNI = dNI;
        }

        public Clientes()
        {
            this.id_cliente = 0;
            this.nom_cliente = string.Empty;
            this.apellido_cliente = string.Empty;
            this.telefono = 0;
            this.email = string.Empty;
            this.DNI = 0;
        }
    }


}
