using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion c = new Cancion("Lights", "Lights", "Ellie Glounding", "Pop");
            Espotifai e = new Espotifai();
            e.AgregarCancion(c);
            e.VerCanciones();
            Console.WriteLine(c.Informacion());
            


            
            Console.ReadKey();

        }
    }
}
