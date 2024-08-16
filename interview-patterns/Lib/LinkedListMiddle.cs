namespace Lib;

public static class LinkedListMiddle
{
    public static ListNode FindMiddle(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);

        var slow = head;
        var fast = head;

        while (fast is { Next: not null })
        {
            slow = slow!.Next;
            fast = fast.Next?.Next;
        }

        return slow!;
    }
}
