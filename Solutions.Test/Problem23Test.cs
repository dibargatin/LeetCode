using Shouldly;

namespace Solutions.Test;

public class Problem23Test
{
    [Fact]
    public void TestCase1()
    {
        var lists = ArrayToArrayOfLists([[1, 4, 5], [1, 3, 4], [2, 6]]);
        var expected = Utils.ArrayToList([1, 1, 2, 3, 4, 4, 5, 6]);

        var p = new Problem23();

        var result = p.MergeKLists(lists);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase2()
    {
        var lists = ArrayToArrayOfLists([]);
        var expected = Utils.ArrayToList([]);

        var p = new Problem23();

        var result = p.MergeKLists(lists);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase3()
    {
        var lists = ArrayToArrayOfLists([[]]);
        var expected = Utils.ArrayToList([]);

        var p = new Problem23();

        var result = p.MergeKLists(lists);

        result.ShouldBeEquivalentTo(expected);
    }

    private static ListNode[] ArrayToArrayOfLists(int[][] nums)
    {
        var lists = new ListNode[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            lists[i] = Utils.ArrayToList(nums[i]);
        }

        return lists;
    }
}