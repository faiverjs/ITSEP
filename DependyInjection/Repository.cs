using ITSEP.Services.Interfaces;
using ITSEP.Services;
using ITSEP.Repositories.Interfaces;
using ITSEP.Repositories;

namespace ITSEP.DependyInjection
{
    public class Repository
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddScoped<IUsuariosRepository, UsuariosRepository>();
            services.AddScoped<IUsuariosServices, UsuariosServices>();
            services.AddScoped<IEnviosRepository, EnviosRepository>();
            services.AddScoped<IEnviosServices, EnviosServices>();
            services.AddScoped<IEnviosDetailRepository, EnviosDetailRepository>();
            services.AddScoped<IEnviosDetailServices, EnviosDetailServices>();
        }


    }
}
