using System.Dynamic;
using ActuArte.Models;

namespace ActuArte.Data
{
    public interface IUsuariosRepository
    {
        List<Usuarios> GetAll();
        Usuarios Get(int Id);
        void Add(Usuarios usuarios);
        void Delete(int Id);

        void Update(Usuarios usuarios);
        
    }
}