using ITSEP.Models;
using ITSEP.Repositories.Interfaces;
using ITSEP.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ITSEP.Services
{
    public class UsuariosServices : IUsuariosServices
    {
        private readonly IUsuariosRepository usuariosRepository;

        public UsuariosServices(IUsuariosRepository usuariosRepository)
        {
            this.usuariosRepository = usuariosRepository;
        }

        public async Task<Usuario> GetUsuario(Guid id)
        {
            return await usuariosRepository.GetUsuarios(id);
        }

        public async Task<Usuario> GetUsuarioIdentification(long userIdentification)
        {
            return await usuariosRepository.GetUsuariosbyIdentification(userIdentification);
        }

        public async Task<Usuario> PostUsuarios(Usuario usuario)
        {
            return await usuariosRepository.AddUsuario(usuario);
        }

        public async Task<Usuario> PutUsuarios(Usuario usuario)
        {
            return await usuariosRepository.UpdateUsuario(usuario);
        }

        public async Task<bool> DeleteUsuarios(Guid id)
        {
            return await usuariosRepository.DeleteUsuario(id);
        }
    }
}
