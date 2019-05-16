using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoFinal.Classes;

namespace CodigoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el nombre: ");
            string name = Console.ReadLine();
            Checar.checador(name);
            Console.WriteLine("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            Checar.checador(apellido);

        }
    }
}
