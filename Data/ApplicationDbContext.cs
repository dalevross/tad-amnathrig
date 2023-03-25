using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tad_amnathrig.Models;

namespace tad_amnathrig.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    
    public DbSet<Item> Items { get; set; }


    public DbSet<UserContact> Contact { get; set; } 

    
}
