using Shouldly;

namespace Solutions.Test;

public class Problem69Test
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    public void TestCases(int x, int expected)
    {
        var p = new Problem69();

        var result = p.MySqrt(x);

        result.ShouldBe(expected);
    }
}