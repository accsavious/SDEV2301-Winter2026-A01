namespace AuthDemo.Services
{
    public class AuthService
    {
        public string? CurrentUser { get; private set; }

        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        public bool Login(string username, string password)
        {
            if (username == "user" && password == "pass")
            {
                CurrentUser = username;
                return true;
            }
            return false;
        }
        public void Logout() => CurrentUser = null;
    }
}
