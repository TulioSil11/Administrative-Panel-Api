using Newtonsoft.Json;

namespace new_bs_integra.DTOs
{
    public class UserDto
    {
        [JsonRequired]        
        public string UserName { get; set; }
        [JsonRequired]
        public string Password { get; set; }
    }
}
