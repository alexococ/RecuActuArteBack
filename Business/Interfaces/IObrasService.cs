using System.Collections.Generic;
using ActuArte.Models;
using System.Threading.Tasks;

namespace ActuArte.Business
{
    public interface IObrasService
    {
        List<Obras> GetAll();

        Obras? Get(int Id);
        void Update(Obras obras);
        void Add(Obras obras);
        void Delete(int id);
        void AddObra(int obraId, int sesionId, int idAsiento);

        List<int> GetObrasAsientos(int obraId, int sesionId);

        List<Obras> GetAclamadas();

        List<Obras> GetRecientes();

        List<Obras> GetUltimasSesiones();
    }
}