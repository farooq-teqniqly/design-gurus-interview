namespace Lib;
public static class LinkedListCycle
{
    public static bool HasCycle(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);

        var slow = head;
        var fast = slow.Next;

        while (fast != null && slow != null)
        {
            if (fast == slow)
            {
                return true;
            }

            fast = fast.Next?.Next;
            slow = slow.Next;
        }
        return false;
    }
}
