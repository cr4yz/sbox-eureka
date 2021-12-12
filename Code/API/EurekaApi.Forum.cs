using Eureka.Data;
using Sandbox.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;

namespace Eureka.Api;

internal static partial class EurekaApi
{

    public static string ForumEndpoint => ApiEndpoint + "/forum";

    public static async Task<List<ForumItem>> FetchForumsAsync()
    {
        await Task.Delay(1000);

        var http = new Http(new System.Uri(ForumEndpoint));
        var json = await http.GetStringAsync();

        return JsonSerializer.Deserialize<List<ForumItem>>(json);
    }

}
