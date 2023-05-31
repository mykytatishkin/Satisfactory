using Microsoft.EntityFrameworkCore;

namespace Project_Stock
{
    public class SatisfactoryDbContext : DbContext
    {
        public SatisfactoryDbContext(DbContextOptions<SatisfactoryDbContext> options) : base(options)
        {

        }
      
    }
}