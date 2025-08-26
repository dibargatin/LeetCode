using Shouldly;

namespace Solutions.Test;

public class Problem1Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]    
    public void TestCases(int[] nums, int target, int[] expected)
    {
        var p = new Problem1();

        var result = p.TwoSum(nums, target);

        result.ShouldBeEquivalentTo(expected);
    }
}