using Eureka.Data;
using Eureka.UI;

namespace Eureka.UI;

internal class SidebarEntry : DynamicListEntry<SidebarItem>
{

    protected override void OnSet()
    {
        base.OnSet();

        var navLink = new NavigatorButton();
        navLink.Text = Item.Title;
        navLink.HRef = Item.Href;
        navLink.Parent = this;
    }

}
