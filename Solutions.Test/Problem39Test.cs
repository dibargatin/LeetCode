using Shouldly;

namespace Solutions.Test;

public class Problem39Test
{
    [Fact]
    public void TestCase1()
    {
        int[] candidates = [2, 3, 6, 7];
        int target = 7;
        IList<IList<int>> expected = [[2, 2, 3], [7]];

        var p = new Problem39();

        var result = p.CombinationSum(candidates, target);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase2()
    {
        int[] candidates = [2, 3, 5];
        int target = 8;
        IList<IList<int>> expected = [[2, 2, 2, 2], [2, 3, 3], [3, 5]];

        var p = new Problem39();

        var result = p.CombinationSum(candidates, target);

        result.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void TestCase3()
    {
        int[] candidates = [2];
        int target = 1;
        IList<IList<int>> expected = [];

        var p = new Problem39();

        var result = p.CombinationSum(candidates, target);

        result.ShouldBeEquivalentTo(expected);
    }
}