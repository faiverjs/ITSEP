using ITSEP.DependyInjection;
using ITSEP.Models;
using ITSEP.Repositories.Interfaces;

namespace ITSEP.Repositories
{
    public class UsuariosRepository : Repository<Usuario>, IUsuariosRepository
    {
        public UsuariosRepository(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor)
            : base(serviceProvider, httpContextAccessor)
        {
        }

        public async Task<Usuario> GetUsuarios(Guid id)
        {
            var result = (from db in context.Set<Usuario>()
                          where db.Id == id
                          select db).FirstOrDefault();
            return result;
        }

        public async Task<Usuario> GetUsuariosbyIdentification(long UserIdentification)
        {
            var result = (from db in context.Set<Usuario>()
                          where db.UserIdentification == UserIdentification
                          select db).FirstOrDefault();
            return result;
        }

        public async Task<Usuario> AddUsuario(Usuario usuario)
        {
            usuario.Id = Guid.NewGuid(); // Generar un nuevo GUID
            context.Set<Usuario>().Add(usuario);
            await context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> UpdateUsuario(Usuario usuario)
        {
            var existing = (from db in context.Set<Usuario>()
                            where db.Id == usuario.Id
                            select db).FirstOrDefault();

            if (existing == null)
                return null;

            // Actualizar los campos manualmente
            existing.UserTypeDocument = usuario.UserTypeDocument;
            existing.UserIdentification = usuario.UserIdentification;
            existing.UserNames = usuario.UserNames;
            existing.UserEmail = usuario.UserEmail;
            existing.UserPhone = usuario.UserPhone;
            existing.UserLogin = usuario.UserLogin;
            existing.UserPassword = usuario.UserPassword;
            existing.UserStatus = usuario.UserStatus;
            existing.UserSso = usuario.UserSso;
            existing.UserSsoId = usuario.UserSsoId;

            context.Set<Usuario>().Update(existing);
            await context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteUsuario(Guid id)
        {
            var usuario = (from db in context.Set<Usuario>()
                           where db.Id == id
                           select db).FirstOrDefault();

            if (usuario == null)
                return false;

            context.Set<Usuario>().Remove(usuario);
            await context.SaveChangesAsync();

            return true;
        }
    }
}
