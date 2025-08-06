using ITSEP.Models;

namespace ITSEP.Services.Interfaces
{
    public interface IEnviosDetailServices
    {
        Task<EnviosDetails> GetEnviosDetails(Guid id);
        Task<EnviosDetails> PostEnviosDetails(EnviosDetails enviosDetails); // ← Devuelve el detalle creado
        Task<EnviosDetails> PutEnviosDetails(EnviosDetails enviosDetails);   // ← Devuelve el detalle actualizado
        Task<bool> DeleteEnviosDetails(Guid id);                             // ← true si se eliminó, false si no existe
    }
}
