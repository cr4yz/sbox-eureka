using Sandbox;

namespace Eureka;

public class Eureka : Sandbox.Game
{

    public Eureka()
    {

        if (IsClient)
        {
            new UI.EurekaRootPanel();
        }

    }

}
