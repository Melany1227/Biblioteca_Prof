using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Models
{
    public class BookModel
    {
        public int Id { get; set; } 
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Gender { get; set; }

    }
}
