using Microsoft.EntityFrameworkCore;
using StockMarket.Models;

namespace StockMarket.Data
{
    public class StockContext :  DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options) { }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
