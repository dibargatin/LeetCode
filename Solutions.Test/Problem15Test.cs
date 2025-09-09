using Shouldly;

namespace Solutions.Test;

public class Problem15Test
{
    [Fact]
    public void TestCase1()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        IList<IList<int>> expected = [[-1, -1, 2], [-1, 0, 1]];

        var p = new Problem15();

        var result = p.ThreeSum(nums);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase2()
    {
        int[] nums = [0, 1, 1];
        IList<IList<int>> expected = [];

        var p = new Problem15();

        var result = p.ThreeSum(nums);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase3()
    {
        int[] nums = [0, 0, 0];
        IList<IList<int>> expected = [[0, 0, 0]];

        var p = new Problem15();

        var result = p.ThreeSum(nums);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase4()
    {
        int[] nums = [-100, -70, -60, 110, 120, 130, 160];
        IList<IList<int>> expected = [[-100, -60, 160], [-70, -60, 130]];

        var p = new Problem15();

        var result = p.ThreeSum(nums);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase5()
    {
        int[] nums = [-2, 0, 1, 1, 2];
        IList<IList<int>> expected = [[-2, 0, 2], [-2, 1, 1]];

        var p = new Problem15();

        var result = p.ThreeSum(nums);

        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void TestCase6()
    {
        int[] nums = [2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10];
        IList<IList<int>> expected = [
            [-10, 5, 5],
            [-5, 0, 5],
            [-4, 2, 2],
            [-3, -2, 5],
            [-3, 1, 2],            
            [-2, 0, 2]];

        var p = new Problem15();

        var result = p.ThreeSum(nums);

        result.ShouldBeEquivalentTo(expected);        
    }
}