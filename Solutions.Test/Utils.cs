namespace Solutions.Test;

public class Utils
{
    public static ListNode ArrayToList(int[] nums)
    {
        ListNode head = null;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            head = new ListNode(nums[i], head);
        }

        return head;
    }
}