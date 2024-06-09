using ActuArte.Models;
using ActuArte.Data;
namespace ActuArte.Business
{
    public class AsientosService : IAsientosRepository
    {
        private readonly IAsientosRepository _asientoRepository;

        public AsientosService(IAsientosRepository asientosRepository)
        {
            _asientoRepository = asientosRepository;
        }
        public List<Asientos> GetAll() => _asientoRepository.GetAll();
        public Asientos Get(int Id) => _asientoRepository.Get(Id);

        public void Update(Asientos asientos) => _asientoRepository.Update(asientos);
    }
}