using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class FormaDePago
    {
        public int id_formapago;
        public string descripcion;

        public FormaDePago()
        {
            this.id_formapago = 0;  
            this.descripcion = string.Empty;
        }

        public FormaDePago(int iD, string descripcion)
        {
            id_formapago = iD;
            this.descripcion = descripcion;
        }

       
    }
}
