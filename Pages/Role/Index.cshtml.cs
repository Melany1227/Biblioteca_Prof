using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Pages.Role
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext context;

        public IndexModel(AppDBContext context)
        {
            this.context = context;
        }

        public IList<RolModel> Rols { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Rols = await context.Rols.ToListAsync();
        }
    }
}
