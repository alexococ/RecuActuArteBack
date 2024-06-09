using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class ObrasRepository : IObrasRepository
    {
        private readonly ActuArteContext _context;

        public ObrasRepository(ActuArteContext context)
        {
            _context = context;
        }

        public List<Obras> GetAll()
        {

            return _context.Obras.ToList();
        }

        public Obras Get(int id)
        {
            return _context.Obras.AsNoTracking().FirstOrDefault(obras => obras.idObra == id);
        }

        public void Add(Obras obras)
        {
            _context.Obras.Add(obras);
            _context.SaveChanges();
        }

        public void Update(Obras obras)
        {

            _context.Entry(obras).State = EntityState.Modified;
            _context.SaveChanges();

        }


        public void Delete(int Id)
        {
            var exist = _context.Obras.Any(obras => obras.idObra == Id);
            if (exist != null)
            {
                var obras = _context.Obras.FirstOrDefault(obras => obras.idObra == Id);
                _context.Obras.Remove(obras);
                _context.SaveChanges();
            }
        }

        public void AddObra(int obraId, int sesionId, int idAsiento)
        {

            var nuevoAsiento = new AsientosGuardados
            {
                idObra = obraId,
                idSesion = sesionId,
                idAsiento = idAsiento,
            };

            _context.AsientosObrasDatos.Add(nuevoAsiento);
            _context.SaveChanges();

        }

        public List<int> GetObrasAsientos(int obraId, int sesionId)
        {

                var asientosId = _context.AsientosObrasDatos
                    .Where(id => id.idObra == obraId && id.idSesion == sesionId)
                    .Select(p => p.idAsiento)
                    .ToList();

                return asientosId;

        }


        public List<Obras> GetAclamadas() => _context.Obras.Where(o => o.aclamadas).ToList();

        public List<Obras> GetRecientes() => _context.Obras.Where(o => o.recientes).ToList();

        public List<Obras> GetUltimasSesiones() => _context.Obras.Where(o => o.ultimasSesiones).ToList();

    }
}