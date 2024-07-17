using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herencia_POO.Models;

public class Jugador: PersonalTecnico  // ESTO ES HACER LA HERENCIA
{

    public string Posición { get; set; }
    public double Estatura { get; set; }
    public double Peso { get; set; }
    public string ClubActual { get; set; }
    public string PieHabil { get; set; }

    public Jugador ()
    {
        Console.WriteLine("ESTE  ES EL CONSTRUCTOR DEL JUGADOR");
    }

    public double CalcularIMC()
    {
        return Peso / (Estatura * Estatura);
    }
}


