using Shouldly;

namespace Solutions.Test;

public class Problem17Test
{
    [Fact]
    public void TestCase1()
    {
        var digits = "23";
        List<string> expected = ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"];

        var p = new Problem17();

        var result = p.LetterCombinations(digits);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase2()
    {
        var digits = "";
        List<string> expected = [];

        var p = new Problem17();

        var result = p.LetterCombinations(digits);

        result.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void TestCase3()
    {
        var digits = "2";
        List<string> expected = ["a","b","c"];

        var p = new Problem17();

        var result = p.LetterCombinations(digits);

        result.ShouldBeEquivalentTo(expected);
    }
}