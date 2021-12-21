using Microsoft.AspNetCore.Mvc.RazorPages;

namespace user2.Pages;

public class SignIn : PageModel
{
    public void OnGet()
    {
        var user = HttpContext.User;
    }
}