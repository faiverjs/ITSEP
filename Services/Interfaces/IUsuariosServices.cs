using ITSEP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITSEP.Services.Interfaces
{
    public interface IUsuariosServices
    {
        Task<Usuario> GetUsuario(Guid id);
        Task<Usuario> GetUsuarioIdentification(long userIdentification);
        Task<Usuario> PostUsuarios(Usuario usuario);     // ← Devuelve el usuario creado
        Task<Usuario> PutUsuarios(Usuario usuario);      // ← Devuelve el usuario actualizado
        Task<bool> DeleteUsuarios(Guid id);              // ← true si se eliminó, false si no existe
        Task<IActionResult> EditarUsuarios(Usuario usuario);
    }

}
