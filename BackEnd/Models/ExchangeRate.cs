using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.DTOs;

namespace CurrencyConverter.Models
{
    public class ExchangeRate
    {
        private double Rate { get; set; }
        private string FromCurrency { get; set; }
        private string ToCurrency { get; set; }

        public ExchangeRate(double rate, string fromCurrency, string toCurrency)
        {
            Rate = rate;
            FromCurrency = fromCurrency;
            ToCurrency = toCurrency;
        }


        public void UpdateRate(double newRate)
        {
            Rate = newRate;
        }

        public ExchangeRateDto GetRate()
        {
           return new ExchangeRateDto(rate: Rate, fromCurrency: FromCurrency, toCurrency: ToCurrency);
        }
    }
}