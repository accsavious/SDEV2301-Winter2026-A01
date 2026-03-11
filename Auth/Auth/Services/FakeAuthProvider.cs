
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Auth.Services
{
    public class FakeAuthProvider : AuthenticationStateProvider
    {
        private readonly AuthService _authService;

        public FakeAuthProvider(AuthService authService)
        {
            _authService = authService;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsPrincipal principal;
            if (!_authService.IsLoggedIn)
            {
                principal = new ClaimsPrincipal(new ClaimsIdentity());

            }
            else
            {
                ClaimsIdentity identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, _authService.CurrentUser!),
                    new Claim(ClaimTypes.Role, _authService.CurrentUser!),

                }, authenticationType: "FakeAuth");
                principal = new ClaimsPrincipal(identity);
            }
            return Task.FromResult(new AuthenticationState(principal));
        }

        public void NotifyAuthenticationStateChanged()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}
