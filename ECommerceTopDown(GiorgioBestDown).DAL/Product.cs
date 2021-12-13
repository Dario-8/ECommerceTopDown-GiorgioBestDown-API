namespace ECommerceTopDown_GiorgioBestDown_.DAL
{
    public class Product
    {
        static private readonly int CONST = 5; 
        public int Id { get; set; }
        public double InitialPrice { get; set; }
        public double ActualPrice { get => InitialPrice * CONST; }
        public string Producer { get; set; }
        public string Category { get; set; }
    }
}