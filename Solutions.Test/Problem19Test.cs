using Shouldly;

namespace Solutions.Test;

public class Problem19Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
    [InlineData(new int[] { 1 }, 1, new int[] { })]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 1 })]    
    public void TestCases(int[] nums, int n, int[] expected)
    {
        var input = Utils.ArrayToList(nums);
        var expectedList = Utils.ArrayToList(expected);

        var p = new Problem19();

        var result = p.RemoveNthFromEnd(input, n);

        result.ShouldBeEquivalentTo(expectedList);
    }
}