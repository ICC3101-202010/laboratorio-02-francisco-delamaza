using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Espotifai
    {
        private int x = 0;
        private List<Cancion> Canciones = new List<Cancion>();
       
        public  Espotifai()
        {
          


        }

        public bool AgregarCancion(Cancion cancion)
        {
            
            foreach(var i in Canciones)
            {
                if (i.Nombre.Equals(cancion.Nombre) && i.Artista.Equals(cancion.Artista) && i.Álbum.Equals(cancion.Álbum))
                {
                    x += 1;
                }
                else
                {
                    x = 0;
                }
            }
            if(x == 0)
            {
                Canciones.Add(cancion);
                Console.WriteLine("Cancion agregada");
                return true;
            }
            
            else
            {
               
                Console.WriteLine("error");
                return false;

            }
        }

        public void VerCanciones()
        {
            foreach (Cancion i in Canciones)
            {
                Cancion n = i;
                Console.WriteLine(n.Informacion());
            }
        }
           
        
    }
}
