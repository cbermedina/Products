using Products.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Products.Api.Business
{
    public class CalculateAmount
    {
        private readonly List<Rates> _rates;
        public CalculateAmount(List<Rates> rates)
        {
            _rates = rates;
        }
        /// <summary>
        /// Homologate Amount
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal HomologateAmount(string from, string to, decimal value)
        {
            //from = USD
            //to = CAD
            decimal finalRate;
            // Consultar RATES 
            var result = _rates.Where(x => x.From == from && x.To == to).FirstOrDefault();

            if (result != null)
            {
                var convertFrom = _rates.Where(x => x.From == from).ToList();
                var convertTo = _rates.Where(x => x.To.ToString() == to).ToList();

                var innerGroupJoinQuery2 =
                    (from from1 in convertFrom
                     join to1 in convertTo on from1.From equals to1.From into ratesGroup
                     from ratesResult in ratesGroup
                     select ratesResult).ToList();


                //  finalRate = CalculateRecursive(convertFrom, convertTo);

            }
            finalRate = Math.Round(result.Rate * value, MidpointRounding.ToEven);
            return finalRate;
        }

        //private decimal CalculateRecursive(List<Rates> lstFrom, List<Rates> lstTo)
        //{
        //    decimal result = 0;

        //    foreach (var item in lstFrom)
        //    {
        //        foreach (var compare in lstTo)
        //        {
        //            if(item.From == compare.To)
        //            {
        //                HomologateAmount(item)
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
