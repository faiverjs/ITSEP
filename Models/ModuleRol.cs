using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITSEP.Models
{
    [Table("Module_Rol", Schema = "dbo")]
    public class ModuleRol : IEntity
    {
        [Key]
        [Column("Module_Rol_Id")]
        public Guid Id { get; set; }

        [Column("db.modulemodule_id")]
        public Guid ModuleModuleId { get; set; }

        [Column("db.rolrol_id")]
        public Guid RolRolId { get; set; }

        public ModuleRol() { }

        public ModuleRol(Guid moduleModuleId, Guid rolRolId)
        {
            Id = Guid.NewGuid();
            ModuleModuleId = moduleModuleId;
            RolRolId = rolRolId;
        }
    }

}
