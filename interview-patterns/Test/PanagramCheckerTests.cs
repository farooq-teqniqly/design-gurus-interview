using Lib;
using NSubstitute;

namespace Test;

public class PanagramCheckerTests
{
    [Fact]
    public void Strategy_Is_Called()
    {
        var fakeStrategy = Substitute.For<IPanagramStrategy>();
        var checker = new PanagramChecker(fakeStrategy);

        var sentence = "foo";
        checker.CheckIfPanagram(sentence);

        fakeStrategy.Received(1).CheckIfPanagram(Arg.Is(sentence));
    }
}
