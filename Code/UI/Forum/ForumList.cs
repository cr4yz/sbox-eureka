using Sandbox.UI;
using System.Collections.Generic;
using Eureka.API;
using Eureka.Data;
using System.Threading.Tasks;

namespace Eureka.UI;

[UseTemplate]
internal class ForumList : DynamicList<ForumListSingle, ForumItem>
{

    protected override async Task<List<ForumItem>> FetchItemsAsync() => await EurekaAPI.FetchForumsAsync();

}
