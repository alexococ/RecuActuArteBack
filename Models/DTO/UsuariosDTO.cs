using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models;

public class UsuariosDTO
{
    public string? nombreUsuario { get; set; }

    public string? passwordUsuario { get; set; }

}