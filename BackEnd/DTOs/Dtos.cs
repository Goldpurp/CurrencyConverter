using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.DTOs
{
    public record ExchangeRateDto(
    [Required] double rate,
    [Required] string fromCurrency,
    [Required] string toCurrency);

}