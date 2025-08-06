using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITSEP.Models
{
    [Table("Rol", Schema = "dbo")]
    public class Rol : IEntity
    {
        [Key]
        [Column("rol_id")]
        public Guid Id { get; set; }

        [Column("nombre_rol")]
        public int? NombreRol { get; set; }

        public Rol() { }

        public Rol(int? nombreRol)
        {
            Id = Guid.NewGuid();
            NombreRol = nombreRol;
        }
    }

}
