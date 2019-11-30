namespace Products.Api.Application.Repositories
{
    using Products.Api.Application.Configuration;
    using Products.Api.Application.Contracts.Services;
    using Products.Api.Business;
    using Products.Api.Business.Models;
    using Products.Api.DataAccess.Contracts.Repositories;
    using Products.Api.DataAccess.Mappers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IAppConfig _appConfig;
        private readonly IInformationService _informationService;

        public TransactionService(ITransactionRepository transactionRepository, IAppConfig appConfig, IInformationService informationService)
        {
            _transactionRepository = transactionRepository;
            _appConfig = appConfig;
            _informationService = informationService;
        }
        public async Task<TransactionsTotal> GetTransactionsBySku(string sku)
        {
          
            try
            {
                string error = null;
                error.ToString();
                TransactionsTotal transactionsTotal = new TransactionsTotal()
                {
                    Transactions = new List<Transactions>()
                };
                List<Transactions> lstTransactions = new List<Transactions>();
                await _informationService.GetInformation(lstTransactions, "TRANSACTIONS", "transactions.json");

                transactionsTotal.Transactions.AddRange(lstTransactions.Where(w => w.Currency == _appConfig.DefaultMoney).ToList());
                lstTransactions = lstTransactions.Where(w => w.Currency != _appConfig.DefaultMoney).ToList();
                List<Rates> lstRates = new List<Rates>();
                await _informationService.GetInformation(lstRates, "RATES", "rates.json");
                var lstCurrencyDefault = lstRates.Where(w => w.To == _appConfig.DefaultMoney).Select(w => w.From).ToList();
                var lstDirectConversions = lstTransactions.Where(w => lstCurrencyDefault.Contains(w.Currency)).ToList();
                if (lstDirectConversions.Any())
                {
                    transactionsTotal.Transactions.AddRange(lstDirectConversions.Select(s => new Transactions()
                    {
                        Amount = Math.Round(s.Amount * lstRates.Where(w => w.From == s.Currency && w.To == _appConfig.DefaultMoney).Select(c => c.Rate).FirstOrDefault(), MidpointRounding.ToEven),
                        Sku = s.Sku,
                        Currency = _appConfig.DefaultMoney
                    }).ToList());
                }

                var lstIndirectConersions = lstTransactions.Where(c => !lstCurrencyDefault.Contains(c.Currency)).ToList();
                if (lstIndirectConersions.Any())
                {
                    foreach (var modelInDirectConversion in lstIndirectConersions)
                    {
                        GetIndirectConvert(lstRates, modelInDirectConversion);
                        transactionsTotal.Transactions.Add(modelInDirectConversion);
                    }
                }
                return transactionsTotal;
            }
            catch (Exception ex)
            {
                throw new NotificationException("TransactionService","GetTransactionBySku", ex);
            }
        }

        private void GetIndirectConvert(List<Rates> lstRates, Transactions modelInDirectConvertion)
        {

            while (modelInDirectConvertion.Currency != _appConfig.DefaultMoney)
            {
                var newConvertion = lstRates.Where(w => w.From == modelInDirectConvertion.Currency).ToList();
                if (newConvertion.Count > 0)
                {
                    var toDefect = newConvertion.Where(w => w.To == _appConfig.DefaultMoney).Any();
                    if (toDefect)
                    {
                        var toDefault = newConvertion.Where(w => w.To == _appConfig.DefaultMoney).FirstOrDefault();
                        modelInDirectConvertion.Currency = toDefault.To;
                        modelInDirectConvertion.Amount = Math.Round(modelInDirectConvertion.Amount * toDefault.Rate, MidpointRounding.ToEven);
                    }
                    else
                    {
                        var rate = newConvertion[0];
                        modelInDirectConvertion.Currency = rate.To;
                        modelInDirectConvertion.Amount = Math.Round(modelInDirectConvertion.Amount * rate.Rate, MidpointRounding.ToEven);
                    }
                }
            }
        }

        public async Task<List<Transactions>> GetAllTransactions()
        {
            List<Transactions> lstTransactions = new List<Transactions>();
            await _informationService.GetInformation(lstTransactions, "TRANSACTIONS", "transactions.json");
            return lstTransactions;
        }
    }
}
