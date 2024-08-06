using FluentAssertions;
using Lib;

namespace Test;
public class LinkedListCycleTests
{
    [Fact]
    public void Returns_True_When_Cycle()
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
    public void Can_Get_Cycle_Length_1()
    {
        var head = new ListNode(1);
        var tail = head;

        for (var i = 1; i <= 5; i++)
        {
            tail.Next = new ListNode(i + 1);
            tail = tail.Next;
        }

        tail.Next = head;

        LinkedListCycle.GetCycleLength(head).Should().Be(6);
    }

    [Fact]
    public void Can_Get_Cycle_Length_2()
    {
        var head = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);
        var node5 = new ListNode(5);
        var node6 = new ListNode(6);

        head.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node5;
        node5.Next = node6;
        node6.Next = node3;

        LinkedListCycle.GetCycleLength(head).Should().Be(4);
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

    [Fact]
    public void GetStartCycleNode_Returns_Expected_Result_1()
    {
        var head = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);
        var node5 = new ListNode(5);
        var node6 = new ListNode(6);

        head.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node5;
        node5.Next = node6;
        node6.Next = node3;

        LinkedListCycle.GetStartCycleNode(head).Should().Be(node3);
    }

    [Fact]
    public void GetStartCycleNode_Returns_Expected_Resul2()
    {
        var head = new ListNode(1);

        head.Next = head;

        LinkedListCycle.GetStartCycleNode(head).Should().Be(head);
    }
}
