using FluentAssertions;
using Lib;

namespace Test;
public class LinkedListMiddleTests
{
    [Fact]
    public void Can_Find_Middle_Of_Odd_Length_List()
    {
        var head = new ListNode(1);
        var tail = head;

        for (var i = 2; i <= 7; i++)
        {
            tail.Next = new ListNode(i);
            tail = tail.Next;
        }

        LinkedListMiddle.FindMiddle(head).Val.Should().Be(4);
    }

    [Fact]
    public void Can_Find_Middle_Of_Even_Length_List()
    {
        var head = new ListNode(1);
        var tail = head;

        for (var i = 2; i <= 6; i++)
        {
            tail.Next = new ListNode(i);
            tail = tail.Next;
        }

        LinkedListMiddle.FindMiddle(head).Val.Should().Be(4);
    }

    [Fact]
    public void Throw_When_Head_Is_Null()
    {
        var act = () => LinkedListMiddle.FindMiddle(null!);

        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Middle_Of_Single_Node_Is_The_Single_Node()
    {
        var head = new ListNode(1);

        LinkedListMiddle.FindMiddle(head).Val.Should().Be(1);
    }
}
