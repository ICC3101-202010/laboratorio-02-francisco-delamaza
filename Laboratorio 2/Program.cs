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
            
            Espotifai e = new Espotifai();
            bool showMenu = true;
            while (showMenu)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("Elija una opción:");
                Console.WriteLine();
                Console.WriteLine("1) Ver todas las canciones");
                Console.WriteLine("2) Agregar una cancion");
                Console.WriteLine("3) Salir");
                string x = Console.ReadLine();
                

                if (x == "1")
                {
                    e.VerCanciones();
                    Console.WriteLine("Presione tecla para continuar");
                    Console.ReadKey();
                }
                if (x == "2")
                { 
                    
                        
                    Console.WriteLine("nombre: ");
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    string z = Console.ReadLine();
                    string d = Console.ReadLine();
                    Cancion f = new Cancion(a, b, z, d);
                    e.AgregarCancion(f);
                    Console.WriteLine();
                    Console.ReadLine();
                    
                }
                 if (x == "3")
                {
                    break;
                }
                 else
                {
                    Console.WriteLine("Opción no valida");
                }
                      
                    


                }

            
               
           
            
            
            //menu
            
        }
        
}
    }

