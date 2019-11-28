using System.Collections.Generic;

namespace Products.Api.DataAccess.Contracts.Entities
{
    public partial class ProductEntity
    {
        public ProductEntity()
        {
            this.Transaction = new HashSet<TransactionEntity>();
        }

        public System.Guid Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TransactionEntity> Transaction { get; set; }
    }
}
