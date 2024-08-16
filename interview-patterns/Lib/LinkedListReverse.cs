namespace Lib;

public static class LinkedListReverse
{
    public static ListNode Reverse(ListNode head)
    {
        ListNode? prev = null;
        var current = head;

        while (current != null)
        {
            var nextNode = current.Next;
            current.Next = prev;
            prev = current;
            current = nextNode;
        }

        return prev!;
    }
}
