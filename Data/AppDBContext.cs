using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data{
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions options) : base(options){
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserBookModel> UserBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBookModel>()
                .HasKey(ub => new { ub.UserDocument, ub.BookId }); 

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<RolModel> Rols { get; set; }
    }
   
}
