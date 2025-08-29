using Shouldly;

namespace Solutions.Test;

public class Problem40Test
{
    [Fact]
    public void TestCase1()
    {
        int[] candidates = [10, 1, 2, 7, 6, 1, 5];
        int target = 8;
        IList<IList<int>> expected = [
            [1,2,5],
            [1,1,6],
            [2,6],
            [1,7]            
        ];

        var p = new Problem40();

        var result = p.CombinationSum2(candidates, target);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase2()
    {
        int[] candidates = [2, 5, 2, 1, 2];
        int target = 5;
        IList<IList<int>> expected = [
            [1,2,2],
            [5]
        ];

        var p = new Problem40();

        var result = p.CombinationSum2(candidates, target);

        result.ShouldBeEquivalentTo(expected);
    }
}