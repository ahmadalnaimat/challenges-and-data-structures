using System;
using Xunit;

public class StackandQueue
{
    [Fact]
    public void Pushing()
    {
        var stack = new Program.Stack();

        stack.Push(10);

        Assert.Equal(10, stack.Peek());
    }
    [Fact]
    public void Popping()
    {
        var stack = new Program.Stack();

        stack.Push(10);
        stack.Push(20);

        int result = stack.Pop();

        Assert.Equal(20, result);
        Assert.Equal(10, stack.Peek());
    }
    [Fact]
    public void is_it_empty_Stack()
    {
        var stack = new Program.Stack();

        bool result = stack.IsEmpty();

        Assert.True(result);
    }
    [Fact]
    public void enqueueing()
    {
        var queue = new Program.Queue();

        queue.EnQueue(10);

        Assert.Equal(10, queue.Peek());
    }
    [Fact]
    public void dequeueing()
    {
        var queue = new Program.Queue();
        queue.EnQueue(10);
        queue.EnQueue(20);

        int result = queue.DeQueue();

        Assert.Equal(10, result);
        Assert.Equal(20, queue.Peek());
    }
    [Fact]
    public void is_it_empty_Queue()
    {
        var queue = new Program.Queue();

        bool result = queue.IsEmpty();

        Assert.True(result);
    }
}
