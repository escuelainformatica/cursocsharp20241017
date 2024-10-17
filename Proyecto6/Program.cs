using Proyecto6.modelo;
using Proyecto6.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cli = new Cliente();
            cli.Nombre = "john";
            cli.Rut = "11111-1";
            cli.Saldo = 0;
            cli.Correo = "johndoe@gmail.com";

            var cli2 = new Cliente { // <-- igual se llama a un constructor vacio
                Rut = "1111-1",
                Nombre = "john",
                Saldo = 0,
                Correo = "john@gmail.com" 
            };

            var cli3 = new Cliente("1111-1", "john", 0, "john@gmail.com");

            // ejemplo Factura
            var fac1 = new Factura(1, "john", "01/01/2010", 20000);

 

            var fac2 = new Factura();
            fac2.NumFactura = 1;
            fac2.NombreCliente = "john";
            fac2.Fecha = "01/01/2010";
            fac2.Total = 20000;
            var fac3 = new Factura
            {
                NumFactura = 1,
                NombreCliente = "john",
                Fecha = "01/01/2010",
                Total = 2000
            };

            // var fservicio = new FacturaServicio(); // <-- Inyeccion de dependencia (avanzado!), Modelo Singleton (avanzado!), estatico
            // fservicio.MostrarFactura(fac1);
            // fservicio.MostrarFactura(fac2);
            // fservicio.MostrarFactura(fac3);

            // cuando se tiene un metodo estatico, se llama directamente usando la clase:
            FacturaServicio.MostrarFactura(fac1);
            FacturaServicio.MostrarFactura(fac2);
            FacturaServicio.MostrarFactura(fac3);



            Console.ReadKey();

        }
    }
}
