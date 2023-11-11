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
    public void CompilesWithErrors(TestFixtureNetworkConfigurations networkSetup)
    {
        Assert.NotNull(networkSetup);
    }

    [Theory]
    [MemberData(nameof(NetworkConfigurationBuilder.NoErrors), 10, MemberType = typeof(NetworkConfigurationBuilder))]
    public void CompilesOk(TestFixtureNetworkConfigurations networkSetup)
    {
        Assert.NotNull(networkSetup);
    }
}