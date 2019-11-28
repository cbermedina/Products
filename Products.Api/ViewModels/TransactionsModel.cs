
namespace Products.Api.ViewModels
{
    /// <summary>
    /// TransactionsModel
    /// </summary>
    public class TransactionsModel
    {
        public System.Guid Id { get; set; }
        public decimal Amount { get; set; }
        public System.Guid Id_product { get; set; }
        public System.Guid Id_rate { get; set; }
    }
}
