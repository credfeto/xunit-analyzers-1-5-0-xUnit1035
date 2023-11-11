using System.Collections.Generic;

namespace Example;

internal static class NetworkConfigurationBuilder
{
    public static IEnumerable<object[]> Build(NetworkSelection networkSelection, EndpointValidity endpointValidity, NetworkNodeProtocol protocol, NetworkNodeType fullNodeType)
    {
        yield return new object[]
                     {
                         new TestFixtureNetworkConfigurations()
                     };
    }

    public static IEnumerable<object[]> NoErrors(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return new object[]
                         {
                             new TestFixtureNetworkConfigurations()
                         };
        }
    }
}