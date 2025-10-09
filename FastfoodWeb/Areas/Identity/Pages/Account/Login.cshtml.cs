using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class LoginModel : PageModel
{
    [Microsoft.AspNetCore.Mvc.BindProperty]
    public InputModel Input { get; set; }

    public string ReturnUrl { get; set; }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public void OnGet(string returnUrl = null)
    {
        ReturnUrl = returnUrl;
    }

    public Microsoft.AspNetCore.Mvc.IActionResult OnPost(string returnUrl = null)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // TODO: Add your login logic here

        return RedirectToPage("./Index");
    }
}

