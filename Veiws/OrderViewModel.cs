namespace KhumaloCraft02.Veiws
{
    public class OrderViewModel(decimal price)
    {
        public required string ItemName { get; set; }
        public decimal Price { get; set; } = price;
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
    }
}
