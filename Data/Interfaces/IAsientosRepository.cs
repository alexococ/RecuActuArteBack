using System.Dynamic;
using ActuArte.Models;

namespace ActuArte.Data
{
    public interface IAsientosRepository
    {
        List<Asientos> GetAll();
        Asientos Get(int Id);
        void Update(Asientos asientos);

    }
}
