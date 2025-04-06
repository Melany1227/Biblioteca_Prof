using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Pages.Book
{
    public class DeleteModel : PageModel
    {

        private readonly AppDBContext context;

        public DeleteModel(AppDBContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public BookModel Books { get; set; } = default;
        public async Task <IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("./Index");
            }

            var books = await context.Books.FirstOrDefaultAsync(Books => Books.Id == id);

            if (books == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Books = books;
                return Page();
            }
        }

        public async Task <IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return Page();
            }

            var books = await context.Books.FindAsync(id);

            if (books == null)
            {
                return Page();
            }
            else
            {
                Books = books;
                context.Books.Remove(Books);
                await context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
        }

    }
}
