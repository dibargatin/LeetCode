namespace Solutions;

/*
https://leetcode.com/problems/merge-k-sorted-lists/description/

You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

Example 1:
    Input: lists = [[1,4,5],[1,3,4],[2,6]]
    Output: [1,1,2,3,4,4,5,6]
    Explanation: The linked-lists are:
        [
            1->4->5,
            1->3->4,
            2->6
        ]
    merging them into one sorted linked list:
    1->1->2->3->4->4->5->6

Example 2:
    Input: lists = []
    Output: []

Example 3:
    Input: lists = [[]]
    Output: []

Constraints:
    k == lists.length
    0 <= k <= 10^4
    0 <= lists[i].length <= 500
    -10^4 <= lists[i][j] <= 10^4
    lists[i] is sorted in ascending order.
    The sum of lists[i].length will not exceed 10^4.
*/
public class Problem23
{
    public ListNode MergeKLists(ListNode[] lists)
    {

        var current = new ListNode[lists.Length];
        for (int i = 0; i < lists.Length; i++)
            current[i] = lists[i];

        ListNode head = null;
        ListNode cur = null;
        bool anyNotNull = false;

        do
        {
            anyNotNull = false;
            int minPos = int.MaxValue;
            int minVal = int.MaxValue;

            for (int i = 0; i < current.Length; i++)
            {
                if (current[i] is not null)
                {
                    if (current[i].val < minVal)
                    {
                        minVal = current[i].val;
                        minPos = i;
                    }
                    anyNotNull = true;
                }
            }

            if (minPos != int.MaxValue)
            {
                if (head is null)
                {
                    head = current[minPos];
                    cur = head;
                    current[minPos] = current[minPos].next;
                }
                else
                {
                    cur.next = current[minPos];
                    cur = cur.next;
                    current[minPos] = current[minPos].next;
                }
            }
        }
        while (anyNotNull);

        return head;
    }
}