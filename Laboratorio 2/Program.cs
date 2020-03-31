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
                Console.WriteLine("3) Ver canciones por criterio");
                Console.WriteLine("4) Salir");
                string x = Console.ReadLine();
                

                if (x == "1")
                {
                    e.VerCanciones();
                    Console.WriteLine("Presione tecla para continuar");
                    Console.ReadKey();
                }
                if (x == "2")
                { 
                    
                        
                    Console.WriteLine("Nombre: ");
                    string a = Console.ReadLine();
                    Console.WriteLine("Álbum: ");
                    string b = Console.ReadLine();
                    Console.WriteLine("Artista: ");
                    string z = Console.ReadLine();
                    Console.WriteLine("Género: ");
                    string d = Console.ReadLine();
                    Cancion f = new Cancion(a, b, z, d);
                    e.AgregarCancion(f);
                    Console.WriteLine();
                    
                    
                }
                if (x == "3")
                {
                    Console.WriteLine("Criterio:");
                    string l = Console.ReadLine();
                    Console.WriteLine("Valor:");
                    string i = Console.ReadLine();
                    Console.WriteLine();
                    e.CancionesPorCriterio(l, i);
                    Console.WriteLine();
                }

                 if (x == "4")
                {
                    break;
                }
               
                 else if (x != "1" && x != "2" && x != "3" && x!= "\n" && x != "4")
                {
                    Console.WriteLine("Opción no valida");
                    Console.WriteLine();
                }
                      
                    


                }

            
               
           
            
            
            //menu
            
        }
        
}
    }

