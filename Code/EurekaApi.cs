
using Sandbox.Internal;
using System.Text.Json;
using System.Threading.Tasks;

namespace Eureka.Api;

internal static partial class EurekaApi
{

    public const string Endpoint = "https://localhost:7201/api";

    public static async Task<T> Fetch<T>(string controller)
    {
        var http = new Http(new System.Uri($"{Endpoint}/{controller}"));
        var json = await http.GetStringAsync();

        return JsonSerializer.Deserialize<T>(json);
    }

}
