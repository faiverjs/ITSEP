using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITSEP.Models
{
    [Table("Rol_Usuario", Schema = "dbo")]
    public class RolUsuario : IEntity
    {
        [Key]
        [Column("Rol_Usuario_Id")]
        public Guid Id { get; set; }

        [Column("db.rolrol_id")]
        public Guid RolRolId { get; set; }

        [Column("db.usuariousuario_id")]
        public Guid UsuarioUsuarioId { get; set; }

        public RolUsuario() { }

        public RolUsuario(Guid Id, Guid usuarioUsuarioId)
        {
            Id = Guid.NewGuid();
            RolRolId = Id;
            UsuarioUsuarioId = usuarioUsuarioId;
        }
    }
}

