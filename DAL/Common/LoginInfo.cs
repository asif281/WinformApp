namespace BAL.Common
{

    public class LoginInfo
    {
        public string email { get; set; }
        public string password { get; set; }
        public string device_name { get; set; }

        public LoginInfo(string email, string password, string device_name)
        {
            this.email = email;
            this.password = password;
            this.device_name = device_name;
        }
    }
}