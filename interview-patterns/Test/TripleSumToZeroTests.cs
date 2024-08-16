using FluentAssertions;
using Lib;

namespace Test;

public class TripleSumToZeroTests
{
    [Fact]
    public void Returns_Expected_Result_1()
    {
        var input = new[] { -3, 0, 1, 2, -1, 1, -2 };
        var triplets = TripleSumToZero.SearchTriplets(input);

        triplets.Count.Should().Be(4);
        triplets[0].Should().Equal([-3, 1, 2]);
        triplets[1].Should().Equal([-2, 0, 2]);
        triplets[2].Should().Equal([-2, 1, 1]);
        triplets[3].Should().Equal([-1, 0, 1]);
    }
}
