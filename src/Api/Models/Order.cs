namespace Api.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustumerId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Custumer Custumer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
