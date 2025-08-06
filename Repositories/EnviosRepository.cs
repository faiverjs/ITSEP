
using ITSEP.Models;
using ITSEP.Repositories.Interfaces;

namespace ITSEP.Repositories
{
    public class EnviosRepository : Repository<Envios>, IEnviosRepository
    {
        public EnviosRepository(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor) : base(serviceProvider, httpContextAccessor)
        {
        }
        public async Task<Envios> GetEnvios(Guid id)
        {
            var result = (from db in context.Set<Envios>()
                          where db.Id == id
                          select db).FirstOrDefault();
            return result;
        }
        public async Task<Envios> AddEnvios(Envios envios)
        {
            envios.Id = Guid.NewGuid(); // Generar un nuevo GUID
            context.Set<Envios>().Add(envios);
            await context.SaveChangesAsync();
            return envios;
        }
        public async Task<Envios> UpdateEnvios(Envios envios)
        {
            var existingEnvios = (from db in context.Set<Envios>()
                                  where db.Id == envios.Id
                                  select db).FirstOrDefault();

            if (existingEnvios == null)
                return null;

            
            existingEnvios.UsuarioId = envios.UsuarioId;
            existingEnvios.EnviosPrice = envios.EnviosPrice;
            existingEnvios.EnviosDateArrive = envios.EnviosDateArrive;
            existingEnvios.EnviosDateEnd = envios.EnviosDateEnd;
            existingEnvios.UsuarioRegistoId = envios.UsuarioRegistoId;
            existingEnvios.EnviosDetailsedId = envios.EnviosDetailsedId;
            existingEnvios.EnviosDetailsId = envios.EnviosDetailsId;
            existingEnvios.EnviosStatus = envios.EnviosStatus;

            await context.SaveChangesAsync();
            return existingEnvios;
        }


        public async Task<bool> DeleteEnvios(Guid id)
        {
            var usuario = (from db in context.Set<Envios>()
                           where db.Id == id
                           select db).FirstOrDefault();
            if (usuario == null)
                return false;
            context.Set<Envios>().Remove(usuario);
            await context.SaveChangesAsync();
            return true;
        }

        

       
    }
}
