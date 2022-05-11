namespace StockMarket.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Currency { get; set; } = string.Empty;

        public string Exchange { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public User User { get; set; }

        public int UserId { get; set; }
    }
}
