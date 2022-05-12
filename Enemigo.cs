using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
     public class Enemigo : IMoverse
    { 
        public string nombre { get; set; }
        public float vida { get; set; }
        public int nivel { get; set; }

        public Enemigo(string nombre, float vida, int nivel)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.nivel = nivel;
        }
        public int MoverseEjeX()
        {
            return 2;
        }

        public int MoverseEjeY()
        {
            return 4;
        }
    }
}
