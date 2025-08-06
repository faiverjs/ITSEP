
using ITSEP.Models;
using ITSEP.Repositories.Interfaces;

namespace ITSEP.Repositories
{
    public class EnviosDetailRepository : Repository<EnviosDetails>, IEnviosDetailRepository
    {
        public EnviosDetailRepository(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor) : base(serviceProvider, httpContextAccessor)
        {
        }
        public async Task<EnviosDetails> GetEnviosDetails(Guid id)
        {
            var result = (from db in context.Set<EnviosDetails>()
                          where db.Id == id
                          select db).FirstOrDefault();
            return result;
        }


        public async Task<EnviosDetails> AddEnviosDetails(EnviosDetails enviosDetails)
        {
           enviosDetails.Id = Guid.NewGuid(); // Generar un nuevo GUID
            context.Set<EnviosDetails>().Add(enviosDetails);
            await context.SaveChangesAsync();
            return enviosDetails;
        }

        
        public async Task<EnviosDetails> UpdateEnviosDetails(EnviosDetails enviosDetails)
        {
            var existing = (from db in context.Set<EnviosDetails>()
                            where db.Id == enviosDetails.Id
                            select db).FirstOrDefault();

            existing.EnviosId = enviosDetails.EnviosId;
            existing.Provincia = enviosDetails.Provincia;
            existing.Ciudad = enviosDetails.Ciudad;
            existing.CallePrincipal = enviosDetails.CallePrincipal;
            existing.CalleSecundaria = enviosDetails.CalleSecundaria;
            existing.Referencia = enviosDetails.Referencia;

            context.Set<EnviosDetails>().Update(existing);
            await context.SaveChangesAsync();
            return existing;
        }
        public async Task<bool> DeleteEnviosDetails(Guid id)
        {
            var existing = (from db in context.Set<EnviosDetails>()
                            where db.Id == id
                            select db).FirstOrDefault();
            if (existing == null)
                return false;
            context.Set<EnviosDetails>().Remove(existing);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
