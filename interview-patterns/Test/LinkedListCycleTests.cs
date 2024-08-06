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
    public void HasCycle_Throw_When_Head_Is_Null()
    {
        var act = () => LinkedListCycle.HasCycle(null!);
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Can_Get_Cycle_Length()
    {
        var head = new ListNode(1);
        var tail = head;

        for (var i = 1; i <= 5; i++)
        {
            tail.Next = new ListNode(i + 1);
            tail = tail.Next;
        }

        tail.Next = head;

        LinkedListCycle.GetCycleLength(head).Should().Be(5);
    }

    [Fact]
    public void Can_Get_Cycle_Length_For_SingleNode()
    {
        var head = new ListNode(1);
        head.Next = head;

        LinkedListCycle.GetCycleLength(head).Should().Be(1);
    }

    [Fact]
    public void GetCycleLength_Throw_When_Head_Is_Null()
    {
        var act = () => LinkedListCycle.GetCycleLength(null!);
        act.Should().Throw<ArgumentNullException>();
    }
}
