using System.Collections.Generic;
using ActuArte.Models;
using System.Threading.Tasks;

namespace ActuArte.Business
{
    public interface ICredentialsService
    {
        Usuarios Authenticate(UsuariosDTO usuariosDTO);
    }
}