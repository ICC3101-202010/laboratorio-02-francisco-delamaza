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

        public Espotifai()
        {



        }

        public bool AgregarCancion(Cancion cancion)
        {
            x = 0;
            foreach (var i in Canciones)
            {
                if (i.Nombre.Equals(cancion.Nombre) && i.Artista.Equals(cancion.Artista) && i.Álbum.Equals(cancion.Álbum))
                {
                    x += 1;
                }
                else
                {

                }
            }
            if (x == 0)
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
        public Cancion[] CancionesPorCriterio(String criterio, String valor)
        {
            if (criterio == "Género")
            {
                foreach (var i in Canciones)
                {
                    if (i.Género.Equals(valor))
                    {
                        Cancion n = i;
                        Console.WriteLine(n.Informacion());
                    }
                    else
                    {
                        Console.WriteLine("No hay canciones de es Género");

                    }

                }
                return new Cancion[0];
            }

            if (criterio == "Nombre")
            {
                foreach (var i in Canciones)
                {
                    if (i.Nombre.Equals(valor))
                    {
                        Cancion n = i;
                        Console.WriteLine(n.Informacion());
                    }
                    else
                    {
                        Console.WriteLine("No hay canciones con ese nombre");

                    }
                }
                return new Cancion[0];
            }

            if (criterio == "Álbum")
            {
                foreach (var i in Canciones)
                {
                    if (i.Álbum.Equals(valor))
                    {
                        Cancion n = i;
                        Console.WriteLine(n.Informacion());
                    }
                    else
                    {
                        Console.WriteLine("No hay canciones de ese álbum");

                    }
                }
                return new Cancion[0];
            }

            if (criterio == "Artista")
            {
                foreach (var i in Canciones)
                {
                    if (i.Artista.Equals(valor))
                    {
                        Cancion n = i;
                        Console.WriteLine(n.Informacion());
                    }
                    else
                    {
                        Console.WriteLine("No hay canciones de es artista");

                    }
                }
                return new Cancion[0];
            }
            else
            {
                Console.WriteLine("Error de Criterio");
                return new Cancion[0];
            }





        }
    }
}
