namespace new_bs_integra.Models
{
    public class UserToken
    {
        public string UserName { get; set; }
        public string User { get; set; }
        public bool Authenticated { get; set; }
        public DateTime Expiration { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
        public byte AccessPermissions { get; set; }
    }
}
