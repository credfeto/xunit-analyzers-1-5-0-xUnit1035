using System.Threading.Tasks;
using Xunit;

namespace Example;

public sealed class ExampleTests
{
    [Theory]
    [MemberData(nameof(NetworkConfigurationBuilder.Build),
                NetworkSelection.SEPOLIA,
                EndpointValidity.VALID,
                NetworkNodeProtocol.HTTPS,
                NetworkNodeType.ONE_NODE_IS_MULTI,
                MemberType = typeof(NetworkConfigurationBuilder))]
    [MemberData(nameof(NetworkConfigurationBuilder.Build),
                NetworkSelection.SEPOLIA,
                EndpointValidity.VALID,
                NetworkNodeProtocol.WEB_SOCKETS,
                NetworkNodeType.ONE_NODE_IS_MULTI,
                MemberType = typeof(NetworkConfigurationBuilder))]
    public Task SingleFullNodeUsingMultiAsync(TestFixtureNetworkConfigurations networkSetup)
    {
        return Task.CompletedTask;
    }
}