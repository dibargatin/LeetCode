using Shouldly;

namespace Solutions.Test;

public class Problem11Test
{
    [Theory]
    [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new int[] { 1, 1 }, 1)]
    public void TestCases(int[] height, int expected)
    {
        var p = new Problem11();

        var result = p.MaxArea(height);

        result.ShouldBe(expected);
    }
}