using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinService.Server.Services.Serializators
{
    public interface IDeserializer
    {
        Task<T> DeserializeAsync<T>(string content);
    }
}
