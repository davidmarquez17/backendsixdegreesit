using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Negocio
{
    public class GestorUsuarios : IGestorUsuarios
    {
        private readonly CrudContext _context;

        public GestorUsuarios(CrudContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}