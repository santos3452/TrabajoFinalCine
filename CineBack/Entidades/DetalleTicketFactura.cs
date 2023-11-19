using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class DetalleTicketFactura
    {
     

       
      
        public int id_butaca { get; set; }
        public decimal precio { get; set; }
        public int id_descuento { get; set; }
        public int id_funcion { get; set; }

        public DetalleTicketFactura(  int id_butaca, decimal precio, int id_descuento, int id_funcion)
        {
           
            this.id_butaca = id_butaca;
            this.precio = precio;
            this.id_descuento = id_descuento;
            this.id_funcion = id_funcion;
        }

        public DetalleTicketFactura()
        {
            
            this.id_butaca = 0;
            this.precio = 0;
            this.id_descuento = 0;
            this.id_funcion = 0;
        }
    }
}
