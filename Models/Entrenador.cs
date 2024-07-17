using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herencia_POO.Models;

public class Entrenador
{
    public Byte ExperienciaEnAños { get; set; }
    public Byte CantidadTitulos { get; set; }
    private double Salario { get; set; }
    public string Nacionalidad { get; set; }
    
    public Entrenador ()
    {
        Console.WriteLine("ESTE ES EL CONSTRUCTOR DEL ENTRENADOR");
    }
}
