using ITSEP.Models.DTO;
using ITSEP.Services.Interfaces;
using System.Text.Json;

namespace ITSEP.Services
{
    public class PostServices : IPostServices
    {
        private HttpClient _httpClient;

        public PostServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PostDto>> Get()
        {
            var result = await _httpClient.GetAsync(_httpClient.BaseAddress);
            var body  = await result.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var post = JsonSerializer.Deserialize<IEnumerable<PostDto>>(body, options);


            return post;
        }
    }
}
