
using Personajes;

List<Personaje> personajes = new ();

PersonajeDeFuerza Grandote = new("Grandote", 30, 70);
PersonajeDeAgilidad Rapidon = new("Rapidón", 100, 20, 50);
PersonajeDeMagia Merlin = new("Merlín", 60, 30, 75);

Enemigo Malevo = new("Malevo", 100000, 78);

personajes.Add(Grandote);
personajes.Add(Rapidon);
personajes.Add(Merlin);

Turno.Atacarse(personajes, Malevo);

Turno.MoverFichas(Grandote);
Turno.MoverFichas(Rapidon);
Turno.MoverFichas(Merlin);
