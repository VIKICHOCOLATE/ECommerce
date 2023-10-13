using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Orders.Db
{
    public class OrdersDbContext : DbContext
    {
        public DbSet<Order> Orders {  get; set; }

        public OrdersDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
            
        }
    }
}
