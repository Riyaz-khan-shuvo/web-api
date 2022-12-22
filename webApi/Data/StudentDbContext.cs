using Microsoft.EntityFrameworkCore;
using webApi.Models;

namespace webApi.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
