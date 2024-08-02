using System;
using Xunit;

public class stackWithReverse
{
    [Fact]
    public void Multiple_Elements()
    {
        var stack = new Program.Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        var stackWithReverse = new Program.StackWithReverse();

        stackWithReverse.ReverseStack(stack);

        Assert.Equal(10, stack.Pop());
        Assert.Equal(20, stack.Pop());
        Assert.Equal(30, stack.Pop());

    }
    [Fact]
    public void Single_Element()
    {
        var stack = new Program.Stack();

        stack.Push(10);

        var stackWithReverse = new Program.StackWithReverse();

        stackWithReverse.ReverseStack(stack);

        Assert.Equal(10, stack.Pop());
    }
    [Fact]
    public void Empty_Stack()
    {
        var stack = new Program.Stack();
        var stackWithReverse = new Program.StackWithReverse();

        stackWithReverse.ReverseStack(stack);


        Assert.True(stack.IsEmpty());
    }
}
