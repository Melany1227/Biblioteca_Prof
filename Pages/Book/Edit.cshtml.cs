using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Pages.Book
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _context;
        public EditModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookModel Books { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return RedirectToPage("./Index");
            }

            var books = await _context.Books.FirstOrDefaultAsync(e => e.Id == id);
        
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Update(Books);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }   

    }
}
