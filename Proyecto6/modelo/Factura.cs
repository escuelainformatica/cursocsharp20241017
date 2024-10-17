using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.modelo
{
    public class Factura
    {
        // propiedades
        public int NumFactura { set; get; }
        public string NombreCliente { set; get; }
        public string Fecha { set; get; }
        public int Total { set; get; }
        // con la ampollea (con el boton derecho encima de la clase -> constructor)
        public Factura(int numFactura, string nombreCliente, string fecha, int total)
        {
            NumFactura = numFactura;
            NombreCliente = nombreCliente;
            Fecha = fecha;
            Total = total;
        }

        public Factura()
        {
        }


 



    }
}
