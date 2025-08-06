using ITSEP.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITSEP.Models
{
    [Table("EnviosDetails", Schema = "dbo")]
    public class EnviosDetails : IEntity
    {
        [Key]
        [Column("ed_id")]
        public Guid Id { get; set; }

        [Column("Envios_id")]
        public Guid EnviosId { get; set; }

        [Column("provincia")]
        public string Provincia { get; set; }

        [Column("ciudad")]
        public string Ciudad { get; set; }

        [Column("callePrincipal")]
        public string CallePrincipal { get; set; }

        [Column("calleSecundaria")]
        public string CalleSecundaria { get; set; }

        [Column("referencia")]
        public string Referencia { get; set; }

        public EnviosDetails() { }

        public EnviosDetails(Guid enviosId, string provincia, string ciudad, string callePrincipal, string calleSecundaria, string referencia)
        {
            Id = Guid.NewGuid();
            EnviosId = enviosId;
            Provincia = provincia;
            Ciudad = ciudad;
            CallePrincipal = callePrincipal;
            CalleSecundaria = calleSecundaria;
            Referencia = referencia;
        }
    }

}
