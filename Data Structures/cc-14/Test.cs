using System;
using Xunit;
using static Program;

public class MinStackTest
{
    [Fact]
    public void Minimum()
    {
        MinStack minStack = new MinStack();
        minStack.Push(10);
        minStack.Push(20);
        minStack.Push(30);

        int Value = minStack.GetMin();

        Assert.Equal(10, Value);
    }
    [Fact]
    public void Minimum_After_Pop()
    {
        MinStack minStack = new MinStack();
        minStack.Push(30);
        minStack.Push(20);
        minStack.Push(10);

        int popped = minStack.Pop();
        int Value = minStack.GetMin();

        Assert.Equal(10, popped);
        Assert.Equal(20, Value);

    }
    [Fact]
    public void Minimum_After_Push()
    {
        MinStack minStack = new MinStack();
        minStack.Push(10);
        minStack.Push(20);
        minStack.Push(30);

        minStack.Push(1);
        int Value = minStack.GetMin();

        Assert.Equal(1, Value);

    }
}