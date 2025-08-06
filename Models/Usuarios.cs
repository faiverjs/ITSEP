using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITSEP.Models
{
    [Table("Usuarios", Schema = "dbo")]
    public class Usuario : IEntity
    {
        [Key]
        [Column("usuario_id")]
        public Guid Id { get; set; }

        [Column("user_typeDocument")]
        public string UserTypeDocument { get; set; }

        [Column("user_identification")]
        public long UserIdentification { get; set; }

        [Column("user_names")]
        public string UserNames { get; set; }

        [Column("user_email")]
        public string? UserEmail { get; set; } // ← Cambiado a nullable

        [Column("user_phone")]
        public long UserPhone { get; set; }

        [Column("user_login")]
        public string UserLogin { get; set; }

        [Column("user_password")]
        public string UserPassword { get; set; }

        [Column("user_status")]
        public bool? UserStatus { get; set; }

        [Column("user_Sso")]
        public string? UserSso { get; set; } // ← Cambiado a nullable

        [Column("user_SsoId")]
        public string? UserSsoId { get; set; } // ← Cambiado a nullable

        public Usuario() { }

        public Usuario(Usuario usuario)
        {
            Id = Guid.NewGuid();
            UserTypeDocument = usuario.UserTypeDocument;
            UserIdentification = usuario.UserIdentification;
            UserNames = usuario.UserNames;
            UserEmail = usuario.UserEmail;
            UserPhone = usuario.UserPhone;
            UserLogin = usuario.UserLogin;
            UserPassword = usuario.UserPassword;
            UserStatus = usuario.UserStatus;
            UserSso = usuario.UserSso;
            UserSsoId = usuario.UserSsoId;
        }
    }
}
