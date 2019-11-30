namespace Products.Api.DataAccess.Contracts.Entities
{
    public partial class TransactionEntity
    {
        public System.Guid Id { get; set; }
        public double Amount { get; set; }
        public System.Guid Id_product { get; set; }
        public System.Guid Id_rate { get; set; }

        public virtual ProductEntity Product { get; set; }
        public virtual RateEntity Rate { get; set; }
    }
}
