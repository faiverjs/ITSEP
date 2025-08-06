using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITSEP.Models
{
    [Table("Envios", Schema = "dbo")]
    public class Envios : IEntity
    {
        [Key]
        [Column("envios_id")]
        public Guid Id { get; set; }

        [Column("usuario_id")]
        public Guid UsuarioId { get; set; }

        [Column("envios_price")]
        public decimal? EnviosPrice { get; set; }

        [Column("envios_date_arrive")]
        public DateTime EnviosDateArrive { get; set; }

        [Column("envios_date_end")]
        public DateTime EnviosDateEnd { get; set; }

        [Column("usuario_registo_id")]
        public Guid UsuarioRegistoId { get; set; }

        [Column("db.enviosDetailsed_id")]
        public string EnviosDetailsedId { get; set; }

        [Column("db.envios_details_id")]
        public string EnviosDetailsId { get; set; }

        [Column("envios_status")]
        public bool? EnviosStatus { get; set; }
        
        public Envios() { }

        public Envios(Guid usuarioId, decimal? enviosPrice, DateTime enviosDateArrive, DateTime enviosDateEnd, Guid usuarioRegistoId, string enviosDetailsedId, string enviosDetailsId, bool? enviosStatus)
        {
            Id = Guid.NewGuid();
            UsuarioId = usuarioId;
            EnviosPrice = enviosPrice;
            EnviosDateArrive = enviosDateArrive;
            EnviosDateEnd = enviosDateEnd;
            UsuarioRegistoId = usuarioRegistoId;
            EnviosDetailsedId = enviosDetailsedId;
            EnviosDetailsId = enviosDetailsId;
            EnviosStatus = enviosStatus;
        }
    }

}
