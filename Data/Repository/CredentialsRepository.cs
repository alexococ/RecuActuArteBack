using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class CredentialsRepository : ICredentialsRepository
    {
        private readonly ActuArteContext _context;

        public CredentialsRepository(ActuArteContext context)
        {
            _context = context;
        }

        public Usuarios GetByUsername(UsuariosDTO usuariosDTO) 
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(usuarios => usuarios.nombreUsuario == usuariosDTO.nombreUsuario && usuarios.passwordUsuario == usuariosDTO.passwordUsuario);
        }
    }
}