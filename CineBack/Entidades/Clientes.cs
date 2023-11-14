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
        public string NOMBRE { get; set; }
        public string APELLIDO{ get; set; }
        public long TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public long DNI { get; set; }

        public Clientes(int id_cliente, string nOMBRE, string aPELLIDO, long tELEFONO, string eMAIL, long dNI)
        {
            this.id_cliente = id_cliente;
            NOMBRE = nOMBRE;
            APELLIDO = aPELLIDO;
            TELEFONO = tELEFONO;
            EMAIL = eMAIL;
            DNI = dNI;
        }



        public Clientes()
        {
            this.id_cliente = 0;
            this.NOMBRE = string.Empty;
            this.APELLIDO = string.Empty;
            this.TELEFONO = 0;
            this.EMAIL = string.Empty;
            this.DNI = 0;
        }

       
    }


}
