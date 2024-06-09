using System.Collections.Generic;
using ActuArte.Models;
using System.Threading.Tasks;

namespace ActuArte.Business
{
    public interface IUsuariosService
    {
        List<Usuarios> GetAll();

        Usuarios? Get(int Id);
        void Update(Usuarios usuarios);
        void Add(Usuarios usuarios);
        void Delete(int id);
        
    }
}