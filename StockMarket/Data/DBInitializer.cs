using Microsoft.EntityFrameworkCore;
using StockMarket.Models;

namespace StockMarket.Data
{
    public static class DBInitializer
    {
        public static void Intialize(StockContext context)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                try
                {
                    //Create the database if it doesn't exist.
                    context.Database.Migrate();

                    if (context.Stocks.Any())
                    {
                        //DB has been seeded or has entries in it.
                        return;
                    }
                }
                catch (Exception)
                {
                    //What exceptions does Migrate throw??
                    throw;
                }

            }

            //If Environment is "Staging", we will use ensure created for GitHub pages
        }
    }
}
