using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITSEP.Models
{
    [Table("Modules", Schema = "dbo")]
    public class Modules : IEntity
    {
        [Key]
        [Column("module_id")]
        public Guid Id { get; set; }

        [Column("module_key")]
        public string ModuleKey { get; set; }

        [Column("module_url")]
        public string ModuleUrl { get; set; }

        [Column("module_icon")]
        public string ModuleIcon { get; set; }

        [Column("module_status")]
        public string ModuleStatus { get; set; }

        [Column("module_visible")]
        public bool? ModuleVisible { get; set; }

        [Column("module_sequential")]
        public int? ModuleSequential { get; set; }

        [Column("module_createat")]
        public DateTime? ModuleCreateAt { get; set; }

        [Column("module_descricion")]
        public string ModuleDescricion { get; set; }

        public Modules() { }

        public Modules(string moduleKey, string moduleUrl, string moduleIcon, string moduleStatus, bool? moduleVisible, int? moduleSequential, DateTime? moduleCreateAt, string moduleDescricion)
        {
            Id = Guid.NewGuid();
            ModuleKey = moduleKey;
            ModuleUrl = moduleUrl;
            ModuleIcon = moduleIcon;
            ModuleStatus = moduleStatus;
            ModuleVisible = moduleVisible;
            ModuleSequential = moduleSequential;
            ModuleCreateAt = moduleCreateAt;
            ModuleDescricion = moduleDescricion;
        }
    }

}
