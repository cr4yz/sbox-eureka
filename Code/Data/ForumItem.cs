
using System.Text.Json.Serialization;

namespace Eureka.Data;

internal class ForumItem
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

}
