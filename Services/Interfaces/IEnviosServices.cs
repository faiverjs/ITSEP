using ITSEP.Models;

namespace ITSEP.Services.Interfaces
{
    public interface IEnviosServices
    {
        Task<Envios> GetEnvios(Guid id);
        Task<Envios> PostEnvios(Envios envios);  
        Task<Envios> PutEnvios(Envios envios);
        Task<bool> DeleteEnvios(Guid id);
    }
}
