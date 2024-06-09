using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models;

public class Asientos
{

    public Asientos() { }

    [Key]
    public int idAsiento { get; set; }

    [Required]
    public bool estaOcupado { get; set; }



}

