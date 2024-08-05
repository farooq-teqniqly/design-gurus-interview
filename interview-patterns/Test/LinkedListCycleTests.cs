using FluentAssertions;
using Lib;

namespace Test;
public class LinkedListCycleTests
{
    [Fact]
    public void Returns_True_When_Cycle_1()
    {
        var head = new ListNode(1);
        var tail = head;

        for (var i = 1; i <= 5; i++)
        {
            tail.Next = new ListNode(i + 1);
            tail = tail.Next;
        }

        tail.Next = head;

        LinkedListCycle.HasCycle(head).Should().Be(true);
    }

    [Fact]
    public void Returns_False_When_No_Cycle()
    {
        var head = new ListNode(1);
        var tail = head;

        for (var i = 1; i <= 5; i++)
        {
            tail.Next = new ListNode(i + 1);
            tail = tail.Next;
        }

        LinkedListCycle.HasCycle(head).Should().Be(false);
    }

    [Fact]
    public void Single_Node_No_Cycle_Returns_False()
    {
        var head = new ListNode(1);
        LinkedListCycle.HasCycle(head).Should().Be(false);
    }

    [Fact]
    public void Single_Node_Cycle_Returns_True()
    {
        var head = new ListNode(1);
        head.Next = head;

        LinkedListCycle.HasCycle(head).Should().Be(true);
    }

    [Fact]
    public void Throw_When_Head_Is_Null()
    {
        var act = () => LinkedListCycle.HasCycle(null!);
        act.Should().Throw<ArgumentNullException>();
    }
}
