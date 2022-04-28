using Microsoft.EntityFrameworkCore;
using StockMarket.Models;

namespace StockMarket.Data
{
    public static class DBInitializer
    {
        public static void Intialize(StockContext context)
        {
            //Create the database if it doesn't exist.
            context.Database.Migrate();
        }
    }
}
