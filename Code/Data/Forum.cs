
using Eureka.Api;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Eureka.Data;

internal class Forum
{

    [JsonPropertyName("id")]
    public long Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("topics")]
    public int Topics { get; set; }
    [JsonPropertyName("replies")]
    public int Replies { get; set; }

    public static async Task<List<Forum>> All() => await EurekaApi.Fetch<List<Forum>>("forum");

}
