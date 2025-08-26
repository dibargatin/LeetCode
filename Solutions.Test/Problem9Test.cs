using Shouldly;

namespace Solutions.Test;

public class Problem9Test
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void TestCases(int x, bool expected)
    {
        var p = new Problem9();

        var result = p.IsPalindrome(x);

        result.ShouldBe(expected);
    }
}