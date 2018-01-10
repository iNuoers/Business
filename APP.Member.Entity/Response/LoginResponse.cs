

namespace APP.Member.Entity.Response
{
    public class LoginResponse
    {
        public string Token { get; set; }

        public string LastLogTime { get; set; }

        public string LastLogDevice { get; set; }

        public int ClientVerify { get; set; }
    }
}