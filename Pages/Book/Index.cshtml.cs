using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext context;

        public IndexModel(AppDBContext context)
        {
            this.context = context;
        }

        public IList<BookModel> Books { get; set; } = default!;
        public async Task OnGetAsync() {
            Books = await context.Books.ToListAsync();
        }
    }
}
