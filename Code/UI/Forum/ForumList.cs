using Sandbox.UI;
using System.Collections.Generic;
using Eureka.Data;
using System.Threading.Tasks;
using Eureka.Api;

namespace Eureka.UI;

[UseTemplate]
internal class ForumList : DynamicList<ForumListSingle, Forum>
{

    protected override async Task<List<Forum>> FetchItemsAsync() => await Forum.All();

}
