using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

//namespace IngridBz.Services
//{
    public class FakeAuthStateProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal _currentUser = new ClaimsPrincipal(new ClaimsIdentity());

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(_currentUser));
        }

        public void Login()
        {
            var identity = new ClaimsIdentity(
            [
            new Claim(ClaimTypes.Name, "Ardha"),
            new Claim(ClaimTypes.Role, "Admin")
        ], "FakeAuth");

            _currentUser = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public void Logout()
        {
            _currentUser = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
//}
