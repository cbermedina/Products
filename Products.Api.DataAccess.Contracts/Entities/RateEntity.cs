namespace Products.Api.DataAccess.Contracts.Entities
{
    using System.Collections.Generic;
    public partial class RateEntity
    {
        public RateEntity()
        {
            this.Transaction = new HashSet<TransactionEntity>();
        }

        public System.Guid Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Rate { get; set; }

        public virtual ICollection<TransactionEntity> Transaction { get; set; }
    }
}
