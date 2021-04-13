using AutoMapper;
using System.Collections.Generic;

namespace CurrencyConverterMVC.Utilities
{
    public class ConverterOfCurrency
    {
        public Models.Currency ConvertDTOToCurrencyModel(CurrencyConverter.Models.Currency curr)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CurrencyConverter.Models.Currency, Models.Currency>());
            var mapper = config.CreateMapper();

            Models.Currency currency = mapper.Map<Models.Currency>(curr);
            return currency;
        }

        public List<Models.Currency> ConvertDTOToCurrencyModel(List<CurrencyConverter.Models.Currency> curr)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CurrencyConverter.Models.Currency, Models.Currency>());
            var mapper = config.CreateMapper();

            List < Models.Currency> currency = mapper.Map< List<Models.Currency>>(curr);
            return currency;
        }
    }
}
