using Microsoft.EntityFrameworkCore;
using System;

namespace L7BookApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
