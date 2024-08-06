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
                var lengthPointer = fast.Next;
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
}
