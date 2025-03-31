using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Biblioteca.Pages.Role
{
    public class CreateModel : PageModel
    {
        private readonly AppDBContext context;

        public CreateModel(AppDBContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RolModel Role { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Rols.Add(Role);
            await context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}