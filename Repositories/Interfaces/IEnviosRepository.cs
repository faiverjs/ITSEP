using ITSEP.Models;

namespace ITSEP.Repositories.Interfaces
{
    public interface IEnviosRepository : IRepository<Envios>

    {
        
        Task<Envios> GetEnvios(Guid id);
        // POST
        Task<Envios> AddEnvios(Envios envios);
        // PUT
        Task<Envios> UpdateEnvios(Envios envios);
        // DELETE
        Task<bool> DeleteEnvios(Guid id);
    }
}
