using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Cancion
    {
        private string Nombre;
        private string Álbum;
        private string Artista;
        private string Género;

       
       



        public Cancion(string Nombre, string Álbum, string Artista, string Género)
        {
            this.Nombre = Nombre;
            this.Álbum = Álbum;
            this.Género = Género;
            this.Artista = Artista;

        }


        public String Informacion()
        {
            Console.Write("genero: ");
            Console.Write(Género);
            Console.Write(",");
            Console.Write(" artista: ");
            Console.Write(Artista);
            Console.Write(",");
            Console.Write(" album: ");
            Console.Write(Álbum);
            Console.Write(",");
            Console.Write(" nombre: ");
            Console.Write(Nombre);
            return Nombre;
            
            
        }
        
    }
}
