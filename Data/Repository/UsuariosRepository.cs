using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ActuArteContext _context;

        public UsuariosRepository(ActuArteContext context)
        {
            _context = context;
        }

        public List<Usuarios> GetAll()
        {

            return _context.Usuarios.ToList();

        }
        public Usuarios Get(int id)
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(usuarios => usuarios.idUsuario == id);
        }
        public void Add(Usuarios usuarios)
        {
            usuarios.isAdmin = false;
            _context.Usuarios.Add(usuarios);
            _context.SaveChanges();
        }

        public void Update(Usuarios usuarios)
        {

            _context.Entry(usuarios).State = EntityState.Modified;
            _context.SaveChanges();

        }


        public void Delete(int Id)
        {
            var exist = _context.Usuarios.Any(usuarios => usuarios.idUsuario == Id);
            if (exist != null)
            {
                var usuarios = _context.Usuarios.FirstOrDefault(usuarios => usuarios.idUsuario == Id);
                _context.Usuarios.Remove(usuarios);
                _context.SaveChanges();
            }
        }
    }
}