using Shouldly;

namespace Solutions.Test;

public class Problem20Test
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    [InlineData("([)]", false)]
    public void TestCases(string s, bool expected)
    {
        var p = new Problem20();

        var result = p.IsValid(s);

        result.ShouldBe(expected);
    }
}