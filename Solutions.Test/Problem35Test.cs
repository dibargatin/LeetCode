using Shouldly;

namespace Solutions.Test;

public class Problem35Test
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
    public void TestCases(int[] nums, int target, int expected)
    {
        var p = new Problem35();

        var result = p.SearchInsert(nums, target);

        result.ShouldBe(expected);
    }
}