using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class UserModel
    {
        [Key]
        public int Document { get; set; }
        public required string Name { get; set; }
        [Required(ErrorMessage = "El nombre de la persona es obligatorio.")]
        public required string LastName { get; set; }
        [Required(ErrorMessage = "El apellido de la persona es obligatorio.")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "El correo de la persona es obligatorio.")]
        public required string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public int RolCode { get; set; }

    }
}
