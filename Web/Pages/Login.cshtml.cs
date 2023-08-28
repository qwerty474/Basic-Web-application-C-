using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{

        public class LoginModel : PageModel
        {

            [BindProperty]
            public InputModel Input { get; set; }

            public class InputModel
            {
                public string Email { get; set; }
                public string Password { get; set; }
            }

            public void OnGet()
            {

            }

            public void OnPost()
            {

            }

        }

}
