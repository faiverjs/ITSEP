using System.ComponentModel.DataAnnotations.Schema;

namespace ITSEP.Models.DTO
{
    public class UserInsertDto
    {
        public string UserTypeDocument { get; set; }

        public long UserIdentification { get; set; }

        public string UserNames { get; set; }
    }
}
