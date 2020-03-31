using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Cancion
    {
        private string nombre;
        private string álbum;
        private string artista;
        private string género;
       
       
       



        public Cancion(string nombre, string álbum, string artista, string género)
        {
            this.nombre = nombre;
            this.álbum = álbum;
            this.género = género;
            this.artista = artista;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Álbum
        {
            get { return álbum; }
            set { álbum = value; }
        }
        public string Género
        {
            get { return género; }
            set { género = value; }
        }
        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public String Informacion()
        {
            
            return $" genero: {género}, artista: {artista}, album: {álbum}, Nombre: {nombre}";
            
            
        }
        
    }

}
