using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Lib;

namespace Test;

public class LinkedListReverseTests
{
    [Fact]
    public void Can_Reverse_List()
    {
        var head = new ListNode(1);
        head.Next = new ListNode(2);
        head.Next.Next = new ListNode(3);

        var newHead = LinkedListReverse.Reverse(head);

        newHead.Val.Should().Be(3);
        newHead.Next!.Val.Should().Be(2);
        newHead.Next.Next!.Val.Should().Be(1);
    }
}
