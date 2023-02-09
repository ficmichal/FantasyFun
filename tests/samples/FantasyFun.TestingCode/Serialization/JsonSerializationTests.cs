using FantasyFun.API.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace FantasyFun.TestingCode.Serialization
{
    public class JsonSerializationTests
    {
        [Fact]
        public void TestSerialization()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };

            var searchPlayerAsString = "{\"name\":\"Robert Lewandowski\",\"overall\":67}";

            var searchPlayer = JsonSerializer.Deserialize<SearchPlayer>(
                searchPlayerAsString, options);

            var searchPlayerAsStringAgain = JsonSerializer.Serialize(searchPlayer, options);
            Assert.Equal(searchPlayerAsString, searchPlayerAsStringAgain);
        }
    }
}
