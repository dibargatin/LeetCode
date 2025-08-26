using Shouldly;
using ListNode = Solutions.Problem2.ListNode;

namespace Solutions.Test;

public class Problem2Test
{
    [Fact]
    public void TestCase1()
    {
        var p = new Problem2();

        var result =
            p.AddTwoNumbers(
                ListNode.New(2,
                    ListNode.New(4,
                        ListNode.New(3))),
                ListNode.New(5,
                    ListNode.New(6,
                        ListNode.New(4))));

        result.ShouldBeEquivalentTo(
            ListNode.New(7,
                ListNode.New(0,
                    ListNode.New(8))));
    }

    [Fact]
    public void TestCase2()
    {
        var p = new Problem2();

        var result =
            p.AddTwoNumbers(
                ListNode.New(0),
                ListNode.New(0));

        result.ShouldBeEquivalentTo(
            ListNode.New(0));
    }

    [Fact]
    public void TestCase3()
    {
        var p = new Problem2();

        var result =
            p.AddTwoNumbers(
                ListNode.New(9,
                    ListNode.New(9,
                        ListNode.New(9,
                            ListNode.New(9,
                                ListNode.New(9,
                                    ListNode.New(9,
                                        ListNode.New(9))))))),
                ListNode.New(9,
                    ListNode.New(9,
                        ListNode.New(9,
                            ListNode.New(9)))));

        result.ShouldBeEquivalentTo(
            ListNode.New(8,
                ListNode.New(9,
                    ListNode.New(9,
                        ListNode.New(9,
                            ListNode.New(0,
                                ListNode.New(0,
                                    ListNode.New(0,
                                        ListNode.New(1)))))))));
    }
}