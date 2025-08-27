using Shouldly;

namespace Solutions.Test;

public class Problem21Test
{
    [Theory]
    [InlineData(
        new int[] { 1, 2, 4 },
        new int[] { 1, 3, 4 },
        new int[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(
        new int[] { },
        new int[] { },
        new int[] { })]
    [InlineData(
        new int[] { },
        new int[] { 0 },
        new int[] { 0 })]
    public void TestCases(int[] nums1, int[] nums2, int[] expected)
    {
        var l1 = Utils.ArrayToList(nums1);
        var l2 = Utils.ArrayToList(nums2);
        var ex = Utils.ArrayToList(expected);

        var p = new Problem21();

        var result = p.MergeTwoLists(l1, l2);

        result.ShouldBeEquivalentTo(ex);
    }
}