using ITSEP.DependyInjection;
using ITSEP.Models;

namespace ITSEP.Repositories.Interfaces
{
    public interface IUsuariosRepository : IRepository<Usuario>
    {
        // GETs personalizados
        Task<Usuario> GetUsuariosbyIdentification(long UserIdentification);
        Task<Usuario> GetUsuarios(Guid id);

        // POST
        Task<Usuario> AddUsuario(Usuario usuario);

        // PUT
        Task<Usuario> UpdateUsuario(Usuario usuario);

        // DELETE
        Task<bool> DeleteUsuario(Guid id);
    }
}

