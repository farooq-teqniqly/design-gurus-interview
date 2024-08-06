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

    public static int GetCycleLength(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);

        var slow = head;
        var fast = slow.Next;

        while (fast != null && slow != null)
        {
            if (fast == slow)
            {
                var lengthPointer = fast;
                var cycleLength = 1;

                while (lengthPointer!.Next != fast)
                {
                    cycleLength++;
                    lengthPointer = lengthPointer!.Next;
                }

                return cycleLength;
            }

            fast = fast.Next?.Next;
            slow = slow.Next;
        }

        return 0;
    }

    public static ListNode? GetStartCycleNode(ListNode head)
    {
        var cycleLength = GetCycleLength(head);

        if (cycleLength == 0)
        {
            return null;
        }

        var p1 = head;
        var p2 = head;

        for (var i = 1; i <= cycleLength; i++)
        {
            p2 = p2!.Next;
        }

        while (p1 != p2)
        {
            p1 = p1!.Next;
            p2 = p2!.Next;
        }

        return p1;
    }
}
