namespace Products.Api.Business.Models
{
    public class Rates
    {
        public System.Guid Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Rate { get; set; }
    }
}
