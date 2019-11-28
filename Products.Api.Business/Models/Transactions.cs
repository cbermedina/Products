namespace Products.Api.Business.Models
{
    public class Transactions
    {
        public System.Guid Id { get; set; }
        public decimal Amount { get; set; }
        public System.Guid Id_product { get; set; }
        public System.Guid Id_rate { get; set; }
    }
}
