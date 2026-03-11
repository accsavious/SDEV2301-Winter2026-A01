using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace AuthDemo.Services
{
    public class FakeAuthStateProvider : AuthenticationStateProvider
    {
        private readonly AuthService _authService;

        public FakeAuthStateProvider(AuthService authService)
        {
            _authService = authService;
        }
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // Declare our ClaimsPrincipal
            ClaimsPrincipal principal;

            if (!_authService.IsLoggedIn)
            {
                // Create an anonymous user because the user is not authenticated.
                principal = new ClaimsPrincipal(new ClaimsIdentity());
            }
            else
            {
                // The user is authenticated, so create an authenticated user with a basic role.

                // Create the ClaimsIdentity
                ClaimsIdentity identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, _authService.CurrentUser!),
                    new Claim(ClaimTypes.Role, "User")
                }, authenticationType: "FakeAuth");

                // Create a new ClaimsPrincipal using the new identity
                principal = new ClaimsPrincipal(identity);
            }

            // Return the authentication state wrapper class with the ClaimsPrincipal object.
            return Task.FromResult(new AuthenticationState(principal));
        }
        public void NotifyAuthenticationStateChanged()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}
