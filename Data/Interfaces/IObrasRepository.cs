using System.Dynamic;
using ActuArte.Models;

namespace ActuArte.Data
{
    public interface IObrasRepository
    {
        List<Obras> GetAll();

        Obras Get(int Id);
        void Add(Obras obras);
        void Delete(int Id);

        void Update(Obras obras);

        void AddObra(int obraId, int sesionId, int idAsiento);

        List<int> GetObrasAsientos(int obraId, int sesionId);

        List<Obras> GetAclamadas();

        List<Obras> GetRecientes();

        List<Obras> GetUltimasSesiones();
    }
}
