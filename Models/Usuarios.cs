using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models
{

public class Usuarios
{
    public Usuarios()
    { }

    [Key]
    public int idUsuario { get; set; }

    public bool isAdmin{ get; set; }

    [Required]
    public string? nombreUsuario { get; set; }

    [Required]
    public string? passwordUsuario { get; set; }
}



}



