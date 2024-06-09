using System.Dynamic;
using ActuArte.Models;

namespace ActuArte.Data
{
    public interface ICredentialsRepository
    {
        Usuarios GetByUsername(UsuariosDTO usuariosDTO);
    }
}