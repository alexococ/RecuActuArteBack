using ActuArte.Models;
using ActuArte.Data;

namespace ActuArte.Business
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuarioRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuarioRepository = usuariosRepository;
        }
        public List<Usuarios> GetAll() => _usuarioRepository.GetAll();
        public Usuarios Get(int Id) => _usuarioRepository.Get(Id);
        public void Add(Usuarios usuarios) => _usuarioRepository.Add(usuarios);

        public void Delete(int Id) => _usuarioRepository.Delete(Id);

        public void Update(Usuarios usuarios) => _usuarioRepository.Update(usuarios);
        

        
    }
}