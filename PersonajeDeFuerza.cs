using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
     class PersonajeDeFuerza : Personaje, IMoverse
    {   
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
        {
            Fuerza = 100;
            Nombre = nombre;
            Magia = magia;
            Agilidad = agilidad;
        }

        public override float CalcularDanio()
        {
           return Fuerza * Agilidad *(Magia/3);
        }

        public int MoverseEjeX()
        {
            return 3;
        }

        public int MoverseEjeY()
        {
            return 2;
        }
    }
}
