
using System.Text;
using SuperHeroeApp.Models;

var regenaracion = new SuperPoder();
regenaracion.Nombre = "Regeneración";
regenaracion.Nivel = NivelPoder.NivelTres;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de poder planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();
var superman2 = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "    Superman   ";
superman.IdentidadSecreta = "Clark Kent";
superman.PuedeVolar = true;

/*
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.PuedeVolar = true;

Console.WriteLine(superman == superman2);
*/

SuperHeroeRecord recordSuperman = new(1, "Superman", "Clack Kent");
SuperHeroeRecord recordSuperman2 = new(1, "Superman2", "Clack Kent");

//Console.WriteLine(recordSuperman == recordSuperman2);
List<SuperPoder> superpoderesSuperman = new List<SuperPoder>();
superpoderesSuperman.Add(superFuerza);
superpoderesSuperman.Add(poderVolar);
superman.SuperPoderes = superpoderesSuperman;
string resultadoPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultadoPoderes);
//Console.WriteLine(superman.IdentidadSecreta);

/*Antiheroe*/
var wolvering = new AntiHeroe();
wolvering.Id = 5;
wolvering.Nombre = "Wolverine";
wolvering.IdentidadSecreta = "Logan";
List<SuperPoder> superpoderWolvering = new List<SuperPoder>();
superpoderWolvering.Add(superFuerza);
superpoderWolvering.Add(regenaracion);
string resultadoWolveringPoderes = wolvering.UsarSuperPoderes();
//Console.WriteLine(resultadoWolveringPoderes);
string accionAntiheroe = wolvering.RealizarAccionDEAntiheroe("Ataca a la policia");
Console.WriteLine(accionAntiheroe);


enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroeRecord (int Id, String Nombre, string IdentidadSecreta);