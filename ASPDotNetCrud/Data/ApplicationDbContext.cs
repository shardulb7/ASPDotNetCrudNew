using ASPDotNetCrud.Models;
using Microsoft.EntityFrameworkCore;
namespace ASPDotNetCrud.Data
{
    public class ApplicationDbContext : DbContext  //Added EFcore
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            

        }
        public DbSet<Student> Students { get; set; }//Added Entity of students
    }
}
