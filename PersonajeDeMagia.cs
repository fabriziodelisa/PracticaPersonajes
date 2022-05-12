using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    class PersonajeDeMagia : Personaje, IMoverse
    {
        public PersonajeDeMagia(string nombre, int agilidad, int fuerza, int magia)
        {
            Fuerza = fuerza;
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int agilidad, int fuerza)
        {
            Fuerza = fuerza;
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = 60;
        }

        public override float CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia");
        }

        public int MoverseEjeX()
        {
            return 1;
        }

        public int MoverseEjeY()
        {
            return 3;
        }
    }
}
