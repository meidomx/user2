using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace user2.Pages;

[Authorize]
public class Protected : PageModel
{
    public void OnGet()
    {
        
    }
}
