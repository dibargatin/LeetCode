using Shouldly;
using ListNode = Solutions.Problem19.ListNode;

namespace Solutions.Test;

public class Problem19Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
    [InlineData(new int[] { 1 }, 1, new int[] { })]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 1 })]    
    public void TestCases(int[] nums, int n, int[] expected)
    {
        var input = ArrayToList(nums);
        var expectedList = ArrayToList(expected);

        var p = new Problem19();

        var result = p.RemoveNthFromEnd(input, n);

        result.ShouldBeEquivalentTo(expectedList);
    }

    private static ListNode ArrayToList(int[] nums)
    {
        ListNode head = null;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            head = new ListNode(nums[i], head);
        }

        return head;
    }
}