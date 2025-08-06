using ITSEP.Models;
using ITSEP.Repositories.Interfaces;
using ITSEP.Services.Interfaces;

namespace ITSEP.Services
{
    public class EnviosServices : IEnviosServices
    {
        private readonly IEnviosRepository enviosRepository;

        public EnviosServices(IEnviosRepository enviosRepository)
        {
            this.enviosRepository = enviosRepository;
        }



        public async Task<Envios> GetEnvios(Guid id)
        {
            return await enviosRepository.GetEnvios(id);
        }

        public async Task<Envios> PostEnvios(Envios envios)
        {
            return await enviosRepository.AddEnvios(envios);
        }

        public async Task<Envios> PutEnvios(Envios envios)
        {
            return await enviosRepository.UpdateEnvios(envios);
        }

        public async Task<bool> DeleteEnvios(Guid id)
        {
            return await enviosRepository.DeleteEnvios(id);
        }
    }
}
