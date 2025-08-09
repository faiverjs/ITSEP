using ITSEP.Models;
using ITSEP.Repositories;
using ITSEP.Repositories.Interfaces;
using ITSEP.Services.Interfaces;
using ITSEP.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> EditarUsuarios(Usuario usuario)
        {
            Usuario  user = await usuariosRepository.GetUsuarios((Guid) usuario.Id);
            if (user == null) throw new ArgumentException("Usuario no encontrado");
            user.UserTypeDocument = usuario.UserTypeDocument;
            user.UserIdentification = usuario.UserIdentification;
            user.UserNames = usuario.UserNames;
            user.UserEmail = usuario.UserEmail;
            user.UserPhone = usuario.UserPhone;
            user.UserLogin = usuario.UserLogin;
            user.UserPassword = usuario.UserPassword;
            user.UserStatus = usuario.UserStatus;
            user.UserSso = usuario.UserSso;
            user.UserSsoId = usuario.UserSsoId;

            await usuariosRepository.Update(user);
            return await Task.FromResult(new OkObjectResult(new { Status = TypeStatus.SUCCESS.ToString() }));
        }
    }
}
