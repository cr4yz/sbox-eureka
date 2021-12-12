using Sandbox;
using Sandbox.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eureka.UI;

internal abstract class DynamicList<T, T2> : Panel
    where T : DynamicListEntry<T2>
{

    public Panel Canvas { get; set; }

    protected virtual List<T2> FetchItems() => null;
    protected virtual async Task<List<T2>> FetchItemsAsync() => null;

    protected async void Rebuild()
    {
        var items = FetchItems() ?? await FetchItemsAsync();
        if (items == null) return;

        var parent = Canvas ?? this;
        parent?.DeleteChildren( true );

        foreach(var item in items)
        {
            var child = Library.Create<T>() as DynamicListEntry<T2>;
            child.Set(item);
            child.Parent = parent;
        }
    }

    protected override void PostTemplateApplied()
    {
        base.PostTemplateApplied();

        Rebuild();
    }

    public override void OnHotloaded()
    {
        base.OnHotloaded();

        Rebuild();
    }

}
