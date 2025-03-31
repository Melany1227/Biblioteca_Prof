using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class RolModel
    {
        [Key]
        public int RolCode { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
