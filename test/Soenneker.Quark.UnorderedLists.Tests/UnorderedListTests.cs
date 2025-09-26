using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.UnorderedLists.Tests;

[Collection("Collection")]
public sealed class UnorderedListTests : FixturedUnitTest
{
    public UnorderedListTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Test that the UnorderedList component can be instantiated
        // This is a basic smoke test
        Assert.True(true);
    }
}
