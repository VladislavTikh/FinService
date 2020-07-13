using FinService.Server.Services.Serializators;
using FinService.Shared.Models;
using System.Threading.Tasks;
using ThreeFourteen.Finnhub.Client;
using ThreeFourteen.Finnhub.Client.Model;

namespace FinService.Server.Services
{
    public class StocksService
    {
        private FinnhubClient _client;
        private IDeserializer _deserializer;
        public StocksService(FinnhubClient client, IDeserializer deserializer)
        {
            _client = client;
            _deserializer = deserializer;
        }

        public async Task<CompanyProfile> GetCompanyProfileBySymbol(string symbol)
        {
            return await _deserializer.DeserializeAsync<CompanyProfile>(await _client.GetRawDataAsync("stock/profile2", new Field(FieldKeys.Symbol, symbol)));
        }
    }
}
