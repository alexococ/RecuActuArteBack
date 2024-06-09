using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models
{
    public class LoginModel
    {

        [Required]
        public string? nombreUsuario { get; set; }

        [Required]
        public string? passwordUsuario { get; set; }

        public bool isAdmin { get; set; }


    }
}
