namespace ApplicationCore.Entities
{
    public class Promotion: BaseEntity
    {
                
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string ProductCode { get; set; }
        public double Price { get; set; }
    }
}