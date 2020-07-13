using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinService.Server.Services.Serializators
{
    public class JsonDeserializer : IDeserializer
    {
        public async Task<T> DeserializeAsync<T>(string  content)
        {
            return await Task.Run(()=>JsonConvert.DeserializeObject<T>(content));
        }
    }
}
