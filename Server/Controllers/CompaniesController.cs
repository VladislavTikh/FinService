using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinService.Server.Services;
using FinService.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThreeFourteen.Finnhub.Client;
using ThreeFourteen.Finnhub.Client.Model;

namespace FinService.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private FinnhubClient _client;
        private StocksService _stocksService;
        public CompaniesController(FinnhubClient client, StocksService stocksService)
        {
            _client = client;
            _stocksService = stocksService;
        }

        [HttpGet]
        public async Task<IEnumerable<CompaniesGroup>> GetSymbolGroups()
        {
            var symbols = await _client.Stock.GetSymbols("US");
            var companyGroups = symbols.GroupBy(x => x.CandleSymbol.Substring(0, 1).ToUpper(),
                (alphabet, subList) => new CompaniesGroup { FirstLetter = alphabet, Symbols = subList.OrderBy(x => x.CandleSymbol).ToList()})
                .OrderBy(x => x.FirstLetter);
            return companyGroups;
        }

        [HttpGet]
        [Route("{companySymbol}")]
        public async Task<CompanyProfile> GetCompanyProfile(string companySymbol)
        {
            var profile = await _stocksService.GetCompanyProfileBySymbol(companySymbol);
            return profile;
        }
    }
}
