using Eureka.Data;
using System.Collections.Generic;

namespace Eureka.UI;

internal class Sidebar : DynamicList<SidebarEntry, SidebarItem>
{

    protected override List<SidebarItem> FetchItems()
    {
        return new List<SidebarItem>()
        {
            new SidebarItem()
            {
                Href = "/home",
                Title = "Home"
            },
            new SidebarItem()
            {
                Href = "/forum",
                Title = "Forums"
            }
        };
    }

}
