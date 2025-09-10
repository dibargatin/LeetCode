using Shouldly;

namespace Solutions.Test;

public class Problem16Test
{
    [Theory]
    [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
    [InlineData(new int[] { 0, 0, 0 }, 1, 0)]
    [InlineData(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }, 1, 60)]    
    public void TestCases(int[] nums, int target, int expected)
    {
        var p = new Problem16();

        var result = p.ThreeSumClosest(nums, target);

        result.ShouldBe(expected);
    }
}