using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace user2.Pages;

[Authorize(Roles = "ProtectedPageRole", AuthenticationSchemes = "ProtectedSchema", Policy = "ProtectedPolicy")]
public class Protected : PageModel
{
    public void OnGet()
    {
        
    }
}
