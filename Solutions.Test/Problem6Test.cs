using Shouldly;

namespace Solutions.Test;

public class Problem6Test
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public void TestCases(string s, int numRows, string expected)
    {
        var p = new Problem6();

        var result = p.Convert(s, numRows);

        result.ShouldBe(expected);
    }
}