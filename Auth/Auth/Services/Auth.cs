namespace Auth.Services
{
    public class AuthService
    {
        public string? CurrentUser { get; private set; }

        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        public bool Login(string username, string password)
        {
            if (username == "user2301" && password == "Password2301")
            {
                CurrentUser = username;
                return true;
            }
            return false;
        }

        public void Logout() => CurrentUser = null;
    }
}
