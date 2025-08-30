using Shouldly;

namespace Solutions.Test;

public class Problem70Test
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    public void TestCases(int n, int expected)
    {
        var p = new Problem70();

        var result = p.ClimbStairs(n);

        result.ShouldBe(expected);
    }
}