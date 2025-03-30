using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Biblioteca.Pages.Book
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
        public BookModel Books { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Books.Add(Books);
            await context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
