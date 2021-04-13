using CurrencyConverter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverterMVC.Controllers
{
    public class ExchangeController : Controller
    {
        private readonly Converter _converter;

        public ExchangeController(Converter converter)
        {
            _converter = converter;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View();
        }
    }
}
