using ITSEP.Models.DTO;

namespace ITSEP.Services.Interfaces
{
    public interface IPostServices
    {
        public Task<IEnumerable<PostDto>> Get();
    }
}
