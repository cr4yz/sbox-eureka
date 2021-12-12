using Sandbox.UI;
using System.Collections.Generic;
using Eureka.Data;
using System.Threading.Tasks;
using Eureka.Api;

namespace Eureka.UI;

[UseTemplate]
internal class ForumList : DynamicList<ForumListSingle, ForumItem>
{

    protected override async Task<List<ForumItem>> FetchItemsAsync() => await EurekaApi.Fetch<List<ForumItem>>("forum");

}
