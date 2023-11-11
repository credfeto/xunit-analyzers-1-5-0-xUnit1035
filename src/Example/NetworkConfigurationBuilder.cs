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
}