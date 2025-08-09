using ITSEP.Models;
using ITSEP.Repositories.Interfaces;
using ITSEP.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ITSEP.Services
{
    public class EnviosDetailServices : IEnviosDetailServices
    {

        private readonly IEnviosDetailRepository enviosDetailRepository;

        public EnviosDetailServices(IEnviosDetailRepository enviosDetailRepository)
        {
            this.enviosDetailRepository = enviosDetailRepository;
        }

        public Task<IActionResult> EditarUsuarios => throw new NotImplementedException();

        public async Task<bool> DeleteEnviosDetails(Guid id)
        {
            return await enviosDetailRepository.DeleteEnviosDetails(id);
        }

        public async Task<EnviosDetails> GetEnviosDetails(Guid id)
        {
            return await enviosDetailRepository.GetEnviosDetails(id);
        }

        public async Task<EnviosDetails> PostEnviosDetails(EnviosDetails enviosDetails)
        {
            return await enviosDetailRepository.AddEnviosDetails(enviosDetails);
        }

        public async Task<EnviosDetails> PutEnviosDetails(EnviosDetails enviosDetails)
        {
            return await enviosDetailRepository.UpdateEnviosDetails(enviosDetails);
        }
    }
}
