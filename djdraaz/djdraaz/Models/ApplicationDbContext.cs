using System;
using Microsoft.EntityFrameworkCore;

namespace djdraaz.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
             
        }

        public DbSet<Client> clients { get; set; }
    }
}
