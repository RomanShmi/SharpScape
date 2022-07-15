using System.Security.Claims;
using System.Net.Http.Headers;

namespace SharpScape.Website.Services;

public interface IAuthTokenProvider
{
    public string? Token { get; set; } 
    public ClaimsIdentity? GetClaims();
}



public class AuthTokenProvider : IAuthTokenProvider
{
    
    public ClaimsIdentity? GetClaims()
    {

       
        return new ClaimsIdentity(AppAuthStateProvider.ParseClaimsFromJwt(Token), "jwt");
    }


    public string? Token { get; set; }
    public AuthTokenProvider()
    {
       

    }
}