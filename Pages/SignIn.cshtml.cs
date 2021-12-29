using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace user2.Pages;

public class SignIn : PageModel
{
    public void OnGet()
    {
        var user = HttpContext.User;

        var claimIdentity = new ClaimsIdentity();
        var claim = new Claim(claimIdentity.RoleClaimType, "ProtectedPageRole");
        // claim = new Claim(ClaimTypes.Role, "111");

        // HttpContext.User storage?
        HttpContext.User.AddIdentity(claimIdentity);
    }
}