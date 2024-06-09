using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models;

public class AsientosDTO
{
    public int idAsiento { get; set; }

    public bool estaOcupado { get; set; }

}