using Shouldly;

namespace Solutions.Test;

public class Problem13Test
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void TestCases(string s, int expected)
    {
        var p = new Problem13();

        var result = p.RomanToInt(s);

        result.ShouldBe(expected);
    }
}