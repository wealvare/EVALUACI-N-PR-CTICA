using Microsoft.EntityFrameworkCore;
using WebAPP_Wilber_Alvarez_26._11._05.Data;
using WebAPP_Wilber_Alvarez_26._11._05.models;

namespace WebAPP_Wilber_Alvarez_26._11._05.repository
{
    public class UsuarioRepository
    {
        public readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> Get(int id)
        {
            return await _context.Usuarios.AsNoTracking()
                .FirstOrDefaultAsync(c => c.UserId == id);
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _context.Usuarios.AsNoTracking().ToListAsync();
        }

        public async Task<Usuario> Save(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> Actualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<bool> Delete(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return false;
            }
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return true;
        }
    }
}
