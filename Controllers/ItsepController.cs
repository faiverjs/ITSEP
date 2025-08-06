using ITSEP.Models;
using ITSEP.Repositories.Interfaces;
using ITSEP.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ITSEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItsepController : ControllerBase
    {
        private readonly ItsepDbContext ItsepDbContext;
        private readonly IUsuariosRepository UsuariosRepository;
        private readonly IUsuariosServices UsuariosServices;
        private readonly IEnviosServices EnviosServices;
        private readonly IEnviosRepository EnviosRepository;
        private readonly IEnviosDetailServices EnviosDetailServices;
        private readonly IEnviosDetailRepository enviosDetailRepository;

        public ItsepController(ItsepDbContext ItsepDbContext,
                               IUsuariosServices usuariosServices,
                               IUsuariosRepository usuariosRepository,
                               IEnviosServices enviosServices,
                               IEnviosRepository enviosRepository,
                               IEnviosDetailServices enviosDetailServices,
                               IEnviosDetailRepository enviosDetailRepository )
        {
            this.ItsepDbContext = ItsepDbContext;
            this.UsuariosServices = usuariosServices;
            this.UsuariosRepository = usuariosRepository;
            this.EnviosServices = enviosServices;
            this.EnviosRepository = enviosRepository;
            this.EnviosDetailServices = enviosDetailServices;
            this.enviosDetailRepository = enviosDetailRepository;
        }

        // ====================== Controladores Usuarios ======================

        [HttpGet("Usuarios")]
        public async Task<Usuario> GetUsuariosByIdentificacion([FromQuery] long UserIdentification)
        {
            return await UsuariosServices.GetUsuarioIdentification(UserIdentification);
        }

        [HttpGet("UsuariosById")]
        public async Task<Usuario> GetUsuarioById([FromQuery] Guid id)
        {
            return await UsuariosServices.GetUsuario(id);
        }

        [HttpPost("Usuarios")]
        public async Task<Usuario> PostUsuarios([FromBody] Usuario usuario)
        {
            return await UsuariosServices.PostUsuarios(usuario);
        }

        [HttpPut("Usuarios")]
        public async Task<Usuario> PutUsuarios([FromBody] Usuario usuario)
        {
            return await UsuariosServices.PutUsuarios(usuario);
        }

        [HttpDelete("Usuarios")]
        public async Task<bool> DeleteUsuarios([FromQuery] Guid id)
        {
            return await UsuariosServices.DeleteUsuarios(id);
        }


        // ====================== Controladores Envios ======================


        [HttpGet("Envios")]
        public async Task<Envios> GetEnviosById([FromQuery] Guid id)
        {
            return await EnviosServices.GetEnvios(id);
        }

        [HttpPost("Envios")]
        public async Task<Envios> PostEnvios([FromBody] Envios envios)
        {
            return await EnviosServices.PostEnvios(envios);
        }

        [HttpPut("Envios")]
        public async Task<Envios> PutEnvios([FromBody] Envios envios)
        {
            return await EnviosServices.PutEnvios(envios);
        }

        [HttpDelete("Envios")]
        public async Task<bool> DeleteEnvios([FromQuery] Guid id)
        {
            return await EnviosServices.DeleteEnvios(id);
        }

        // ====================== Controladores Envios ======================

        [HttpGet("Detalle_Envios")]
        public async Task<EnviosDetails> GetEnviosDetailsById ([FromQuery] Guid id)
        {
            return await EnviosDetailServices.GetEnviosDetails(id);
        }

        [HttpPost("Detalle_Envios")]
        public async Task<EnviosDetails> PostDetalleEnvios([FromBody] EnviosDetails enviosDetails)
        {
            return await EnviosDetailServices.PostEnviosDetails(enviosDetails);
        }

        [HttpPut("Detalle_Envios")]
        public async Task<EnviosDetails> PutDetalleEnvios([FromBody] EnviosDetails enviosDetails)
        {
            return await EnviosDetailServices.PutEnviosDetails(enviosDetails);
        }

        [HttpDelete("Detalle_Envios")]
        public async Task<bool> DeleteEnviosDetailsById([FromQuery] Guid id)
        {
            return await EnviosDetailServices.DeleteEnviosDetails(id);
        }

    }
}
