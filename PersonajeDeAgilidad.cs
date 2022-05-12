using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    class PersonajeDeAgilidad : Personaje, IMoverse

    {
        public PersonajeDeAgilidad(string nombre, int agilidad, int magia, int fuerza)
        {
            Fuerza = fuerza;
            Nombre = nombre;
            Magia = magia;
            Agilidad = agilidad;
        }

        public override float CalcularDanio()
        {
            return (Fuerza / 2) * Agilidad * (Magia / 2);
        }
        public int MoverseEjeX()
        {
            return 1;
        }

        public int MoverseEjeY()
        {
            return 4;
        }
    }
}
