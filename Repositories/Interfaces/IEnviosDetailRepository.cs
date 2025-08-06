using ITSEP.Models;

namespace ITSEP.Repositories.Interfaces
{
    public interface IEnviosDetailRepository
    {
        Task<EnviosDetails> GetEnviosDetails(Guid id);
        Task<EnviosDetails> AddEnviosDetails(EnviosDetails enviosDetails);
        Task<EnviosDetails> UpdateEnviosDetails(EnviosDetails enviosDetails);
        Task<bool> DeleteEnviosDetails(Guid id);
    }
}
