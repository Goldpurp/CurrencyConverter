using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.DTOs;
using CurrencyConverter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RateController : ControllerBase
    {
        public static ExchangeRate exchangeRate = new ExchangeRate(0, "GBP", "NGN");

        [HttpGet("get-rate")]
        public IActionResult GetRate()
        {

            var rateToReturn = exchangeRate.GetRate();
            return Ok(rateToReturn);
        }

        [HttpPost("set-rate")]

        public IActionResult SetRate([FromBody] ExchangeRateDto exchangeRateDto)
        {

            if (exchangeRateDto.fromCurrency.ToLower() != "gbp")
            {
                return BadRequest("Request not supported, we support just gbp to ngn");
            }

            if (exchangeRateDto.toCurrency.ToLower() != "ngn")
            {
                return BadRequest("Request not supported, we support just gbp to ngn");
            }

            exchangeRate.UpdateRate(exchangeRateDto.rate);
            return Ok(new
            {
                Message = "Rate Updated successfully"
            });
        }
    }
}