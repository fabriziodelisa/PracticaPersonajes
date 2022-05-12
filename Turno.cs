using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes, Enemigo enemigo)
        {
            foreach (Personaje personaje in personajes)
            {
                personaje.Atacar();
                enemigo.vida = enemigo.vida - personaje.CalcularDanio();
                Console.WriteLine($"A {enemigo.nombre} le quedan {enemigo.vida} pts de vida");
            };
        }
        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
    }
}
