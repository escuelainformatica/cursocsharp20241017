using Proyecto6.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.servicio
{
    public static class FacturaServicio
    {
        // metodo 
        // public <el valor que se va a devolver> <nombre la funcion>(<los argumentos>)
        // Factura --> funcion -> nada (void)
        public static void MostrarFactura(Factura fact)
        {
            Console.WriteLine("----------fact:---------------");
            Console.WriteLine(fact.NumFactura);
            Console.WriteLine(fact.NombreCliente);
            Console.WriteLine(fact.Fecha);
            Console.WriteLine(fact.Total);
        }
        // una funcion que devuelve el total de la factura con el IVA.
        public static double TotalFactura(Factura fact)
        {
            return fact.Total * 1.19;
        }
        // una funcion que suma dos facturas y devuelve el total
        public static int SumarFactura(Factura fact1,Factura fact2)
        {
            return fact1.Total + fact2.Total;
        }

    }
}
