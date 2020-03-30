using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Espotifai
    {
        private bool x;
        private List<Cancion> Canciones = new List<Cancion>();
       
        public Espotifai()
        {
          


        }

        public bool AgregarCancion(Cancion cancion)
        {
            x = Canciones.Contains(cancion);
            if(x == false)
            {
                Canciones.Add(cancion);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void VerCanciones()
        {
            
           
            foreach (var i in Canciones)
            {
                Cancion n = i;
                Console.WriteLine(n.Informacion());
            }
            

        }
    }
}
