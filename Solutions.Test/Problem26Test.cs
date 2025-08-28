using Shouldly;

namespace Solutions.Test;

public class Problem26Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void TestCases(int[] nums, int expected)
    {
        var p = new Problem26();

        var result = p.RemoveDuplicates(nums);

        result.ShouldBe(expected);
    }
}