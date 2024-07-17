using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herencia_POO.Models;

public class PersonalTecnico
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string TipoDocumento { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string RH { get; set; }
    public string TallaSuperior { get; set; }
    public string TallaInferior { get; set; }
    public string TallaZapatos { get; set; }

   
   //CALCULAR EDAD 
    public int CalcularEdad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }
}
