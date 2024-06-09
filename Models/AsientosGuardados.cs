using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models;

public class AsientosGuardados
{
    public AsientosGuardados()
    { }

    [Key]
    public int idObjeto { get; set; }

    public int idObra { get; set; }
    
    public int idSesion { get; set; }

    
    public int idAsiento { get; set; }


}

