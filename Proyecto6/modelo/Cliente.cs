using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Proyecto6.modelo
{
    public class Cliente
    {
        // campos
        //private string rut;
        //private string nombre;
        //private int saldo;
        //private string correo;

        // propiedades:
        // 1) publico.
        // 2) "{ set; get; }"
        // 3) las propiedades se recomiendan escribirlas en mayuscula.
    
        public string Rut { set; get; }
        public string Nombre { set; get; }
        public int Saldo { set; get; }
        public string Correo { set; get; }

        public Cliente(string rut, string nombre, int saldo, string correo)
        {
            Rut = rut;
            Nombre = nombre;
            Saldo = saldo;
            Correo = correo;
        }

        public Cliente()
        {
        }


        // constructor: (es opcional)
        // 1) se llama como la clase
        // 2) no regresa valor (ni tampoco tiene void)
        // 3) se pueden escribir diferentes constructores.



    }
}
