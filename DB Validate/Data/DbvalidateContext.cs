using DB_Validate.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Validate.Data;


public class DbvalidateContext : DbContext
{
    public DbvalidateContext(DbContextOptions<DbvalidateContext> 
        opts)
            : base(opts)
    {

    }
    public DbSet<dbvalidate> dbvalidates { get; set; }
}