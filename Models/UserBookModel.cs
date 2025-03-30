using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    [PrimaryKey(nameof(UserDocument), nameof(BookId))] // Define la clave compuesta

    public class UserBookModel
    {
        public int UserDocument { get; set; }
        public int BookId { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public required string Status { get; set; }
    }
}
