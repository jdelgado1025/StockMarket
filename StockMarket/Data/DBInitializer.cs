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

            if(context.Stocks.Any())
            {
                //DB has been seeded or has entries in it.
                return;
            }

            //Database has not been seeded. We need to populate it.
            var result = GetApiData();
        }

        public static async Task<string> GetApiData()
        {
            var client = new HttpClient();
            string body = string.Empty;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twelve-data1.p.rapidapi.com/stocks?exchange=NYSE&country=United States"),
                Headers = {
                    { "X-RapidAPI-Host", "twelve-data1.p.rapidapi.com" },
                    { "X-RapidAPI-Key", "d5e197f7c7msh4d38b43b3f86b85p1b0defjsna27613eb831c" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

            return body;
        }
    }
}
