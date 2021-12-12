using Eureka.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eureka.API;

internal static partial class EurekaAPI
{

    public static async Task<List<ForumItem>> FetchForumsAsync()
    {

        await Task.Delay(1000); 

        var result = new List<ForumItem>();

        result.Add(new ForumItem()
        {
            Id = 0,
            Name = "General",
            Description = "This is a nice spot"
        });

        return result;
    }

}
