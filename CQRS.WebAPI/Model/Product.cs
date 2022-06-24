namespace CQRS.WebAPI.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; } = true;
        public string Description { get; set; }
        public int Rate { get; set; }
        public int BuyingPrice { get; set; }
        public string ConfidentialData { get; set; }
    }
}
