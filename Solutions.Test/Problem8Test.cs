using Shouldly;

namespace Solutions.Test;

public class Problem8Test
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData(" -042", -42)]
    [InlineData("1337c0d3", 1337)]
    [InlineData("0-1", 0)]
    [InlineData("words and 987", 0)]
    public void TestCases(string s, int expected)
    {
        var p = new Problem8();

        var result = p.MyAtoi(s);

        result.ShouldBe(expected);
    }
}