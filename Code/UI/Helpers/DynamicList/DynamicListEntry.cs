using Sandbox;
using Sandbox.UI;

namespace Eureka.UI;

[Library]
internal class DynamicListEntry<T> : Panel
{

    public T Item { get; private set; }

    public void Set(T item)
    {
        Item = item;

        OnSet();
    }

    protected virtual void OnSet() { }

}
