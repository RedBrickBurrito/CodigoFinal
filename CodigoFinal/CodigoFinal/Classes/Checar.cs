using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoFinal.Classes
{
    class Checar
    {


        public static void checador(string name)
        {
            try
            {
                int letras = name.Count();
                if (letras <= 2)
                {
                    throw new MinimoLetrasException();
                }
            }
            catch (MinimoLetrasException)
            {
                Console.WriteLine("nombre/apellido no válido");
            }
        }

        public class MinimoLetrasException : Exception
        {
            public MinimoLetrasException()
               : base()
            {
            }
        }
    }
}
