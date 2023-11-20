using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class TicketFactura
    {
        
        public int id_factura { get; set; }
        public DateTime? fecha { get; set; }
        public int id_cliente { get; set; }
        public int id_forma { get; set; }
        public decimal totalfinal { get; set; }
        public List<DetalleTicketFactura> Detalle { get; set; }

        public TicketFactura(int id_factura, DateTime? fecha, int id_cliente, int id_forma,decimal totalfinal)
        {
            this.id_factura = id_factura;
            this.fecha = fecha;
            this.id_cliente = id_cliente;
            this.id_forma = id_forma;
            this.totalfinal = totalfinal;   
        }   

        public TicketFactura()
        {
            this.id_factura = 0;
            Detalle = new List<DetalleTicketFactura>();
            this.fecha = DateTime.Now;
            this.id_cliente = 0;
            this.id_forma = 0;
            this.totalfinal = 0;    
        }

        public void AgregarDetalle(DetalleTicketFactura detalle)
        {
            Detalle.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            Detalle.RemoveAt(posicion);
        }

        public int CantidadDetalles()
        {
            return Detalle.Count;
        }
        public decimal CalcularTotal(decimal precioentero)
        {
            
            foreach (DetalleTicketFactura item in Detalle)
            {
                item.precio = item.precio + precioentero ;

            }

            return precioentero;
        }

    }
}
