namespace Solutions;

/*
https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/

Given the head of a linked list, remove the nth node from the end of the list and return its head.

Example 1:
    Input: head = [1,2,3,4,5], n = 2
    Output: [1,2,3,5]

Example 2:
    Input: head = [1], n = 1
    Output: []

Example 3:
    Input: head = [1,2], n = 1
    Output: [1]
 
Constraints:
    The number of nodes in the list is sz.
    1 <= sz <= 30
    0 <= Node.val <= 100
    1 <= n <= sz

Follow up: Could you do this in one pass?
*/
public class Problem19
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var t = head;
        var h = head;
        int i = 0;

        while (h is not null && h.next?.next is not null)
        {
            t = t.next;
            h = h.next.next;
            i++;
        }

        ListNode current;

        int length;
        if (t == h && t.next is not null) length = 2;
        else if (t != h && h.next is not null) length = i * 2 + 2;
        else length = i * 2 + 1;

        int start;
        int steps;

        if (length - n == 0) return head.next;
        else if (i < length - n)
        {
            current = t;
            start = i;
            steps = length - n - i - 1;
        }
        else
        {
            current = head;
            start = 0;
            steps = length - n - 1;
        }

        for (int j = start; j < start + steps; j++)
        {
            current = current.next;
        }

        current.next = current.next?.next;

        return head;
    }
}