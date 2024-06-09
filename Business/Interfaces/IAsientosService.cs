using System.Collections.Generic;
using ActuArte.Models;
using System.Threading.Tasks;

namespace ActuArte.Business
{
    public interface IAsientosService
    {
        List<Asientos> GetAll();
        Asientos? Get(int Id);

        void Update(Asientos asientos);

    }
}