using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models;

public class ObrasDTO
{
    public int idObra { get; set; }

    public string? nombreObra { get; set; }

    public string? imagen { get; set; }

    public string? descObra { get; set; }

    public double valoracionObra { get; set; }

    public string? autorObra { get; set; }

    public string? directorObra { get; set; }

    public int duracionObra { get; set; }
}