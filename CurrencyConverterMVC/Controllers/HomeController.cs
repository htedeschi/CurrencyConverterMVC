using CurrencyConverter;
using CurrencyConverterMVC.Models;
using CurrencyConverterMVC.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CurrencyConverterMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Converter _converter;


        public HomeController(ILogger<HomeController> logger, Converter converter)
        {
            _logger = logger;
            _converter = converter;
        }

        public IActionResult Index()
        {
            var currencies= new ConverterOfCurrency().ConvertDTOToCurrencyModel(_converter.GetAllCurrencies());
            CurrencyViewModel currencyViewModel = new CurrencyViewModel()
            {
                Currencies = currencies
            };

            return View(currencyViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
