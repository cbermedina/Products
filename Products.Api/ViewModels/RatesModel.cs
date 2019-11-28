using System;

namespace Products.Api.ViewModels
{
    public class RatesModel
    {
        public Guid id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public decimal rate { get; set; }
    }
}
